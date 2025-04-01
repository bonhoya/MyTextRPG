using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG.Scenes
{
    public class PlanetTown : Scene
    {
        public override void Render()
        {
            Console.WriteLine("당신은 낯선 행성의 마을에 도착했다.");
            Console.WriteLine("곧이어 소리를 들은 외계행성 주민들이 나타나기 시작했다.");
            Console.WriteLine("하나 둘 당신을 보고 수근대기 시작했다.");
            Console.WriteLine("그 무리들은 점차 다가왔고 그들중에는 어린아이, 무장한 군인들도 있었다.");
            Console.WriteLine();
            Game.PlayerInfo();
        }
        public override void Choice()
        {
            Console.WriteLine("1. 몸짓을 하며 바디랭귀지로 인사한다.");
            Console.WriteLine("2. 모두 말살해버린다.");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 친절해보이는 얼굴로 바디랭귀지를 구사해보았다.");
                    Console.WriteLine("하지만 주민들은 알아듣지 못한 채 공격하기 시작했다!!!");
                    if (Game.Inventory.Weapon == 1)
                    {
                        Console.WriteLine("하지만 당신에겐 총이 있었고 훌륭하게 그들을 제압했다!");
                        Console.WriteLine("이윽고 당신은 엔진을 고칠 부품을 요구했다.");
                        Console.WriteLine("그들은 덜덜 떨며 엔진을 고칠 부품을 가져왔다.");
                        Game.Inventory.PartsOfTheEngine = 1;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("당신은 맨몸으로 그들에게 맞섰다.");
                        break;
                    }

                case ConsoleKey.D2:
                    Console.WriteLine("당신은 적대적으로 모두를 공격했다.");
                    if (Game.Inventory.Weapon == 1)
                    {
                        Console.WriteLine("당신은 무기를 가지고 있어 모두를 쓰러트릴 수 있었다.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("당신은 맨몸으로 그들에게 맞섰다.");
                        break;
                    }
            }
        }
        public override void Next()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    if (Game.Inventory.Weapon == 1)
                    {
                        Console.WriteLine("당신은 원하는 것을 챙겨 돌아가기로 했다.");
                        Game.ChangeScene("LongLongPlanet");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("당신은 반격을 하려 했지만 너무나 많은 그들에게 당할 수 밖에 없었다.");
                        Console.WriteLine("\\시스템: 당신은 사망하였습니다.\\");
                        Game.GameOver("다수의 무력에 의해 제압당함");
                        break;
                    }
                case ConsoleKey.D2:
                    if (Game.Inventory.Weapon == 1)
                    {
                        Console.WriteLine("당신은 외계행성에서 무력으로 권력을 가지게 되었다!!");
                        Game.Player.GameScore = 1;
                        Game.GameClear("\\낯선 곳의 지배자 엔딩\\");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("당신은 맨몸으로 그들에게 맞섰지만 상대가 되질 않았다.");
                        Console.WriteLine("\\시스템: 당신은 사망하였습니다.\\");
                        Game.GameOver("다수의 무력에 의해 제압당함");
                        break;
                    }
            }

        }
        public override void Wait()
        {
            Console.WriteLine("계속 진행하려면 아무키나 입력");
            Console.ReadKey();
        }
    }
}
