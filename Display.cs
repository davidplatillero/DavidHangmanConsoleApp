using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Display
    {
        private readonly Man _man;

        public string FullMan
        {
            get { return _man.ReturnMan(0); }
        }

        public Display()
        {
            _man = new Man();
        }

        public void Update(GameState gameState)
        {
            Console.WriteLine(" {0}", gameState.DisplayBlanks);
            Console.WriteLine("Previous Guesses: {0}", gameState.PreviousGuesses);
            Console.WriteLine("Guesses Left: {0}", gameState.GuessesLeft);
            Console.WriteLine(_man.ReturnMan(gameState.GuessesLeft));
        }
    }
}

