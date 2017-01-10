namespace ImageBaconCypher2
{
    partial class frmEncrypt
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            this.fsbSrcImg = new RainstormStudios.Controls.FileSelectBox();
            this.btnDoEncrypt = new RainstormStudios.Controls.AdvancedButton();
            this.picImgPrev = new System.Windows.Forms.PictureBox();
            this.txtSrcMsg = new System.Windows.Forms.TextBox();
            this.txtSrcMsgKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCharRemain = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImgPrev)).BeginInit();
            this.SuspendLayout();
            // 
            // fsbSrcImg
            // 
            this.fsbSrcImg.AddExtension = false;
            this.fsbSrcImg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fsbSrcImg.DefaultExtension = ".bmp";
            this.fsbSrcImg.DialogFilter = "Image Files|*.bmp;*.png;*.jpg|All Files|*.*";
            this.fsbSrcImg.DialogFilterIndex = 0;
            this.fsbSrcImg.DialogTitle = "";
            this.fsbSrcImg.FileName = "";
            this.fsbSrcImg.FileNames = new string[0];
            this.fsbSrcImg.FileSelectType = RainstormStudios.Controls.FileDialogType.Open;
            this.fsbSrcImg.GlobalBackgroundColor = System.Drawing.SystemColors.Window;
            this.fsbSrcImg.GlobalFlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.fsbSrcImg.GlobalForegroundColor = System.Drawing.SystemColors.WindowText;
            this.fsbSrcImg.InitialDirectory = "";
            this.fsbSrcImg.Location = new System.Drawing.Point(12, 12);
            this.fsbSrcImg.MinimumSize = new System.Drawing.Size(280, 40);
            this.fsbSrcImg.Name = "fsbSrcImg";
            this.fsbSrcImg.RestoreDirectory = false;
            this.fsbSrcImg.Size = new System.Drawing.Size(708, 40);
            this.fsbSrcImg.TabIndex = 0;
            this.fsbSrcImg.FileBrowserCompleted += new System.EventHandler(this.fsbSrcImg_FileBrowserCompleted);
            // 
            // btnDoEncrypt
            // 
            this.btnDoEncrypt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDoEncrypt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(235)))), ((int)(((byte)(246)))));
            this.btnDoEncrypt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnDoEncrypt.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnDoEncrypt.ButtonShape = graphicsPath2;
            this.btnDoEncrypt.CornerFeather = 5;
            this.btnDoEncrypt.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDoEncrypt.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDoEncrypt.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnDoEncrypt.HighlightMultiplier = 2F;
            this.btnDoEncrypt.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnDoEncrypt.HoverHighlightOpacity = 200;
            this.btnDoEncrypt.HoverImage = null;
            this.btnDoEncrypt.ImagePadding = 0;
            this.btnDoEncrypt.Location = new System.Drawing.Point(623, 309);
            this.btnDoEncrypt.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnDoEncrypt.MouseDownImage = null;
            this.btnDoEncrypt.Name = "btnDoEncrypt";
            this.btnDoEncrypt.Size = new System.Drawing.Size(97, 31);
            this.btnDoEncrypt.TabIndex = 1;
            this.btnDoEncrypt.Text = "Encrypt Msg";
            this.btnDoEncrypt.TextOutline = false;
            this.btnDoEncrypt.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnDoEncrypt.TextOutlineOpacity = 255;
            this.btnDoEncrypt.TextOutlineWeight = 2F;
            this.btnDoEncrypt.ThreeDEffectDepth = 50;
            this.btnDoEncrypt.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnDoEncrypt.UseVisualStyleBackColor = false;
            this.btnDoEncrypt.Click += new System.EventHandler(this.btnDoEncrypt_Click);
            // 
            // picImgPrev
            // 
            this.picImgPrev.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImgPrev.Location = new System.Drawing.Point(12, 58);
            this.picImgPrev.Name = "picImgPrev";
            this.picImgPrev.Size = new System.Drawing.Size(256, 242);
            this.picImgPrev.TabIndex = 2;
            this.picImgPrev.TabStop = false;
            // 
            // txtSrcMsg
            // 
            this.txtSrcMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrcMsg.Location = new System.Drawing.Point(274, 58);
            this.txtSrcMsg.Multiline = true;
            this.txtSrcMsg.Name = "txtSrcMsg";
            this.txtSrcMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSrcMsg.Size = new System.Drawing.Size(446, 245);
            this.txtSrcMsg.TabIndex = 3;
            this.txtSrcMsg.TextChanged += new System.EventHandler(this.txtSrcMsg_TextChanged);
            // 
            // txtSrcMsgKey
            // 
            this.txtSrcMsgKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSrcMsgKey.Location = new System.Drawing.Point(329, 315);
            this.txtSrcMsgKey.Name = "txtSrcMsgKey";
            this.txtSrcMsgKey.Size = new System.Drawing.Size(274, 20);
            this.txtSrcMsgKey.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(275, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Msg Pw:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chars Remain:";
            this.label2.Visible = false;
            // 
            // lblCharRemain
            // 
            this.lblCharRemain.Location = new System.Drawing.Point(94, 315);
            this.lblCharRemain.Name = "lblCharRemain";
            this.lblCharRemain.Size = new System.Drawing.Size(100, 16);
            this.lblCharRemain.TabIndex = 7;
            this.lblCharRemain.Visible = false;
            // 
            // frmEncrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 352);
            this.Controls.Add(this.lblCharRemain);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSrcMsgKey);
            this.Controls.Add(this.txtSrcMsg);
            this.Controls.Add(this.picImgPrev);
            this.Controls.Add(this.btnDoEncrypt);
            this.Controls.Add(this.fsbSrcImg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MinimumSize = new System.Drawing.Size(748, 386);
            this.Name = "frmEncrypt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Encrypt Message";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEncrypt_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picImgPrev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RainstormStudios.Controls.FileSelectBox fsbSrcImg;
        private RainstormStudios.Controls.AdvancedButton btnDoEncrypt;
        private System.Windows.Forms.PictureBox picImgPrev;
        private System.Windows.Forms.TextBox txtSrcMsg;
        private System.Windows.Forms.TextBox txtSrcMsgKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCharRemain;
    }
}