using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageBaconCypher2
{
    public partial class frmEncrypt : Form
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        Bitmap
            bmp = null;
        string
            _imgFn;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmEncrypt()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        private void UpdateCharsRemain()
        {
            this.lblCharRemain.Text = string.Format("Characters Remaining: {0}", this.CalcRemainChars().ToString("#,##0"));
        }
        private int CalcRemainChars()
        {
            return (this.bmp == null)
                        ? 0
                        : (int)Math.Floor(((this.bmp.Width * this.bmp.Height) - 1) / 3.0) - this.txtSrcMsg.Text.Length - CypherGen.identString.Length;
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void frmEncrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bmp != null)
                this.bmp.Dispose();
        }
        private void fsbSrcImg_FileBrowserCompleted(object sender, EventArgs e)
        {
            this._imgFn = this.fsbSrcImg.FileName;
            this.bmp = (Bitmap)Bitmap.FromFile(this._imgFn);
            this.picImgPrev.Image = this.bmp;
            this.UpdateCharsRemain();
        }
        private void txtSrcMsg_TextChanged(object sender, EventArgs e)
        {
            this.UpdateCharsRemain();
        }
        private void btnDoEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                using (System.Windows.Forms.SaveFileDialog dlg = new SaveFileDialog())
                {
                    dlg.OverwritePrompt = true;
                    dlg.Title = "Choose output file.";
                    dlg.ValidateNames = true;
                    dlg.AddExtension = true;
                    dlg.DefaultExt = ".bmp";
                    dlg.Filter = "Bitmap Images|*.bmp|All Files|*.*";
                    dlg.FilterIndex = 0;
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        CypherGen crypto = new CypherGen();
                        var encBmp = crypto.EncodeMessage(this.bmp, this.txtSrcMsg.Text, this.txtSrcMsgKey.Text);
                        using (System.IO.FileStream fs = new System.IO.FileStream(dlg.FileName, System.IO.FileMode.Create, System.IO.FileAccess.Write))
                            encBmp.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        encBmp.Dispose();
                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(this, ex.Message, "Error"); }
        }
        #endregion

    }
}
