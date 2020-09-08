using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Application = Microsoft.Office.Interop.Excel.Application;

namespace Find
{
    class Saver
    {
        private Application App => Globals.ThisAddIn.Application;

        public bool rowSave; // Флаг сохранения строк целиком

        public Saver()
        {
            this.rowSave = false; // Значение по умолчанию
        }

        // Подметод для сохранения списка представлений найденных ячеек на заданном листе
        private void SaveOnWorksheet(ref Worksheet worksheet, ref List<RangeView> ranges)
        {
            // Заполнение шапки

            worksheet.Cells[1, 1] = "Результат поиска:";
            worksheet.Cells[2, 1] = "Лист";
            worksheet.Cells[2, 2] = "Ячейка";
            if (this.rowSave)
            {
                worksheet.Cells[2, 3] = "Строка";
            }
            else
            {
                worksheet.Cells[2, 3] = "Текст";
            }

            // Заполнение значений

            int i = 3;
            foreach (var cell in ranges)
            {
                worksheet.Cells[i, 1] = cell.SheetName;
                worksheet.Cells[i, 2] = cell.CellAddress;

                if (this.rowSave)
                {
                    // Сохранение строк целиком

                    // Получение кол-ва задействованных столбцов и номера строки
                    int columnMaxNum = cell.FoundRange.Worksheet.UsedRange.Columns.Count;
                    int rowNum = cell.FoundRange.Row;

                    // Заполнение 
                    for (int k = 0; k < columnMaxNum; k++)
                    {
                        worksheet.Cells[i, 3 + k] = cell.FoundRange.Worksheet.Cells[rowNum, k + 1];
                    }
                }
                else
                {
                    // Сохранение значений

                    worksheet.Cells[i, 3] = cell.Text;
                }

                i++;
            }

            worksheet.Columns.AutoFit();
        }

        public void SaveAsWorksheet(List<RangeView> foundRanges)
        {
            // Создание нового листа в текущей книге и переключение на него
            var newSheet = (Worksheet)App.Worksheets.Add(After:App.ActiveWorkbook.Sheets[App.ActiveWorkbook.Worksheets.Count]);

            this.SaveOnWorksheet(ref newSheet, ref foundRanges);
        }

        public void SaveAsWorkbook(List<RangeView> foundRanges)
        {
            // Создание новой книги с переключением на неё
            var newWorkbook = App.Workbooks.Add();

            // Получение первого листа в созданной книге
            var newSheet = (Worksheet)newWorkbook.Sheets[1];

            this.SaveOnWorksheet(ref newSheet, ref foundRanges);
        }
    }
}
