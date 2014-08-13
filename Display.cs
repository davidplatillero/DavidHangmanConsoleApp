using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Display
    {
        Stats displayStats = new Stats();

        public Display(Stats gameStats)
        {
            displayStats = gameStats;
        }

        public void update()
        {
            Console.Clear();
            Console.WriteLine(displayStats.guessesLeft);
        }
    }
}

