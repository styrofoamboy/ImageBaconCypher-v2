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
    public partial class frmDecrypt : Form
    {
        #region Declarations
        //***************************************************************************
        // Private Fields
        // 
        private string
            _imgFn = null;
        private System.Drawing.Bitmap
            bmp = null;
        #endregion

        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmDecrypt()
        {
            InitializeComponent();
        }
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void frmDecrypt_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.bmp != null)
                this.bmp.Dispose();
        }
        private void fsbSrc_FileBrowserCompleted(object sender, EventArgs e)
        {
            this._imgFn = this.fsbSrc.FileName;
            this.bmp = (Bitmap)Bitmap.FromFile(this._imgFn);
            this.picImgPrev.Image = this.bmp;
        }
        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                CypherGen crypto = new CypherGen();
                this.txtMsg.Text = crypto.DecodeMessage(this.bmp, this.txtKey.Text);
            }
            catch (Exception ex)
            { MessageBox.Show(this, ex.Message, "Error"); }
        }
        #endregion
    }
}
