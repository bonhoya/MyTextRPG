using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG
{
    public class Player
    {
        private int hp;
        
        public int HP { get { return hp; } set { hp = value; } }

        private int stamina;

        public int Stamina { get { return stamina; } set { stamina = value; } }

        private int gameScore;

        public int GameScore { get { return gameScore; } set { gameScore = value; } }
    }
}
