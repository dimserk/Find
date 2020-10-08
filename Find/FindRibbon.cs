using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Find
{
    public partial class FindRibbon
    {
        public bool RowFlag;

        private void FindRibbon_Load(object sender, RibbonUIEventArgs e)
        {
            this.RowFlag = false;
        }

        private void FindPane_ToggleButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane.Visible = ((RibbonToggleButton)sender).Checked;
        }

        private void ToggleButtonCell_Click(object sender, RibbonControlEventArgs e)
        {
            this.ToggleButtonRow.Checked = ToggleButtonCell.Checked ? false : true;
            this.SyncRowFlag();
        }

        private void ToggleButtonRow_Click(object sender, RibbonControlEventArgs e)
        {
            this.ToggleButtonCell.Checked = ToggleButtonRow.Checked ? false : true;
            this.SyncRowFlag();
        }

        private void SyncRowFlag()
        {
            this.RowFlag = this.ToggleButtonRow.Checked;
        }
    }
}
