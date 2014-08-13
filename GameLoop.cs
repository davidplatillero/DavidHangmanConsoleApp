using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// I've Changed the code!!!!!
// SO HAVE I!!!!!
namespace HangMan_Console
{
    public class GameLoop
    {
        public void Start(NewGame game)
        {
            //Display GameGUI = new Display();
            //Display.updateDisplay();

            //bool done = false;
            //while(!done)
            //{

            //Menu titlescreen = new Menu()

            //Menu.Start()




            string tempinput = "";
            string lettersUsed = "";
            string message = "";

            int guessesLeft = 5;
            bool done = false;
            string _theword = game.myWord.theWord;

            StringBuilder sbBlanks = new StringBuilder();
            for (int i = 0; i < _theword.Length; i++)
            {
                sbBlanks.Append("_");
            }

            Console.WriteLine("Welcome to Hangman! The word is {0} letters long. Make your best guess!", _theword.Length);

            while (!done)
            {
                
                Console.WriteLine(message);
                Console.WriteLine("word: {0}", _theword);
                Console.WriteLine(" {0}", sbBlanks.ToString() );
                Console.WriteLine("Previous Guesses: {0}", lettersUsed);
                Console.WriteLine("Guesses Left: {0}", guessesLeft +1);
                Console.WriteLine("Guess: ");

                tempinput = Console.ReadLine();
                if (tempinput.Length < 1)
                {
                    Console.Clear();
                    continue;
                }
                tempinput = tempinput[0].ToString();

                if (lettersUsed.Contains(tempinput))
                {
                    message = "Already guessed that!";
                    
                }

                else if (_theword.Contains(tempinput))
                {
                    message = "YAY";
                    lettersUsed += tempinput;
                    int letterindex = 0;
                    //var indeces = new List<int>;

                    for (int i = 0; i < _theword.Length; i++)
                    {

                        letterindex = _theword.IndexOf(tempinput, i);
                        if (letterindex >= 0)
                        {
                            i = letterindex;
                            sbBlanks[i] = tempinput[0];
                        }
                    }

                    if (!sbBlanks.ToString().Contains("_"))
                    {
                       // Console.Clear();
                        Console.WriteLine("You win!!!");
                        done = true;
                        break;
                    }
                    
                }
                else
                {
                    
                    message = "BOO";
                    lettersUsed += tempinput;
                    
                    Console.WriteLine("Guesses Left: {0}", guessesLeft);

                    if (guessesLeft == 0)
                    {
                        Console.Clear();
                        Console.WriteLine("You lose!!");
                        done = true;
                        break;
                    }
                    guessesLeft--;
                }
                Console.Clear();

            }

            Console.ReadLine();
           
        }

    }
}
