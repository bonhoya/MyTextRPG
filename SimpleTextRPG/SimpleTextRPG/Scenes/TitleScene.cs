using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG.Scenes
{
    public class TitleScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│        TEXT                                    │");
            Console.WriteLine("│            RPG                                 │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("└────────────────────────────────────────────────┘");
            Console.WriteLine();

        }
        public override void Choice()
        {
            Console.WriteLine("      PUSH THE ENTER_KEY WHEN YOU WANT START!     ");
        }

        public override void Result() { }
        public override void Wait() { }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.Enter :
                    Game.ChangeScene("LongLongPlanet");
                    break;
            }
        }

        

        

        
    }
}
