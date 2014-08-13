using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Word
    {
        public string theWord;

        public void setRandomWord(DataBase wordFile)
        {
            theWord = wordFile.getRandomWord();
            //System.Console.WriteLine(theWord);
        }
    }
}
