using System;

namespace Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();
            board.Initialize();

            Console.CursorVisible = false; // 커서 감추기

            const int WAIT_TICK = 1000 / 30; // 단위가 밀리sec 이므로, 30 프레임
            const char CIRCLE = '\u25cf'; // 원모양

            int lastTick = 0;
            while (true)
            {
                #region 프레임 관리
                // 만약에 경과한 시간이 1/30초보다 작다면
                int currentTick = System.Environment.TickCount;
                if (currentTick - lastTick < WAIT_TICK)
                    continue;
                lastTick = currentTick;
                #endregion

                // 입력: 사용자의 모든 인풋 감지

                // 로직: 입력에 따라 게임 로직을 실행 / 온라인게임, MMORPG는 서버에서 수행

                // 렌더링: 연산된 로직을 게임 세상에 그래픽으로 그려줌
                Console.SetCursorPosition(0, 0);
                
                for (int i = 0; i < 25; i++)
                {
                    for (int j = 0; j < 25; j++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green; // 색상
                        Console.Write(CIRCLE);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}

