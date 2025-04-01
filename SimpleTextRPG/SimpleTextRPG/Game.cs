using SimpleTextRPG.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG
{
    public static class Game
    {
        
        private static bool gameOver = false;
        private static Scene curScene;

        private static Dictionary<string, Scene> sceneDic;
        private static Player player ;
        private static PlayerInventory inventory;

        public static Player Player{ get { return player; } }
        
        public static PlayerInventory Inventory{ get { return inventory; } }

        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("LongLongPlanet", new LongLongPlanetScene());
            sceneDic.Add("SpaceShip", new SpaceShip());
            sceneDic.Add("EngineRoom", new EngineRoom());
            sceneDic.Add("PlanetTown", new PlanetTown());

            curScene = sceneDic["Title"];

            player = new Player();
            player.HP = 1;
            player.Stamina = 1;
            player.GameScore = 0;

            inventory = new PlayerInventory();
            inventory.Tool = 0;
            inventory.Weapon = 0;
            inventory.PartsOfTheEngine = 0;
        }

        public static void Stop()
        {
            if (player.GameScore == 1)
            {
                Console.WriteLine("당신은 이 행성의 지배자로 거듭났습니다.");
                Console.WriteLine("행성의 모두가 당신을 공포의 대상이자 군주로 받아들입니다.");
            }
            else if (player.GameScore == 2)
            {
                Console.WriteLine("당신은 훌륭하게 엔진을 고쳐 귀환하였습니다.");
                Console.WriteLine("지구에서 당신은 그간 겪던 일을 책으로 엮어 유명한 작가가 되었습니다.");
            }
        }

        public static void Run()
        {
            while(gameOver == false)
            {
                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                Console.WriteLine();
                curScene.Next();
            }
        }

        public static void GameOver(string reason)
        {
            Console.WriteLine("──────────────────────────────────────────────────");
            Console.WriteLine("당신은 사망하였습니다.............................");
            Console.WriteLine("──────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }
        public static void GameClear(string reason)
        {
            Console.WriteLine("──────────────────────────────────────────────────");
            Console.WriteLine("당신은 게임을 클리어 했습니다!!!..................");
            Console.WriteLine("──────────────────────────────────────────────────");
            Console.WriteLine();
            Console.WriteLine(reason);

            gameOver = true;
        }
        public static void ChangeScene(string SceneName)
        {
            curScene = sceneDic[SceneName];
        }

        public static void PlayerInfo()
        {
            Console.WriteLine("┌────────────────────────────────────────────────────┐");
            Console.WriteLine("  현재 플레이어 체력: {0}, 플레이어 스태미나: {1}    ", player.HP, player.Stamina);
            Console.WriteLine("└────────────────────────────────────────────────────┘");
            Console.WriteLine("┌───────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("  현재 소지한 방한 도구: {0}, 소지한 무기: {1}, 소지한 엔진부품: {2}  ", inventory.Tool, inventory.Weapon, inventory.PartsOfTheEngine);
            Console.WriteLine("└───────────────────────────────────────────────────────────────────────┘");
        }


    }
}
