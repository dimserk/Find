using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find
{
    class Saver
    {

        public static bool ShExist(object wbP, string sShName) // проверка на наличие Листа в книге 
        {
            bool bEx = false;
            object wsPShts = null, wsSh = null;
            wsPShts = wbP.GetType().InvokeMember("Worksheets", System.Reflection.BindingFlags.GetProperty, null, wbP, null);
            try
            {
                wsSh = wsPShts.GetType().InvokeMember("Item", System.Reflection.BindingFlags.GetProperty, null, wsPShts, new object[] { sShName });
                bEx = true;
            }
            catch { bEx = false; }
            return (bEx);
        }

        public static void SaveAsWorksheet(string workSheetName, Workbook workbook, BindingList<RangeView> foundRanges)
        {
            if (ShExist(workbook, "Результат поиска") == false)
            {   //Создаем лист, если лист с таким именем отсутствует
                var newSheet = workbook.Worksheets.Add(Type.Missing, workbook.ActiveSheet, Type.Missing, Type.Missing);
                workbook.ActiveSheet.Name = workSheetName;

                newSheet.Cells[1, 1] = "Результат поиска:";
                newSheet.Cells[2, 1] = "Лист";
                newSheet.Cells[2, 2] = "Ячейка";
                newSheet.Cells[2, 3] = "Текст";

                int i = 3;
                foreach (var range in foundRanges)
                {
                    newSheet.Cells[i, 1] = range.SheetName;
                    newSheet.Cells[i, 2] = range.CellAddress;
                    newSheet.Cells[i, 3] = range.Text;
                    i++;
                }
                newSheet.Columns.AutoFit();
            }
            else
            {
                MessageBox.Show("Такой лист существует");
            }
        }

        public static void SaveAsWorkbook(string workbookName, Workbook workbook, string path, List<Range> foundRanges)
        {
            string fileName = String.Empty;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog1.FileName;
            }
            else
                return;
            // сохраняем Workbook
            workbook.SaveAs(fileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            saveFileDialog1.Dispose();
        }
    }
}
