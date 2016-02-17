using System.Collections.Generic;
using System;
using System.Linq;

namespace FindReplaceNS.Objects
{
  public class FindReplace
    {
        private string _phrase;
        private string _wordToReplace;
        private string _newWord;

        public FindReplace (string phrase, string wordToReplace, string newWord)
        {
          _phrase = phrase;
          _wordToReplace = wordToReplace;
          _newWord = newWord;
        }

        public string ReplaceWord()
        {
         string newPhrase = _phrase.ToLower();
         string result = newPhrase.Replace(_wordToReplace, _newWord);
         return result;
        }

        public int CountWord()
        {
          int times = 0;

          List<string> phraseSplit = _phrase.Split(' ').ToList();
          for(var i = 0; i < phraseSplit.Count; i++)
          {
            if(phraseSplit[i] == _wordToReplace)
            {
            times ++;
            }
          }

           return times;
          }

        public string WholeWordsOnly()
        {
          string newPhrase = _phrase.ToLower();

          List<string> phraseSplit = _phrase.Split(' ').ToList();
          for (int i = 0; i < phraseSplit.Count; i++)
          {
            Console.WriteLine(phraseSplit[i]);

            if (phraseSplit[i] == _wordToReplace)
            {
              string bestPhrase = phraseSplit[i].Replace(_wordToReplace, _newWord);
              return bestPhrase;
              string joinedList = string.Join(" ", phraseSplit.ToArray());
              return joinedList;
            }
          }
         return newPhrase;
        }
  }
}
