using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Blanks
    {
        public StringBuilder SbBlanks = new StringBuilder();

        public void InitializeBlanks(string myWord)
        {    
            for(int i = 0; i < myWord.Length; i++)
            {
                SbBlanks.Append("_");
            }
        }

        public void FillBlanks(string theWord, string guess)
        {
            for (int i = 0; i < theWord.Length; i++)
            {
                int letterindex = theWord.IndexOf(guess, i, StringComparison.Ordinal);
                if (letterindex >= 0)
                {
                    i = letterindex;
                    SbBlanks[i] = guess[0];
                }
            }
        }

        
    }
}
