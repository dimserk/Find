using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find
{
    class Searcher
    {
        public bool CaseFlag;

        public Searcher()
        {
            this.CaseFlag = false;
        }

        public void SearchInRange(string what, Range where, ref List<Range> searchResultRanges, ref BindingList<RangeView> searchResultList)
        {
            // Debuging
            string rangeArdesses = String.Empty;
            foreach (Range cell in where.Cells)
            {
                rangeArdesses += $"{cell.Address} "; 
            }
            // Debuging

            var foundRange = where.Find(what, MatchCase:this.CaseFlag);
            var worksheetSearchResult = foundRange;

            if (foundRange != null)
            {
                var firstAddress = foundRange.Address;

                while (true)
                {
                    searchResultList.Add(new RangeView(foundRange));

                    try
                    { 
                        foundRange = where.FindNext(foundRange);
                    }
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        return;
                    }

                    if (firstAddress != foundRange.Address)
                    {
                        worksheetSearchResult = Globals.ThisAddIn.Application.Union(worksheetSearchResult, foundRange);
                    }
                    else
                    {
                        break;
                    }
                }

                searchResultRanges.Add(worksheetSearchResult);
            }
        }
    }
}
