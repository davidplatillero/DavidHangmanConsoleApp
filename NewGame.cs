using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class NewGame
    {
        private readonly IDataBase _database;

        public NewGame(IDataBase database)
        {
            _database = database;
            _database.fillDataBase();
            TheWord = _database.getRandomWord();
        }

        public string TheWord {  get; set; }
    }
}