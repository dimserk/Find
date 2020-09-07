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
        public List<string> AndWords;
        public List<string[]> OrGroups; // Массив строк, так как оператором ИЛИ могут быть объеденены много слов
        public List<string> NotWords;

        public QueryParser()
        {
            this.AndWords = new List<string>();
            this.OrGroups = new List<string[]>();
            this.NotWords = new List<string>();
        }

        // Метод непосредственного разбора запроса
        //  на вход подаётся строка с запросом
        //  на выходе список подзапросов и список нежелательных слов
        public void Parse(string query)
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
        }

        // Подметод для очистки содержимого списков разбора
        private void ClearQuery()
        {
            this.AndWords.Clear();
            this.OrGroups.Clear();
            this.NotWords.Clear();
        }
    }
}
