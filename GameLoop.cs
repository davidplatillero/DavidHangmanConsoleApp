using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace HangMan_Console
{
    public class GameLoop
    {
        public void Start(NewGame game)
        {
            var gameState = new GameState(game.TheWord);
            var guessValidator = new GuessValidator();
            var display = new Display();

            Console.WriteLine("Welcome to Hangman! \nThe word is {0} letters long. \nMake your best guess!", gameState.TheWord.Length);

            //Console.WriteLine("     0 \n    -|- \n    / \\   ");

            SoundPlayer player = new SoundPlayer(@"C:\Users\david.platillero\Documents\Visual Studio 2012\Projects\HangJohn\HangMan_Console\POL-cactus-land-short.wav");
            player.PlayLooping();

            bool done = false;
            while (!done)
            {
                Console.Write("Guess: ");
                var currentGuess = Console.ReadLine();
                
                if(!guessValidator.Valid(currentGuess))
                {
                    Console.WriteLine("Not a valid input");
                    continue;
                }

                currentGuess = guessValidator.getValidatedString(currentGuess);
                var whatHappened = gameState.ProcessGuess(currentGuess);
                Console.Clear();

                switch (whatHappened)
                {
                    case WhatHappened.Correct:
                        Console.WriteLine("Correct!");
                        break;
                    case WhatHappened.Duplicate:
                        Console.WriteLine("You already guessed that!");
                        break;
                    case WhatHappened.Incorrect:
                        Console.WriteLine("Bummer... that's not in the word!");
                        break;
                    case WhatHappened.Lose:
                        Console.WriteLine("You Lose :( \nThe word was {0} \n{1}",gameState.TheWord, display.FullMan);
                        done = true;
                        break;
                    case WhatHappened.Win:
                        Console.WriteLine("You Win! :) \nThe word was {0}",gameState.TheWord);
                        done = true;
                        break;
                }
                
                if(!done)
                display.Update(gameState);
            }

            Console.ReadLine();
           
        }

    }
}
