using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class GameController
    {
        public void Start()
        {
            var gameLoop = new GameLoop();
            var myGame = new NewGame();
            myGame.InitializeGame();
            gameLoop.Start(myGame);
        }
    }
}
