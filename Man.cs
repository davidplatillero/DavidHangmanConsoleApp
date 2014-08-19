using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class Man
    {
        public string ReturnMan(int guessesLeft)
        {
            string man = "";

            switch (guessesLeft)
            {
                case 6:
                    man = "";
                    break;
                case  5:
                    man = "     0";
                    break;
                case 4:
                    man = "     0 \n     |";
                    break;
                case  3:
                    man = "     0 \n    -|";
                    break;
                case 2:
                    man = "     0 \n    -|-";
                    break;
                case 1:
                    man = "     0 \n    -|- \n    /";
                    break;
                case 0:
                    man = "     0 \n    -|- \n    / \\   ";
                    break;
            }
            return man;
        }


    }
}
