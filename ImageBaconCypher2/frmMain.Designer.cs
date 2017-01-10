namespace ImageBaconCypher2
{
    partial class frmMain
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
            System.Drawing.Drawing2D.GraphicsPath graphicsPath2 = new System.Drawing.Drawing2D.GraphicsPath();
            this.label1 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblCopyrightNotice = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCreateMsg = new RainstormStudios.Controls.AdvancedButton();
            this.btnRetrieveMsg = new RainstormStudios.Controls.AdvancedButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(339, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Image Bycon Cypher";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(19, 127);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnCreateMsg);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnRetrieveMsg);
            this.splitContainer1.Size = new System.Drawing.Size(746, 271);
            this.splitContainer1.SplitterDistance = 372;
            this.splitContainer1.TabIndex = 3;
            // 
            // lblCopyrightNotice
            // 
            this.lblCopyrightNotice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCopyrightNotice.AutoSize = true;
            this.lblCopyrightNotice.Location = new System.Drawing.Point(641, 69);
            this.lblCopyrightNotice.Name = "lblCopyrightNotice";
            this.lblCopyrightNotice.Size = new System.Drawing.Size(124, 13);
            this.lblCopyrightNotice.TabIndex = 4;
            this.lblCopyrightNotice.Text = "(C) 2013 Michael Unfried";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(777, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuFile
            // 
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(37, 20);
            this.mnuFile.Text = "File";
            this.mnuFile.Visible = false;
            // 
            // mnuHelp
            // 
            this.mnuHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelpAbout});
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.Size = new System.Drawing.Size(44, 20);
            this.mnuHelp.Text = "Help";
            this.mnuHelp.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.mnuHelp_DropDownItemClicked);
            // 
            // mnuHelpAbout
            // 
            this.mnuHelpAbout.Name = "mnuHelpAbout";
            this.mnuHelpAbout.Size = new System.Drawing.Size(152, 22);
            this.mnuHelpAbout.Text = "About";
            // 
            // btnCreateMsg
            // 
            this.btnCreateMsg.AllowWordWrap = true;
            this.btnCreateMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCreateMsg.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnCreateMsg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnCreateMsg.BorderWidth = 1;
            graphicsPath1.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnCreateMsg.ButtonShape = graphicsPath1;
            this.btnCreateMsg.CornerFeather = 8;
            this.btnCreateMsg.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCreateMsg.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCreateMsg.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnCreateMsg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateMsg.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCreateMsg.HighlightMultiplier = 2F;
            this.btnCreateMsg.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnCreateMsg.HoverHighlightOpacity = 200;
            this.btnCreateMsg.HoverImage = null;
            this.btnCreateMsg.ImagePadding = 0;
            this.btnCreateMsg.Location = new System.Drawing.Point(94, 84);
            this.btnCreateMsg.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnCreateMsg.MouseDownImage = null;
            this.btnCreateMsg.Name = "btnCreateMsg";
            this.btnCreateMsg.Size = new System.Drawing.Size(183, 103);
            this.btnCreateMsg.TabIndex = 0;
            this.btnCreateMsg.Text = "Create a Message";
            this.btnCreateMsg.TextOutline = false;
            this.btnCreateMsg.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnCreateMsg.TextOutlineOpacity = 255;
            this.btnCreateMsg.TextOutlineWeight = 2F;
            this.btnCreateMsg.ThreeDEffectDepth = 50;
            this.btnCreateMsg.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnCreateMsg.UseVisualStyleBackColor = false;
            this.btnCreateMsg.Click += new System.EventHandler(this.btnCreateMsg_Click);
            // 
            // btnRetrieveMsg
            // 
            this.btnRetrieveMsg.AllowWordWrap = true;
            this.btnRetrieveMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRetrieveMsg.BackColor = System.Drawing.Color.SkyBlue;
            this.btnRetrieveMsg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(60)))), ((int)(((byte)(116)))));
            this.btnRetrieveMsg.BorderWidth = 1;
            graphicsPath2.FillMode = System.Drawing.Drawing2D.FillMode.Alternate;
            this.btnRetrieveMsg.ButtonShape = graphicsPath2;
            this.btnRetrieveMsg.CornerFeather = 8;
            this.btnRetrieveMsg.DisabledBackColor = System.Drawing.Color.WhiteSmoke;
            this.btnRetrieveMsg.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnRetrieveMsg.FlatStyle = RainstormStudios.Controls.AdvancedButton.AdvButtonStyle.System;
            this.btnRetrieveMsg.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRetrieveMsg.HighlightMultiplier = 2F;
            this.btnRetrieveMsg.HoverHighlightColor = System.Drawing.Color.Orange;
            this.btnRetrieveMsg.HoverHighlightOpacity = 200;
            this.btnRetrieveMsg.HoverImage = null;
            this.btnRetrieveMsg.ImagePadding = 0;
            this.btnRetrieveMsg.Location = new System.Drawing.Point(94, 84);
            this.btnRetrieveMsg.MinimumSize = new System.Drawing.Size(8, 8);
            this.btnRetrieveMsg.MouseDownImage = null;
            this.btnRetrieveMsg.Name = "btnRetrieveMsg";
            this.btnRetrieveMsg.Size = new System.Drawing.Size(183, 103);
            this.btnRetrieveMsg.TabIndex = 1;
            this.btnRetrieveMsg.Text = "Retrieve a Message";
            this.btnRetrieveMsg.TextOutline = false;
            this.btnRetrieveMsg.TextOutlineColor = System.Drawing.Color.Empty;
            this.btnRetrieveMsg.TextOutlineOpacity = 255;
            this.btnRetrieveMsg.TextOutlineWeight = 2F;
            this.btnRetrieveMsg.ThreeDEffectDepth = 50;
            this.btnRetrieveMsg.ToggleActiveColor = System.Drawing.Color.Empty;
            this.btnRetrieveMsg.UseVisualStyleBackColor = false;
            this.btnRetrieveMsg.Click += new System.EventHandler(this.btnRetrieveMsg_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 410);
            this.Controls.Add(this.lblCopyrightNotice);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RainstormStudios.Controls.AdvancedButton btnCreateMsg;
        private RainstormStudios.Controls.AdvancedButton btnRetrieveMsg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblCopyrightNotice;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripMenuItem mnuHelpAbout;
    }
}