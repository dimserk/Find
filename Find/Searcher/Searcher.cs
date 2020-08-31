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
    // Класс реализующий поиск
    class Searcher
    {
        // Флаг учёта регистра
        public bool CaseFlag;

        public Searcher()
        {
            this.CaseFlag = false;
        }

        // Метод поиска в выборке ячеек
        //  на входе запрос, выборка ячеек в которых будет производиться поиск, ссылка на список выборок и ссылка на список представлений ячеек
        //  на выходе заполненные по резальтатам поиска списки выборок и представлений
        //   список выборок заполняется для каждого листа (0 выборка - 1 лист, 1 выборка - 2 лист и тд)
        //   если на листе ничего не было найдено, то в качестве результата заносится null 
        public void SearchInRange(string what, Range where, ref List<Range> searchResultRanges, ref BindingList<RangeView> searchResultList)
        {
            if (where == null)
            {
                return;
            }

            bool notWordFlag;
            string firstAddress, firstRangeAddress = String.Empty;
            string addresses = String.Empty;
            Range worksheetSearchResult = null, currentFound;
            QueryParser parser = new QueryParser();
            List<string> queries, notWords;

            // Подготовка переменных для обхода сраного бага
            if (where.Cells.Count == 1)
            {
                firstRangeAddress = where.Cells.Address;

                foreach (Range cell in where.Cells)
                {
                    addresses += $"{cell.Address} ";
                }
            }

            // Разбор запроса
            parser.Parse(what, out queries, out notWords);

            // Если в запросе присутсвуют опреаторы И или ИЛИ
            if (queries.Count != 0)
            {
                // Обработка всех подзапросов по очереди
                foreach (var query in queries)
                {
                    firstAddress = String.Empty;
                    currentFound = where.Find(query, MatchCase: this.CaseFlag); // Штатаный поиск

                    // Если что-то нашлось
                    while (currentFound != null)
                    {

                        // !!!Костыль!!!
                        // Непонятный баг функции Find при поиске в списке из одной клетки 
                        if (where.Cells.Count == 1 && !addresses.Contains(currentFound.Address))
                        {
                            try
                            {
                                currentFound = where.FindNext(currentFound);
                            }
                            catch(System.Runtime.InteropServices.COMException)
                            {
                                // Если при поиске в поиске пытаться найти значение которое 
                                //  содержиться в ячейке на листе (или на другом листе) 
                                //  перед найденой ячейкой, то результатом будет ничего
                                currentFound = null;
                            }
                            continue;
                        }

                        // Обработка адреса первой ячейки
                        if (firstAddress == String.Empty)
                        {
                            // Запоминаем адрес первой найденой ячейки
                            firstAddress = currentFound.Address;
                        }
                        else
                        {
                            // Выход из цикла когда резльтаты поиска пойдут по второму кругу
                            //  (когда адрес вновь найденой ячейки совпадёт с первой найденной)
                            if (firstAddress == currentFound.Address)
                            {
                                break;
                            }
                        }

                        // Определение наличия нежелательных слов в поиске 
                        notWordFlag = false;
                        foreach (var notWord in notWords)
                        {
                            // В случае когда выставлен флаг учета регистра обрабатываем соотсветсвующим образом
                            //  когда не выставлен, то обрабатываем без учёта регистра
                            if (this.CaseFlag)
                            {
                                notWordFlag |= ((String)currentFound.Text).Contains(notWord);
                            }
                            else
                            {
                                notWordFlag |= ((String)currentFound.Text).ToLower().Contains(notWord.ToLower());
                            }
                        }

                        // Если в ячейке не было найдено нежалательных слов, то заполняем список представлений
                        //  и формируем общую выборку найденных ячеек
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

                        // Ищим следующую ячейку
                        //  при поиске в поиске могут возникать исключения в случае выборки из одной ячейки
                        if (where.Cells.Count != 1)
                        {
                            currentFound = where.FindNext(currentFound);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }

            // Если в поисковом запросе присутвовали только операторы НЕ
            else
            {
                foreach (Range cell in where.Cells)
                {
                    foreach (var notWord in notWords)
                    {
                        // В соответсвии с флагом учёта регистра ищем нежалетельные слова в ячейке
                        bool containsFlag = false;
                        if (this.CaseFlag)
                        {
                            containsFlag = ((String)cell.Text).Contains(notWord);
                        }
                        else
                        {
                            containsFlag = ((String)cell.Text).ToLower().Contains(notWord.ToLower());
                        }

                        // Если в ячейке не было найдено нежалательных слов, то заполняем список представлений
                        //  и формируем общую выборку найденных ячеек
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

            // Для каждого обработанного листа заполняем список найденных ячеек
            searchResultRanges.Add(worksheetSearchResult);
        }
    }
}
