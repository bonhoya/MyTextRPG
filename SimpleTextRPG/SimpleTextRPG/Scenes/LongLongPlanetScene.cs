using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG.Scenes
{
    public class LongLongPlanetScene : Scene
    {
        public override void Render()
        {
            Console.WriteLine("\\시놉시스\\");
            Console.WriteLine("당신은 우주함선을 운전하는 베테랑 항해사이다...");
            Console.WriteLine("어느때와 같이 임무를 수행하던중...");
            Console.WriteLine("무언가의 습격을 받아 함선의 엔진에 이상이 생겼다───!!!");
            Console.WriteLine("\\시스템: 폭발음\\");
            Console.WriteLine("그대로 불시착하여 이름모를 행성에 추락하게 되는데...");
            Console.WriteLine("....................................................");
            Console.WriteLine("눈을 떠보니 당신은 불시착한 행성에 있었다.");
            Console.WriteLine("함선의 엔진은 망가져 고칠 때까지 이동하지 못한다. 게다가 이 행성은 꽤나 추운듯 하다.");

            Console.WriteLine("당신은 현재 함선의 함장실에 있다.");
            Console.WriteLine("무엇을 할까?");
            Game.PlayerInfo();
        }
        public override void Choice()
        {
            Console.WriteLine("1. 밖으로 나가보자.");
            Console.WriteLine("2. 함선 내부를 둘러보자.");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("당신은 일단 나가보기로 했다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("당신은 일단 함선을 둘러보기로 했다.");
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
                case ConsoleKey.D1:
                    if (Game.Inventory.Tool == 1)
                    {
                        Console.WriteLine("당신은 추위를 느껴 챙겨온 방한도구로 몸을 감쌌다.");
                        Console.WriteLine("\\너무 추운 기온에 체력이 떨어졌다.\\");
                        Game.Player.HP -= 1;
                        Game.Player.Stamina -= 1;
                        if (Game.Player.HP <= 0 && Game.Player.HP <= 0)
                        {
                            Console.WriteLine("당신은 견딜 수 없는 기온에 체력을 모두 뺏겨 그만 쓰려졌다...");
                            Console.WriteLine("\\시스템: 당신은 사망하였습니다.\\");
                            Game.GameOver("사망원인: 감당할 수 없는 추위로 체력을 모두 잃음");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("어느정도 걷자 저 멀리 마을이 보인다.");
                            Console.WriteLine("당신은 그곳으로 가보기로 했다.");
                            Game.ChangeScene("PlanetTown");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("아뿔싸──!! 당신은 아무런 준비도 없이 영하50도의 환경에 노출됐다!!!");
                        Console.WriteLine("\\시스템: 당신은 사망하였습니다.\\");
                        Game.GameOver("사망원인: 방한대책 없이 영하의 기온에 노출");
                        break;
                    }

                case ConsoleKey.D2:
                    Game.ChangeScene("SpaceShip");
                    break;
            }
                
        }
    }
}
