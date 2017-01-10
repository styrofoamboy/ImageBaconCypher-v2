namespace ImageBaconCypher2
{
    partial class frmDecrypt
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Drawing.Drawing2D.GraphicsPath graphicsPath1 = new System.Drawing.Drawing2D.GraphicsPath();
            this.fsbSrc = new RainstormStudios.Controls.FileSelectBox();
            this.picImgPrev = new System.Windows.Forms.PictureBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnDecode = new RainstormStudios.Controls.AdvancedButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImgPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // fsbSrc
            // 
            this.fsbSrc.AddExtension = false;
            this.fsbSrc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fsbSrc.ControlTitle = "Select Image File";
            this.fsbSrc.DefaultExtension = "";
            this.fsbSrc.DialogFilter = "";
            this.fsbSrc.DialogFilterIndex = 0;
            this.fsbSrc.DialogTitle = "";
            this.fsbSrc.FileName = "";
            this.fsbSrc.FileNames = new string[0];
            this.fsbSrc.FileSelectType = RainstormStudios.Controls.FileDialogType.Open;
            this.fsbSrc.GlobalBackgroundColor = System.Drawing.SystemColors.Window;
            this.fsbSrc.GlobalFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fsbSrc.GlobalForegroundColor = System.Drawing.SystemColors.WindowText;
            this.fsbSrc.InitialDirectory = "";
            this.fsbSrc.Location = new System.Drawing.Point(12, 12);
            this.fsbSrc.MinimumSize = new System.Drawing.Size(280, 40);
            this.fsbSrc.Name = "fsbSrc";
            this.fsbSrc.RestoreDirectory = false;
            this.fsbSrc.Size = new System.Drawing.Size(676, 40);
            this.fsbSrc.TabIndex = 0;
            this.fsbSrc.FileBrowserCompleted += new System.EventHandler(this.fsbSrc_FileBrowserCompleted);
            // 
            // picImgPrev
            // 
            this.picImgPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgPrev.Location = new System.Drawing.Point(12, 58);
            this.picImgPrev.Name = "picImgPrev";
            this.picImgPrev.Size = new System.Drawing.Size(256, 242);
            this.picImgPrev.TabIndex = 3;
            this.picImgPrev.TabStop = false;
            // 
            // txtKey
            // 
            this.txtKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKey.Location = new System.Drawing.Point(274, 58);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(299, 20);
            this.txtKey.TabIndex = 4;
            // 
            // txtMsg
            // 
            this.txtMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMsg.Location = new System.Drawing.Point(274, 84);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(414, 288);
            this.txtMsg.TabIndex = 6;
            // 
            // btnDecode
            // 
            this.btnDecode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnDecode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnDecode.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnDecode.ButtonShape = graphicsPath1;
            this.btnDecode.CornerFeather = 5;
            this.btnDecode.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDecode.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDecode.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnDecode.HighlightMultiplier = 2F;
            this.btnDecode.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnDecode.HoverHighlightOpacity = 200;
            this.btnDecode.HoverImage = null;
            this.btnDecode.ImagePadding = 0;
            this.btnDecode.Location = new System.Drawing.Point(579, 56);
            this.btnDecode.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnDecode.MouseDownImage = null;
            this.btnDecode.Name = "btnDecode";
            this.btnDecode.Size = new System.Drawing.Size(109, 23);
            this.btnDecode.TabIndex = 7;
            this.btnDecode.Text = "Decode Message";
            this.btnDecode.TextOutline = false;
            this.btnDecode.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnDecode.TextOutlineOpacity = 255;
            this.btnDecode.TextOutlineWeight = 2F;
            this.btnDecode.ThreeDEffectDepth = 50;
            this.btnDecode.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnDecode.UseVisualStyleBackColor = false;
            this.btnDecode.Click += new System.EventHandler(this.btnDecode_Click);
            // 
            // frmDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 384);
            this.Controls.Add(this.btnDecode);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.picImgPrev);
            this.Controls.Add(this.fsbSrc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(700, 400);
            this.Name = "frmDecrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Decode Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDecrypt_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RainstormStudios.Controls.FileSelectBox fsbSrc;
        private System.Windows.Forms.PictureBox picImgPrev;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtMsg;
        private RainstormStudios.Controls.AdvancedButton btnDecode;
    }
}