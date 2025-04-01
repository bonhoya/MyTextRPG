namespace SimpleTextRPG.Scenes
{
    public class SpaceShip : Scene
    {
        public override void Render()
        {
            Console.WriteLine("당신은 함선 내부로 들어왔습니다.");
            Console.WriteLine("함선 내부에는 여러가지가 보입니다.");
            Console.WriteLine();
            Game.PlayerInfo();

        }
        public override void Choice()
        {
            Console.WriteLine("1. 엔진의 상태를 확인한다.");
            Console.WriteLine("2. 방한도구를 챙겨간다.");
            Console.WriteLine("3. 무기를 챙긴다.");
            Console.WriteLine("4. 잠시 쉰다.");
            Console.WriteLine("5. 준비는 끝났다. 밖으로 나가보자.");

        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                    Console.WriteLine("엔진룸으로 들어간다.");
                    break;
                case ConsoleKey.D2:
                    Console.WriteLine("방한 도구를 챙깁니다.");
                    break;
                case ConsoleKey.D3:
                    Console.WriteLine("무기를 챙깁니다.");
                    break;
                case ConsoleKey.D4:
                    Console.WriteLine("잠시 쉬어 모든 체력과 스태미나를 회복합니다.");
                    Console.WriteLine("\\시스템: 체력과 스태미나 회복\\");
                    Game.Player.HP = 10;
                    Game.Player.Stamina = 10;
                    break;
                case ConsoleKey.D5:
                    Console.WriteLine("당신은 밖으로 나가기로 했다.");
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
                case ConsoleKey.D5:
                    Game.ChangeScene("LongLongPlanet");
                    break;
            }
        }

    }
}
