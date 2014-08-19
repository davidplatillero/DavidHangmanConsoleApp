using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class GuessChecker
    {
        public bool Correct(string guess, string theWord)
        {
            return theWord.Contains(guess);
        }

        public bool Duplicate(string guess, string previousGuesses)
        {
            return previousGuesses.Contains(guess);
        }
    }
}
