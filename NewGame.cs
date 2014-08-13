using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangMan_Console
{
    public class NewGame
    {
        public Word myWord = new Word();
        public DataBase wordDB = new DataBase("words.txt");

        public void InitializeGame()
        {
            wordDB.fillDataBase();
            myWord.setRandomWord(wordDB);
        }
            
    }
}