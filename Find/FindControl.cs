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

namespace Find
{

    public partial class FindControl : UserControl
    {
        public FindControl()
        {
            InitializeComponent();
        }
        private Application App => Globals.ThisAddIn.Application;

        private void Search_button_Click(object sender, EventArgs e)
        {
            string search = Search_TextBox.Text;
            MessageBox.Show(search);

            var wb = App.ActiveWorkbook;
            var path = wb.FullName;     // возвращает имя книги  (Book5)

            var activeSheet = (Worksheet)App.ActiveSheet;

            var pathSheet = activeSheet.Name;   // возвращает имя листа  (Sheet1)
            var selection = (Range)App.Selection;
            var allCells = activeSheet.Cells.Rows.EntireRow;

            activeSheet.Cells[1, 1] = path;
            activeSheet.Cells[2, 2] = pathSheet;

        }
        
        private void Search_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == (char)Keys.Enter;

            if (e.KeyChar == (char)Keys.Enter)
            {
                Search_button_Click(sender, e);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var wb = App.ActiveWorkbook;
            wb.SaveCopyAs(@"C:\Book_test.xlsx");
        }

    }
}
