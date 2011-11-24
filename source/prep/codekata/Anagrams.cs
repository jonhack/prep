using System.Collections.Generic;
using System.IO;
using prep.utility;

namespace prep.codekata
{
    public class Anagrams
    {
        private string Filename = "c:\\course\\prep\\words.txt";
        public string[] WordList;

        public Anagrams(string fi)
        {
            ReadFileToWordList();
        }

        public void ReadFileToWordList()
        {
            WordList = File.ReadAllLines(Filename);
        }

        public int count_of_all_words()
        {
            return WordList.Count();
        }
    }
}