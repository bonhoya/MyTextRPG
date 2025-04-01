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
        

        public static void Start()
        {
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

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
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }

        
    }
}
