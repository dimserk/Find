﻿using System;
using System.Collections.Generic;

namespace QueryAnalyzer
{
    class QueryParser
    {
        private const char AndSplitter = ' ';
        private const char OrSplitter = '|';
        private const char NotSplitter = '-';
        private const char ShouldSplitter = '?';

        private List<string> QueryList;
        private List<string> AndWords;
        private List<string[]> OrGroups;
        private List<string> NotWords;
        private List<string> ShouldWords;

        public QueryParser()
        {
            this.QueryList = new List<string>();
            this.AndWords = new List<string>();
            this.OrGroups = new List<string[]>();
            this.NotWords = new List<string>();
            this.ShouldWords = new List<string>();
        }

        public void Parse(string query, out List<string> queryList, out List<string> notWords)
        {
            this.ClearQuery();

            var words = query.Split(AndSplitter);

            foreach (var word in words)
            {
                if (word.Contains(OrSplitter))
                {
                    var subWords = word.Split(OrSplitter);

                    this.OrGroups.Add(subWords);

                    continue;
                }
                
                if (word[0] == NotSplitter)
                {
                    this.NotWords.Add(word.Remove(0, 1));

                    continue;
                }

                if (word[0] == ShouldSplitter)
                {
                    this.ShouldWords.Add(word.Remove(0, 1));

                    continue;
                }

                this.AndWords.Add(word);
            }

            this.FormQueryList();

            queryList = this.QueryList;
            notWords = this.NotWords;
        }

        private void ClearQuery()
        {
            this.QueryList.Clear();
            this.AndWords.Clear();
            this.OrGroups.Clear();
            this.NotWords.Clear();
            this.ShouldWords.Clear();
        }

        private void FormQueryList()
        {
            // Формирование запроса с основными словами
            var preQuery = String.Join(' ', this.AndWords);

            this.QueryList.Add(preQuery);

            // Формирование или запросов
            foreach (var orGroup in this.OrGroups)
            {
                var newQueryList = new List<string>();

                foreach (var query in this.QueryList)
                {
                    foreach (var orWord in orGroup)
                    {
                        newQueryList.Add(String.Concat(query, orWord));
                    }
                }

                this.QueryList = newQueryList;
            }

            // Формирование необязательных подзапросов
            var copyQueryList = new List<string>(this.QueryList);

            foreach (var shouldWord in this.ShouldWords)
            {
                foreach (var query in copyQueryList)
                {
                    this.QueryList.Add(String.Concat(query, shouldWord));   
                }
            }
        }
    }
}