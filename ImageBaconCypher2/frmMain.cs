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
    public partial class frmMain : Form
    {
        #region Class Constructors
        //***************************************************************************
        // Class Constructors
        // 
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion


        #region Private Methods
        //***************************************************************************
        // Private Methods
        // 
        #endregion

        #region Event Handlers
        //***************************************************************************
        // Event Handlers
        // 
        private void btnCreateMsg_Click(object sender, EventArgs e)
        {
            using (frmEncrypt frm = new frmEncrypt())
                frm.ShowDialog(this);
        }
        private void btnRetrieveMsg_Click(object sender, EventArgs e)
        {
            using (frmDecrypt frm = new frmDecrypt())
                frm.ShowDialog(this);
        }
        #endregion

        private void mnuHelp_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name)
            {
                case "mnuHelpAbout":
                    using (frmAbout frm = new frmAbout())
                        frm.ShowDialog(this);
                    break;
            }
        }
    }
}
