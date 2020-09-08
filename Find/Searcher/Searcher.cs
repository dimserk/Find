using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        // Метод поиска в диапазоне ячеек
        //  на входе запрос, диапазон ячеек в которых будет производиться поиск, ссылка на список диапазонов и ссылка на список представлений ячеек
        //  на выходе заполненные по резальтатам поиска списки диапазонов и представлений
        //   список диапазонов заполняется для каждого листа (0ой диапазон - 1 лист, 1ый диапазон - 2 лист и тд)
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

            Range currentFound = null, currentResult = null, currentWhere = where;

            // Усуществление поиска групп ИЛИ слов
            //  довольно объёмная процедура, поэтому вынесена в отдельный подметод 
            currentResult = GroupSearch(ref currentWhere, ref parser.OrGroups);

            // Поиск И слов, при их наличии
            if (parser.AndWords.Count() != 0)
            {
                // Подготовка переменных

                // Если результат null и поиска по ИЛИ словам не было
                if (currentResult == null && parser.OrGroups.Count == 0)
                {
                    currentWhere = where;
                }
                else
                {
                    currentWhere = currentResult;
                }
                currentResult = null;


                // Непосредственно поиск И слов и формирование выходного диапазона 

                foreach (var andWord in parser.AndWords)
                {
                    currentFound = Search(ref currentWhere, andWord);

                    // Если ничего не было найдено, переходим к следующему слову
                    if (currentFound == null)
                    {
                        continue;
                    }

                    // Формирование выходного диапазона
                    if (currentResult == null)
                    {
                        currentResult = currentFound;
                    }
                    else
                    {
                        currentResult = Globals.ThisAddIn.Application.Intersect(currentResult, currentFound);
                    }
                } // foreach (AndWords)
            } // if


            // Обработка НЕ слов

            // Если есть где искать и имеются нежелательные слова для фильтрации
            if (currentResult != null && parser.NotWords.Count > 0)
            {
                // Подготовка переменных

                currentWhere = currentResult;
                currentResult = null;

                bool notFlag;

                foreach (Range cell in currentWhere)
                {
                    // Поиск нежелательных слов в ячейке

                    notFlag = false;
                    foreach (var notWord in parser.NotWords)
                    {
                        if (((string)cell.Text).Contains(notWord))
                        {
                            notFlag = true;
                        }
                    }

                    // Если в ячейке не было обнаружено нежелательных слов,
                    //  то добавляем её в результирующий диапазон,
                    //  иначе просто пропускаем её
                    if (!notFlag)
                    {
                        if (currentResult == null)
                        {
                            currentResult = cell;
                        }
                        else
                        {
                            currentResult = Globals.ThisAddIn.Application.Union(currentResult, cell);
                        }
                    }
                } // forech(currentWhere)
            } // if

            // Формирование выходных значений метода
            searchResultRanges.Add(currentResult);
            if (currentResult != null)
            {
                foreach (Range cell in currentResult)
                {
                    searchResultList.Add(new RangeView(cell));
                }
            }
        } // SearchInRange

        // Подметод для получения диапазона найденных значений
        //  поиск осуществляется в указанном диапазоне (первый параметр)
        private Range Search(ref Range where, String what)
        {
            // Иногда возникают и такие ситуации
            if (where == null)
            {
                return null;
            }

            string firstAddress, firstRangeAddress = String.Empty;
            string addresses = String.Empty;
            Range searchResult = null, currentFound;

            // Подготовка переменных для обхода бага
            //  баг возникает при поиске в диапазоне из одной ячейке
            //  в результате бага выдаётся ячейка, которая не принадлежит указанному диапазону
            //  следовательно формируем струку с адресом исходной ячейки 
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
                try
                {
                    currentFound = where.FindNext(currentFound);
                }
                catch (System.Runtime.InteropServices.COMException)
                {
                    break;
                }
            }

            return searchResult;
        } // Search

        private Range GroupSearch(ref Range where, ref List<string[]> orGroups)
        {
            // Необходимая проверка для корректного функционирования
            if (orGroups.Count() == 0)
            {
                return null;
            }

            // Полный список подзапросов для групп ИЛИ слов
            List<string> queries = new List<string>();
            
            // Формирование полного списка подзапросов
            foreach(var group in orGroups)
            {
                if (queries.Count() == 0)
                {
                    // Начальная инициализация списка подзапросов

                    foreach (var word in group)
                    {
                        queries.Add(word);
                    }
                }
                else
                {
                    // Расширение уже имеющихся запросов

                    // Создание копии уже имеющегося списка запросов
                    string[] queriesCopy = new string[queries.Count];
                    queries.CopyTo(queriesCopy);
                    queries.Clear();

                    // Расширение списка
                    foreach (var query in queriesCopy)
                    {
                        foreach (var word in group)
                        {
                            queries.Add($"{query} {word}");
                        }
                    }
                } //if
            } // foreach (orGroups)

            // Выполнение запросов
            Range currentFound = null, searchResult = null;
            foreach (var query in queries)
            {
                currentFound = Search(ref where, query);

                // Если ничего не было найдено, переходим к следующему слову
                if (currentFound == null)
                {
                    continue;
                }

                // Формирование результирующего диапазона
                if (searchResult == null)
                {
                    searchResult = currentFound;
                }
                else
                {
                    // Объеденяем результаты каждого подзапроса
                    searchResult = Globals.ThisAddIn.Application.Union(searchResult, currentFound);
                }
            } // foreach (queries)

            return searchResult;
        } // GroupSearch
    }
}
