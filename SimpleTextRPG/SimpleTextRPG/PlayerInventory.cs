using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG
{
    public class PlayerInventory
    {
        private int tool;
        public int Tool { get { return tool; } set { tool = value; } }

        private int weapon;
        public int Weapon { get { return weapon; } set { weapon = value; } }

        private int partsOfTheEngine;
        public int PartsOfTheEngine { get { return partsOfTheEngine; } set { partsOfTheEngine = value; } }
    }
}
