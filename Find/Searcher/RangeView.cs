using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    // Класс для отображения данных в таблице во вкладке
    class RangeView
    {
        public Range FoundRange;

        // Имена SheetName, CellAddress и Text пропоисаны 
        //  в полях таблице во вкладке
        //  если менять их имена тут, то нужно соответсвенно поменять и в таблице

        public string SheetName { get; set; }

        public string CellAddress { get; set; }

        public string Text { get; set; }

        public RangeView(string sheetName, string cellAddress, string text, Range foundRange)
        {
            this.SheetName = sheetName;
            this.CellAddress = cellAddress;
            this.Text = text;
            this.FoundRange = foundRange;
        }

        public RangeView(Range foundRange = null)
        {
            this.FoundRange = foundRange;
            
            if (this.FoundRange != null)
            {
                this.SheetName = this.FoundRange.Worksheet.Name;
                this.CellAddress = this.FoundRange.Address.Replace("$", ""); // Преобразование абсолютного адреса ячейки
                this.Text = this.FoundRange.Text;
            }
        }

        public override string ToString()
        {
            return $"{this.SheetName}-{this.FoundRange.Address}";
        }
    }
}
