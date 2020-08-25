using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            if (where == null)
            {
                return;
            }

            bool notWordFlag;
            string firstAddress;
            Range worksheetSearchResult = null, currentFound;
            QueryParser parser = new QueryParser();
            List<string> queries, notWords;

            parser.Parse(what, out queries, out notWords);

            if (queries.Count != 0)
            {
                foreach (var query in queries)
                {
                    firstAddress = String.Empty;
                    currentFound = where.Find(query, MatchCase: this.CaseFlag);

                    // Непонятная ошибка функцииFind при поиске в списке из одной клетки 
                    if (where.Cells.Count == 1 && where.Address != where.Cells[0].Address)
                    {
                        continue;
                    }

                    while (currentFound != null)
                    {
                        if (firstAddress == String.Empty)
                        {
                            firstAddress = currentFound.Address;
                        }
                        else
                        {
                            if (firstAddress == currentFound.Address)
                            {
                                break;
                            }
                        }

                        notWordFlag = false;
                        foreach (var notWord in notWords)
                        {
                            if (this.CaseFlag)
                            {
                                notWordFlag |= ((String)currentFound.Text).Contains(notWord);
                            }
                            else
                            {
                                notWordFlag |= ((String)currentFound.Text).ToLower().Contains(notWord.ToLower());
                            }
                        }

                        if (!notWordFlag)
                        {
                            searchResultList.Add(new RangeView(currentFound));
                            if (worksheetSearchResult == null)
                            {
                                worksheetSearchResult = currentFound;
                            }
                            else
                            {
                                worksheetSearchResult = Globals.ThisAddIn.Application.Union(worksheetSearchResult, currentFound);
                            }
                        }

                        try
                        {
                            currentFound = where.FindNext(currentFound);
                        }
                        catch (System.Runtime.InteropServices.COMException)
                        {
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Range cell in where.Cells)
                {
                    foreach (var notWord in notWords)
                    {
                        bool containsFlag = false;
                        if (this.CaseFlag)
                        {
                            containsFlag = ((String)cell.Text).Contains(notWord);
                        }
                        else
                        {
                            containsFlag = ((String)cell.Text).ToLower().Contains(notWord.ToLower());
                        }

                        if (!containsFlag)
                        {
                            searchResultList.Add(new RangeView(cell));
                            if (worksheetSearchResult == null)
                            {
                                worksheetSearchResult = cell;
                            }
                            else
                            {
                                worksheetSearchResult = Globals.ThisAddIn.Application.Union(worksheetSearchResult, cell);
                            }
                        }
                    }
                }
            }
            
            searchResultRanges.Add(worksheetSearchResult);
        }
    }
}
