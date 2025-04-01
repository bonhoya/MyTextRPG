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
            Console.WriteLine("      PUSH THE ENTER_KEY WHEN YOU WANT START!     ");

        }
        public override void Choice()
        {
            throw new NotImplementedException();
        }
        public override void Result()
        {
            throw new NotImplementedException();
        }
        public override void Wait()
        {
            throw new NotImplementedException();
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.Enter :
                    // TODO 게임 시작에서 본격적인 맵으로 넘기기
                    break;
            }
        }

        

        

        
    }
}
