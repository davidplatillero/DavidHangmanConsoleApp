using System;

namespace HangMan_Console
{
    public class GameController
    {
        public void Start()
        {
            const int testgame = 1;
            const int realgame = 2;

            int choice;
            while (true)
            {
                Console.WriteLine("How do you want to play the game? \n{0} = Test \n{1} = Fun", testgame, realgame);
                string input = Console.ReadLine();
                bool isInteger = int.TryParse(input, out choice);

                if (isInteger)
                {
                    if (choice == testgame || choice == realgame)
                        break;
                }

                Console.Clear();
                Console.WriteLine("Not a valid input");
            }

            var gameLoop = new GameLoop();
            var db = new DataBase("words.txt");
            var myGame = new NewGame(db);

            if (choice == testgame)
            {
                Console.WriteLine("What is your test word?");
                myGame.TheWord = Console.ReadLine();
            }

            Console.Clear();
            gameLoop.Start(myGame);
        }
    }
}