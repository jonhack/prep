using System.IO;

namespace prep.codekata
{
    public class Anagrams
    {
        private string Filename = "c:\\course\\prep\\words.txt";
        public string[] WordList;

        public Anagrams()
        {
            ReadFileToWordList();
        }

        public void ReadFileToWordList()
        {
            WordList = File.ReadAllLines(Filename);
        }
    }
}