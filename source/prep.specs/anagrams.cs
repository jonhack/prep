using System;
using System.Collections.Generic;
using System.IO;

namespace prep.specs
{
    public class Anagrams
    {
        public string Filename = "C:\course\prep\Wordlist.txt";
        public List<string> Wordlist;


        public Anagrams()
        {
            FillListFromFile();
        }

        public void FillListFromFile()
        {
            string[] words = System.IO.File.ReadAllLines(Filename);
            HashLetterCount(words);
        }

        public void HashLetterCount(string[] words)
        {
            foreach (var word in words)
            {
                
            }
        }
    }
}