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

        public static void SaveAsWorkbook(BindingList<RangeView> foundRanges)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "xls files (*.xlsx)|*.xlsx|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Workbook newWorkbook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);

                Worksheet newSheet = (Worksheet)newWorkbook.Sheets[1];

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

                ObjExcel.Visible = true;
                ObjExcel.UserControl = true;

                newWorkbook.ActiveSheet.Name = "Результат поиска";

                string workbookName = saveFileDialog.FileName;

                newWorkbook.SaveAs(workbookName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
                saveFileDialog.Dispose();
            }
            else
            {
                return;
            }

        }
    }
}
