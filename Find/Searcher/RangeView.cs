using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    class RangeView
    {
        public Range FoundRange;

        public string SheetName { get; set; }

        public string CellAddress { get; set; }

        public string Text { get; set; }

        public RangeView(Range foundRange = null)
        {
            this.FoundRange = foundRange;
            
            if (this.FoundRange != null)
            {
                this.SheetName = this.FoundRange.Worksheet.Name;
                this.CellAddress = this.FoundRange.Address.Replace("$", "");
                this.Text = this.FoundRange.Text;
            }
        }

        public override string ToString()
        {
            return $"{this.SheetName}-{this.FoundRange.Address}";
        }
    }
}
