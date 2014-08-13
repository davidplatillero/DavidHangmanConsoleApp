using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class DataBase
    {
        public string[] wordDataBase;
        public string file;

        public DataBase(string filename)
        {
            file = filename;
        }

        public void fillDataBase()
        {
            char[] delimiterChars = { ' ', '\t' };
            string temp = System.IO.File.ReadAllText(file);

            wordDataBase = temp.Split(delimiterChars);
        }
        public string getRandomWord()
        {
            return wordDataBase[new Random().Next(0, wordDataBase.Length)];
        }
    }
}
