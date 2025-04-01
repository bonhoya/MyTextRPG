using SimpleTextRPG.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG
{
    public static class Game
    {
        
        private static bool gameOver = false;
        private static Scene curScene;

        private static Dictionary<string, Scene> sceneDic;
        private static Player player;
        

        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("LongLongPlanet", new LongLongPlanetScene());

            curScene = sceneDic["Title"];

            player = new Player();
            player.HP = 1;
            player.Stamina = 1;
        }

        public static void Stop()
        {

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

        public static void ChangeScene(string SceneName)
        {
            curScene = sceneDic[SceneName];
        }

        public static void PlayerInfo()
        {
            Console.WriteLine("┌────────────────────────────────────────────────┐");
            Console.WriteLine("│ 현재 플레이어 체력: {0}, 플레이어 스태미나: {1}    │", player.HP, player.Stamina);
            Console.WriteLine("└────────────────────────────────────────────────┘");
        }
    }
}
