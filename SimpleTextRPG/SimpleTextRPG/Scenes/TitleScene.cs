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
            Console.WriteLine("│            행성                                │");
            Console.WriteLine("│                 표류기                         │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│    PUSH THE ENTER_KEY WHEN YOU WANT START!     │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("│                                                │");
            Console.WriteLine("└────────────────────────────────────────────────┘");
            Console.WriteLine();

        }
        public override void Choice()
        {

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
