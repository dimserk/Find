using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.Excel;
using Application = Microsoft.Office.Interop.Excel.Application;
using System.IO;
using System.Windows.Forms.VisualStyles;

namespace Find
{

    public partial class FindControl : UserControl
    {
        private Application App => Globals.ThisAddIn.Application;

        private Range searchResult; // Хранит в себе результаты поиска 
                                    //  null - если поиска не было или ничего не найдено

        private Dictionary<string, Range> rangeMap;

        public FindControl()
        {
            InitializeComponent();

            rangeMap = new Dictionary<string, Range>();

            Cells_ListBox.SelectedIndexChanged += Select_Cell;
        }


        private void Search_button_Click(object sender, EventArgs e)
        {
            var activeSheet = (Worksheet)App.ActiveSheet;
            var activeRange = (Range)activeSheet.UsedRange;


            if (!String.IsNullOrEmpty(Search_TextBox.Text))
            {
                Cells_ListBox.Items.Clear();
                rangeMap.Clear();
                searchResult = activeRange.Find(Search_TextBox.Text);
            }
            else
            {
                return;
            }

            if (searchResult != null)
            {
                var tmp = searchResult;
                do
                {
                    var s = $"{tmp.Address.Replace("$", "")}  =>  {tmp.Text}";
                    Cells_ListBox.Items.Add(s);
                    rangeMap.Add(s, tmp);
                    tmp = activeRange.FindNext(tmp);
                } while (searchResult.Address != tmp.Address);
            }

            if (Cells_ListBox.Items.Count != 0)
            {
                SaveBook_Button.Enabled = true;
                SaveSheet_Button.Enabled = true;
            }
            else
            {
                SaveBook_Button.Enabled = false;
                SaveSheet_Button.Enabled = false;
            }
        }
        
        private void Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;

            if (e.KeyChar == (char)Keys.Enter)
            {
                Search_button_Click(sender, e);
            }
        }

        private void Select_Cell(object sender, EventArgs e)
        {
            rangeMap[Cells_ListBox.SelectedItem.ToString()].Activate();
        }
    }
}
