using System;
using System.Collections.Generic;

namespace Find
{
    // Класс для разбора поискового запроса
    class QueryParser
    {
        // Разделители слов
        private const char AndSplitter = ' '; 
        private const char OrSplitter = '|';
        private const char NotSplitter = '-';

        // Списки, задействуемые в процессе разбора запроса
        private List<string> QueryList; // Список итоговых подзапросов
        private List<string> AndWords;
        private List<string[]> OrGroups; // Массив строк, так как оператором ИЛИ могут быть объеденены много слов
        private List<string> NotWords;

        public QueryParser()
        {
            this.QueryList = new List<string>();
            this.AndWords = new List<string>();
            this.OrGroups = new List<string[]>();
            this.NotWords = new List<string>();
        }

        // Метод непосредственного разбора запроса
        //  на вход подаётся строка с запросом
        //  на выходе список подзапросов и список нежелательных слов
        public void Parse(string query, out List<string> queryList, out List<string> notWords)
        {
            this.ClearQuery();

            // Разделение слов в запросе по оператору И
            var words = query.Trim(' ').Split(AndSplitter);

            foreach (var word in words)
            {
                // Обработка групп слов, объеденённых оператором ИЛИ
                if (word.Contains(OrSplitter.ToString()))
                {
                    var subWords = word.Split(OrSplitter);

                    this.OrGroups.Add(subWords);

                    continue;
                }

                // Обработка нежелательных слов
                if (word[0] == NotSplitter)
                {
                    this.NotWords.Add(word.Remove(0, 1));

                    continue;
                }

                // Если слово не попало в предыдущие категории
                this.AndWords.Add(word);
            }

            this.FormQueryList();

            queryList = this.QueryList;
            notWords = this.NotWords;
        }

        // Подметод для очистки содержимого списков разбора
        private void ClearQuery()
        {
            this.QueryList.Clear();
            this.AndWords.Clear();
            this.OrGroups.Clear();
            this.NotWords.Clear();
        }

        // Подметод для формирования списка подзапросов
        private void FormQueryList()
        {
            // Формирование запроса со словами, объединенными оператором И
            var preQuery = String.Join(" ", this.AndWords);

            // Если И слов в запросе не было, то не добавляем пустой подзапрос в итоговый список
            if (preQuery != String.Empty)
            { 
                this.QueryList.Add(preQuery);
            }

            // Формирование ИЛИ запросов
            foreach (var orGroup in this.OrGroups)
            {
                var newQueryList = new List<string>();

                // Обработка случая с отсутвием И слов
                if (this.QueryList.Count != 0)
                {
                    // Расширяем каждый запрос ИЛИ словами
                    foreach (var query in this.QueryList)
                    {
                        // Каждая группа ИЛИ слов сливается с основными запросами
                        foreach (var orWord in orGroup)
                        {
                            newQueryList.Add(String.Concat(query, orWord));
                        }
                    }
                }
                else
                {
                    // Так как И слов нет, просто добавляем ИЛИ слова
                    foreach (var orWord in orGroup)
                    {
                        newQueryList.Add(orWord);
                    }
                }

                // Дополнение списка подзапросов ИЛИ подзапросами
                this.QueryList = newQueryList;
            }
        }
    }
}
