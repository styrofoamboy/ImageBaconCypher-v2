using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageBaconCypher2
{
    class CypherGen
    {
        #region Declarations
        //***************************************************************************
        // Constants
        // 
        const string
            alphabetChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ.,! ?'\"[]()-=_+abcedfghijklmnopqrstuvwxyz@#$%^&*/1234567890";
        public const string
            identString = "ICANHAZMSG";
        static int
            bitStrength = 256;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public CypherGen()
        {
        }
        #endregion

        #region Public Methods
        //***************************************************************************
        // Public Methods
        // 
        public System.Drawing.Bitmap EncodeMessage(System.Drawing.Bitmap bmp, string msg, string key)
        {
            // First, we're going to determine a "seed" value, based on a bunch of random stuff.
            int seed = this.GetSeed(bmp, key);

            // Now, we're going to encrypt the original message using Rijndael.
            string msgToEnc = identString + System.Web.HttpUtility.UrlEncode(msg.Trim());
            Dictionary<string, string> cypher = this.GetCypher(seed, false);

            byte[] encData = this.Encrypt(msgToEnc, key, bitStrength, seed);
            string encStr = Convert.ToBase64String(encData);

            // Now, we're going to determine the HMAC hash of our encrypted data, so that we can authenticate during decryption that the data hasn't been altered.
            System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(System.Text.Encoding.UTF8.GetBytes(key));
            byte[] hmacData = md5.ComputeHash(Encoding.UTF8.GetBytes(encStr));
            string hmacStr = Convert.ToBase64String(hmacData);

            // Now, we're going to re-encrypt the data using a key that is a combination of the original key plus the HMAC
            encData = this.Encrypt(encStr, key + hmacStr, bitStrength, seed);
            encStr = Convert.ToBase64String(encData);

            // Now, we're going to combine our encrypted data and hmac, then encrypt those together.
            string fullMsgString = encStr + hmacStr;
            byte[] finalMsgEnc = this.Encrypt(fullMsgString, key, bitStrength, seed);
            string finalMsg64 = Convert.ToBase64String(finalMsgEnc);

            // FF:: "bit-shift" the characters in the Base64 string.

            // Now, we're ready to turn our encrypted string into cypher-text.
            int x = 0, y = 0;
            for (int charPos = 0; charPos < finalMsg64.Length; charPos++)
            {
                // Get the current character.
                string curChar = finalMsg64.Substring(charPos, 1);

                // Now, determine the character's cypher code.
                string cypherCode = null;
                try
                { cypherCode = cypher[curChar]; }
                catch (KeyNotFoundException ex)
                { throw new Exception("Unable to determine cypher value for character: " + curChar, ex); }

                // Then, we set the pixel's bits to match the cypher.
                for (int i = 0; i < cypherCode.Length; i += 3)
                {
                    x = x + 1;
                    if (x >= bmp.Width)
                    { x = 0; y = y + 1; }
                    if (y >= bmp.Height)
                        throw new Exception("The image is too small to contain the selected message.");

                    // Get the pixel at the current position.
                    System.Drawing.Color cpxl = bmp.GetPixel(x, y);
                    int r = Convert.ToInt32(cpxl.R),
                        g = Convert.ToInt32(cpxl.G),
                        b = Convert.ToInt32(cpxl.B);

                    if (cypherCode.Substring(i, 1) != (r % 2).ToString())
                        if (r < 255) r++; else r--;
                    if (cypherCode.Substring(i + 1, 1) != (g % 2).ToString())
                        if (g < 255) g++; else g--;
                    if (i + 2 < cypherCode.Length)
                    {
                        if (cypherCode.Substring(i + 2, 1) != (b % 2).ToString())
                            if (b < 255) b++; else b--;
                    }
                    else
                    {
                        // For the "nineth" byte, we define whether or not this
                        //   is the last character by specifying an odd bit.
                        if (charPos < finalMsg64.Length - 1)
                        {
                            if ((b % 2) != 0)
                            { if (b < 255) b++; else b--; }
                        }
                        else
                        {
                            if ((b % 2) != 1)
                            { if (b < 255) b++; else b--; }
                        }
                    }

                    // Once we have the correct color values, we just have to write the pixel back to the image.
                    System.Drawing.Color nClr = System.Drawing.Color.FromArgb(cpxl.A, r, g, b);
                    bmp.SetPixel(x, y, nClr);
                }
            }

            // All done.  Return the image with the encoded message.
            return bmp;
        }
        public string DecodeMessage(System.Drawing.Bitmap bmp, string key)
        {
            int seed = this.GetSeed(bmp, key);
            Dictionary<string, string> cypher = this.GetCypher(seed, true);

            int x = 1, y = 0;
            StringBuilder sb = new StringBuilder();
            for (int i = x; i < bmp.Width * bmp.Height; i += 9)
            {
                System.Drawing.Color cPxl1 = bmp.GetPixel(x, y);
                int r1 = Convert.ToInt32(cPxl1.R),
                    g1 = Convert.ToInt32(cPxl1.G),
                    b1 = Convert.ToInt32(cPxl1.B);

                x = x + 1;
                if (x >= bmp.Width)
                { x = 0; y = y + 1; }
                if (y >= bmp.Height)
                    throw new Exception("No message found.");

                System.Drawing.Color cPxl2 = bmp.GetPixel(x, y);
                int r2 = Convert.ToInt32(cPxl2.R),
                    g2 = Convert.ToInt32(cPxl2.G),
                    b2 = Convert.ToInt32(cPxl2.B);

                x = x + 1;
                if (x >= bmp.Width)
                { x = 0; y = y + 1; }
                if (y >= bmp.Height)
                    throw new Exception("No message found.");

                System.Drawing.Color cPxl3 = bmp.GetPixel(x, y);
                int r3 = Convert.ToInt32(cPxl3.R),
                    g3 = Convert.ToInt32(cPxl3.G),
                    b3 = Convert.ToInt32(cPxl3.B);

                x = x + 1;
                if (x >= bmp.Width)
                { x = 0; y = y + 1; }
                if (y >= bmp.Height)
                    throw new Exception("No message found.");

                int c1 = (r1 % 2),
                    c2 = (g1 % 2),
                    c3 = (b1 % 2),
                    c4 = (r2 % 2),
                    c5 = (g2 % 2),
                    c6 = (b2 % 2),
                    c7 = (r3 % 2),
                    c8 = (g3 % 2),
                    c9 = (b3 % 2);

                // Determine the bit's "code value" and find the matching character from the cypher.
                string cypherCode = GetCypherCode(c1, c2, c3, c4, c5, c6, c7, c8);
                try
                { sb.Append(cypher[cypherCode]); }
                catch (KeyNotFoundException)
                { throw new Exception("No message found."); }

                // If the last bit of the 3rd pixel is odd, then we've reached the end of the message.
                if (c9 == 1)
                    break;
            }

            // Now that we've got the initial de-cyphered value, we need to decrypt it.
            byte[] rawData = Convert.FromBase64String(sb.ToString());
            byte[] encData = this.Decrypt(rawData, key, bitStrength, seed);

            //int padStart = encData.Length;
            // We can sometimes end up with '0' padding bytes at the end of the encryption.
            int padStart = encData.Length - 1;
            while (encData[padStart] == 0)
                padStart = padStart - 1;
            padStart = padStart + 1;

            // Now, we've got a byte array containing (possibly) our encrypted message, and it's HMAC hash.
            //   The first thing we need to do is seperate the encrypted message from the HMAC, then
            //   re-hash the message to make sure we get the same HMAC.
            byte[] encMsgRaw = new byte[padStart - 24];
            Buffer.BlockCopy(encData, 0, encMsgRaw, 0, encMsgRaw.Length);

            byte[] hmac = new byte[24];
            Buffer.BlockCopy(encData, padStart - 24, hmac, 0, hmac.Length);

            // Turn our encoded msg bytes back into a string.
            string encMsgB64Str = Encoding.UTF8.GetString(encMsgRaw);

            // Base64 strings are required to be a length with a multiple of 4, so we need to 'pad' with "=" to make the length correct.
            encMsgB64Str = encMsgB64Str.PadRight((int)Math.Ceiling(encMsgB64Str.Length / 4.0) * 4, '=');

            byte[] encMsgB64Bytes = Convert.FromBase64String(encMsgB64Str);
            System.Security.Cryptography.HMACMD5 md5 = new System.Security.Cryptography.HMACMD5(System.Text.Encoding.UTF8.GetBytes(key));
            byte[] encMsgHmac = md5.ComputeHash(Encoding.UTF8.GetBytes(encMsgB64Str));
            string newHmacStr = Convert.ToBase64String(encMsgHmac);
            string oldHmacStr = Encoding.UTF8.GetString(hmac);
            if (newHmacStr != oldHmacStr)
                throw new Exception("No message found.");

            // If we got here, our crypto-msg HMAC matches the original, so we're good to decrypt the original message.
            byte[] decrMsg = this.Decrypt(encMsgB64Bytes, key, bitStrength, seed);

            // Finally, return the plain-text string.
            string decrMsgStr = System.Web.HttpUtility.UrlDecode(System.Text.Encoding.UTF8.GetString(decrMsg).TrimStart());

            if (!decrMsgStr.StartsWith(identString))
                throw new Exception("No message found.");

            return decrMsgStr.Replace(identString, "");
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private Dictionary<string, string> GetCypher(int seed, bool decrypt)
        {
            // Build the cyper based on the seed value.
            int itrCnt = (int)Math.Abs(seed.ToString().GetHashCode() / 4096);

            // Determine the cypher code for the letter "A" first.
            int c1 = 0, c2 = 0, c3 = 0, c4 = 0, c5 = 0, c6 = 0, c7 = 0, c8 = 0, c9 = 0;
            for (int i = 0; i < itrCnt; i++)
                this.IncrementCypherCode(ref c1, ref c2, ref c3, ref c4, ref c5, ref c6, ref c7, ref c8, ref c9);

            // Now build the entire cypher.
            //string[] retCypher = new string[alphabet.Count];
            string[] alphas = this.LoadAlphaLookupTable();
            Dictionary<string, string> retCypher = new Dictionary<string, string>();
            for (int i = 0; i < alphas.Length; i++)
            {
                if (!decrypt)
                    retCypher.Add(alphas[i], this.GetCypherCode(c1, c2, c3, c4, c5, c6, c7, c8, c9));
                else
                    retCypher.Add(this.GetCypherCode(c1, c2, c3, c4, c5, c6, c7, c8), alphas[i]);
                this.IncrementCypherCode(ref c1, ref c2, ref c3, ref c4, ref c5, ref c6, ref c7, ref c8, ref c9);
            }

            // And return the completed cypher to the caller.
            return retCypher;
        }
        private void IncrementCypherCode(ref int c1, ref int c2, ref int c3, ref int c4, ref int c5, ref int c6, ref int c7, ref int c8, ref int c9)
        {
            c9++;
            if (c9 > 1)
            { c8++; c9 = 0; }
            if (c8 > 1)
            { c7++; c8 = 0; }
            if (c7 > 1)
            { c6++; c7 = 0; }
            if (c6 > 1)
            { c5++; c6 = 0; }
            if (c5 > 1)
            { c4++; c5 = 0; }
            if (c4 > 1)
            { c3++; c4 = 0; }
            if (c3 > 1)
            { c2++; c3 = 0; }
            if (c2 > 1)
            { c1++; c2 = 0; }
            if (c1 > 1)
            { c9++; c1 = 0; }
        }
        private string GetCypherCode(params int[] vals)
        {
            if (vals.Length < 8)
                throw new Exception("Not enough values.");

            return GetCypherCode(vals[0], vals[1], vals[2], vals[3], vals[4], vals[5], vals[6], vals[7]);
        }
        private string GetCypherCode(int c1, int c2, int c3, int c4, int c5, int c6, int c7, int c8)
        {
            return c1.ToString() + c2.ToString() + c3.ToString() + c4.ToString() + c5.ToString() + c6.ToString() + c7.ToString() + c8.ToString();
        }
        private string[] LoadAlphaLookupTable()
        {
            // This is a dirty way to do this, I know, but I don't really
            //   expect the alphabet to be changing anytime soon, so...
            string[] alphas = new string[alphabetChars.Length];
            for (int i = 0; i < alphabetChars.Length; i++)
                alphas[i] = alphabetChars[i].ToString();
            return alphas;
        }
        private int GetSeed(System.Drawing.Bitmap bmp, string key)
        {
            return bmp.GetPixel(0, 0).ToArgb() + key.GetHashCode();
        }
        private byte[] Encrypt(string msg, string pw, int dwKeySize, int seed)
        {
            byte[] msgBytes = Encoding.UTF8.GetBytes(msg);
            byte[] saltBytes = Encoding.ASCII.GetBytes(seed.ToString().PadLeft(16, '0'));
            byte[] keyBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(pw.GetHashCode().ToString(), saltBytes).GetBytes(dwKeySize / 8);
            var symKey = new System.Security.Cryptography.RijndaelManaged() { Mode = System.Security.Cryptography.CipherMode.CBC, Padding = System.Security.Cryptography.PaddingMode.Zeros };
            var encryptor = symKey.CreateEncryptor(keyBytes, saltBytes);

            byte[] encBytes;

            using(var ms = new System.IO.MemoryStream())
            using (var cryptoStream = new System.Security.Cryptography.CryptoStream(ms, encryptor, System.Security.Cryptography.CryptoStreamMode.Write))
            {
                cryptoStream.Write(msgBytes, 0, msgBytes.Length);
                cryptoStream.FlushFinalBlock();
                encBytes = ms.ToArray();
                cryptoStream.Close();
                ms.Close();
            }
            return encBytes;
        }
        private byte[] Decrypt(byte[] encData, string pw, int dwKeySize, int seed)
        {
            byte[] saltBytes = Encoding.ASCII.GetBytes(seed.ToString().PadLeft(16, '0'));
            byte[] keyBytes = new System.Security.Cryptography.Rfc2898DeriveBytes(pw.GetHashCode().ToString(), saltBytes).GetBytes(dwKeySize / 8);
            var symKey = new System.Security.Cryptography.RijndaelManaged() { Mode = System.Security.Cryptography.CipherMode.CBC, Padding = System.Security.Cryptography.PaddingMode.Zeros };
            var decryptor = symKey.CreateDecryptor(keyBytes, saltBytes);

            byte[] decBytes = new byte[encData.Length];
            using (var ms = new System.IO.MemoryStream(encData))
            using (var cryptoStream = new System.Security.Cryptography.CryptoStream(ms, decryptor, System.Security.Cryptography.CryptoStreamMode.Read))
            {
                cryptoStream.Read(decBytes, 0, decBytes.Length);
                ms.Close();
                cryptoStream.Close();
            }
            return decBytes;
        }
        #endregion
    }
}
