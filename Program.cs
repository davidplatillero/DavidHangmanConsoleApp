﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController game = new GameController();
            game.Start();

            //System.Console.ReadLine();
        }
    }
}
