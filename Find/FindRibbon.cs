using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;

namespace Find
{
    public partial class FindRibbon
    {
        private void FindRibbon_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void FindPane_ToggleButton_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.TaskPane.Visible = ((RibbonToggleButton)sender).Checked;
        }
    }
}
