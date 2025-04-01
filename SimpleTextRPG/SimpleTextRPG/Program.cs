namespace SimpleTextRPG
{
    internal class Program
    {   // 간단한 텍스트형 RPG를 구현해보자
        /* <조건> 
         * 1. TextRPG 게임의 큰 틀을 분석하고 파악하자
         * 2. 객체지향의 특징을 이용하여 씬을 추가하고 게임의 컨텐츠를 추가하도록 하자.
         * 3. 씬을 자신이 원하는 스토리 라인대로 게임 흐름이 진행될 수 있도록 구성하자.
         * +. 자료구조 및 객체지향을 구사하여 인벤토리 구현을 시도해보자.
        */
        static void Main(string[] args)
        {
            Game.Start();
            Game.Run();
            Game.Stop();
        }
    }
}
