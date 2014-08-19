using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HangMan_Console
{
    public interface IDataBase
    {
        void fillDataBase();
        string getRandomWord();
    }

    public class DataBase : IDataBase
    {
        public string File;
        public string[] WordDataBase;
        public List<string> bigWordDataBase = new List<string>();

        public DataBase(string filename)
        {
            File = filename;
        }

        public void fillDataBase()
        {
            char[] delimiterChars = {' ', '.', '\t', '\r', '\n', ':'};

            string temp = System.IO.File.ReadAllText(File);

            var matches = Regex.Matches(temp, @"([a-z]+)", RegexOptions.IgnoreCase | RegexOptions.Multiline);

            WordDataBase = temp.Split(delimiterChars);

            foreach (var word in matches.Cast<object>().Select(match => match.ToString()).Where(word => word.Length > 3))
            {
                if(!bigWordDataBase.Contains(word))
                    bigWordDataBase.Add(word);
            }
        }

        public string getRandomWord()
        {
            return bigWordDataBase[new Random().Next(0, bigWordDataBase.Count)];
        }
    }
}