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
            // Бывают и такие ситуации
            if (where == null)
            {
                return;
            }

            // Разбор запроса
            //  результат разбора храниться в самом классе parser
            QueryParser parser = new QueryParser();
            parser.Parse(what);

            Range tmp = null, searchResult = null;
            Range orRange = null;
            foreach (var orGroup in parser.OrGroups) // По каждой группе ИЛИ слов
            {
                orRange = null;

                foreach (var orWord in orGroup) // По каждому слову в ИЛИ группе
                {
                    //  Получение всего найденного диапазона
                    tmp = Search(where, orWord);

                    if (tmp == null)
                    {
                        continue;
                    }

                    if (orRange == null)
                    {
                        orRange = tmp;
                    }
                    else
                    {
                        orRange = Globals.ThisAddIn.Application.Union(orRange, tmp);
                    }
                }
            }

            Range andRange = null;
            if (orRange == null && parser.OrGroups.Count == 0)
            {
                andRange = where;
            }
            else
            {
                andRange = orRange;
            }

            searchResult = null;
            foreach (var andWord in parser.AndWords)
            {
                tmp = Search(andRange, andWord);

                if (tmp == null)
                {
                    continue;
                }

                if (searchResult == null)
                {
                    searchResult = tmp;
                    andRange = tmp;
                }
                else
                {
                    searchResult = Globals.ThisAddIn.Application.Intersect(searchResult, tmp);
                    andRange = searchResult;
                }
            }

            bool notFlag;
            Range res = null;
            if (parser.NotWords.Count > 0 && searchResult != null)
            {
                foreach(Range cell in searchResult)
                {
                    notFlag = false;
                    foreach (var notWord in parser.NotWords)
                    {
                        if (((string)cell.Text).Contains(notWord))
                        {
                            notFlag = true;
                        }
                    }

                    if (!notFlag)
                    {
                        if (res == null)
                        {
                            res = cell;
                        }
                        else
                        {
                            res = Globals.ThisAddIn.Application.Union(res, cell);
                        }
                    }
                }
            }
            else
            {
                res = searchResult;
            }

            // Формирование выходных значений метода
            searchResultRanges.Add(res);
            if (res != null)
            {
                foreach (Range range in res)
                {
                    searchResultList.Add(new RangeView(range));
                }
            }
        } // SearchInRange

        // Подметод для получения диапазона найденных значений
        //  поиск осуществляется в указанном диапазоне (1 параметр)
        private Range Search(Range where, String what)
        {
            // Иногда возникают и такие ситуации
            if (where == null)
            {
                return null;
            }

            string firstAddress, firstRangeAddress = String.Empty;
            string addresses = String.Empty;
            Range searchResult = null, currentFound;

            // Подготовка переменных для обхода сраного бага
            if (where.Cells.Count == 1)
            {
                firstRangeAddress = where.Cells.Address;

                foreach (Range cell in where.Cells)
                {
                    addresses += $"{cell.Address} ";
                }
            }

            firstAddress = String.Empty;
            currentFound = where.Find(what, MatchCase: this.CaseFlag); // Штатаный поиск

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
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        // Если при поиске в поиске пытаться найти значение которое 
                        //  содержиться в ячейке на листе (или на другом листе) 
                        //  перед найденой ячейкой, то результатом будет ничего
                        currentFound = null;
                    }
                    continue;
                }

                // Критерий остановки поиска
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

                // Формирование результирующего диапазона найденных ячеек
                if (searchResult == null)
                {
                    searchResult = currentFound;
                }
                else
                {
                    searchResult = Globals.ThisAddIn.Application.Union(searchResult, currentFound);
                }

                // Ищим следующую ячейку
                //  при поиске в поиске могут возникать исключения в случае выборки из одной ячейки
                //if (where.Cells.Count != 1)
                //{
                    try
                    {
                        currentFound = where.FindNext(currentFound);
                    }
                    catch (System.Runtime.InteropServices.COMException)
                    {
                        break;
                    }
                //}
                //else
                //{
                //    break;
                //}
            }

            return searchResult;
        } // Search
    }
}
