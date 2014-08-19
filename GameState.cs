using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public enum WhatHappened 
    {
        Correct,
        Incorrect,
        Duplicate,
        Win,
        Lose
    }

    public class GameState
    {
        private GuessChecker     guessCheck = new GuessChecker();
        private Blanks           gameBlanks = new Blanks();
  
        public string TheWord { get; private set; }
        public string PreviousGuesses { get; private set; }

        public string DisplayBlanks
        { 
            get
            {
                string tempBlanks = "";
                for (int i = 0; i < gameBlanks.SbBlanks.Length; i++)
                {
                    tempBlanks += gameBlanks.SbBlanks[i] + " ";
                }
                return tempBlanks;
            }
        }

        private int _guessesLeft;

        public int GuessesLeft
        {
            get { return _guessesLeft + 1; }
        }
       
        public GameState(string word)
        {
            PreviousGuesses = "";
            _guessesLeft = 5;
            TheWord = word;
            gameBlanks.InitializeBlanks(TheWord);

        }

        public WhatHappened ProcessGuess(string guess)
        {
            if (guessCheck.Duplicate(guess, PreviousGuesses))
            {
                return WhatHappened.Duplicate;
            }
            
            if (!guessCheck.Correct(guess, TheWord) )
            {
                PreviousGuesses += guess;

                if (_guessesLeft == 0)
                {
                    _guessesLeft--;
                    return WhatHappened.Lose;
                }
                _guessesLeft--;
                return WhatHappened.Incorrect;
            }
          
            gameBlanks.FillBlanks(TheWord, guess);
            PreviousGuesses += guess;
            if (!gameBlanks.SbBlanks.ToString().Contains("_"))
            {
                return WhatHappened.Win;
            }
            return WhatHappened.Correct;
        }
    }
}
