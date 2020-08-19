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

        public RangeView(Range foundRange = null)
        {
            this.FoundRange = foundRange;
        }

        public override string ToString()
        {
            return $"{this.FoundRange.Worksheet.Name}-{this.FoundRange.Address.Replace("$", "")}\t=>\t{this.FoundRange.Text}";
        }
    }
}
