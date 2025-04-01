using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTextRPG.Scenes
{
    public abstract class Scene
    {
        protected ConsoleKey input;
        // 게임 신을 들어오면 텍스트를 출력
        public abstract void Render();

        public abstract void Choice();

        public abstract void Result();

        public abstract void Wait();

        public abstract void Next();

        // 특정 키를 입력하기
        public void Input()
        {
            input = Console.ReadKey().Key;
        }
    }
}
