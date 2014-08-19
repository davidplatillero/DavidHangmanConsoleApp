using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    class GuessValidator
    {
        public bool Valid(string guess)
        {
            if (guess.Length < 1)
            {
                return false;
            }
            return true;
        }

        public string getValidatedString(string guess)
        {
            guess = guess[0].ToString();
            return guess;
        }
    }
}
