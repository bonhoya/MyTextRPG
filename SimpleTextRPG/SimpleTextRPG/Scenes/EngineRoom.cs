using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG.Scenes
{
    public class EngineRoom : Scene
    {
        public override void Render()
        {
            Console.WriteLine("당신은 엔진룸으로 들어왔다.");
            Console.WriteLine("항상 힘차게 윙윙거리던 엔진은 쥐죽은듯 조용하다.");
            Console.WriteLine();
            Game.PlayerInfo();
        }
        public override void Choice()
        {
            Console.WriteLine("1. 엔진을 고쳐본다.");
            Console.WriteLine("2. 엔진을 부순다.");
            Console.WriteLine("3. 엔진을 응원한다.");
            Console.WriteLine("4. 엔진룸에서 나간다.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 엔진을 고치려고 애를 썼다.");
                    Console.WriteLine("하지만 아무일도 일어나지 않았다...");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 엔진을 부쉈다.");
                    Console.WriteLine("그런데... 어라...????");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("당신은 엔진을 응원(?)했다.");
                    Console.WriteLine("하지만 아무일도 일어나지 않았다...");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("당신은 엔진룸에서 나가기로 했다.");
                    break;
            }
        }

        public override void Wait() 
        {
            Console.WriteLine("계속 진행하려면 아무키나 입력");
            Console.ReadKey();

        }


        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D2:
                    Console.WriteLine("\\시스템: 콰─────과광──!!\\");
                    Console.WriteLine("당신은 엔진을 완전히 부숴버렸다.");
                    Console.WriteLine("하지만 그 여파로 자신도 폭발에 휘말려 버렸다.");
                    Console.WriteLine("\\시스템: 당신은 사망하였습니다.\\");
                    Game.GameOver("폭발에 같이 휘말림");
                    break;
                case ConsoleKey.D4:
                    Game.ChangeScene("SpaceShip");
                    break;
            }
        }
    }
}
