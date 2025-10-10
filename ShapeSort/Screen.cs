using System;
using System.Data;

namespace ShapeSort
{
    static public class Screen
    {
        // 시작화면 출력 함수
        static public void PrintStartScreen()
        {
            // 타이틀
            Console.WriteLine("\t\t도형 분류 게임");
            
            // 규칙
            //Console.WriteLine("\t\t{0, 7}", "규칙");
            Console.WriteLine("\n1. ●, □, ▲을 각 바구니에, ⨳을 쓰레기통에 넣으면 됩니다.\n");
            Console.WriteLine("2. 플레이어의 ♥는 5개, ♥가 0 이하로 떨어지면 플레이어의 패배입니다.\n");
            Console.WriteLine("3. ♥가 다 소진되기 전에 대기열에 있는 도형을 모두 분류하면 플레이어의 승리입니다.\n\n");
            
            // 시작 안내
            // 시작 함수 추가
            Console.WriteLine("\t\t→아무키나 눌러 시작하기");
            Console.ReadKey();
        }
        
        // 플레이 화면 출력 함수
        static public void PrintPlayScreen(Shape currentShape)
        {
            // 플레이 화면 출력
            Console.WriteLine("             _____ ____      _    ____  _   _               \n            |_   _|  _ \\    / \\  / ___|| | | |              \n              | | | |_) |  / _ \\ \\___ \\| |_| |              \n              | | |  _ <  / ___ \\ ___) |  _  |              \n              |_| |_| \\_\\/_/   \\_\\____/|_| |_|              ");
            Console.WriteLine("————————————————————————————————————————————————————————————");
            // 도형 출력
            PrintShapeChar(currentShape);
            Console.WriteLine("————————————————————————————————————————————————————————————");
            Console.WriteLine("╔══════════════════╗╔══════════════════╗╔══════════════════╗\n║      ▄████▄      ║║     ▐▀▀▀▀▀▀▌     ║║        ▄▄        ║\n║     ▐██████▌     ║║     ▐      ▌     ║║      ▄████▄      ║\n║      ▀████▀      ║║     ▐▄▄▄▄▄▄▌     ║║     ████████     ║\n╚══════════════════╝╚══════════════════╝╚══════════════════╝");
        }
        
        
        // 플레이어 입력이 들어오면 갱신
        public static void Update(Player inPlayer, ShapeQueue inShapes)
        {
            Console.Clear();
            // 남은 생명 출력
            inPlayer.PrintPlayerLife();
            // 대기열 출력
            inShapes.PrintQueue();
            // 플레이 화면 출력
            PrintPlayScreen(inShapes.CurrentShape());
        }
        
        // 승패 출력 함수
        static public void PrintResult(int count, int life)
        {
            Console.Clear();
            // 승리/패배 문구 출력
            // 승리의 경우
            // 큐를 모두 소진 + 생명이 1 이상
            if (count == 0 && life > 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n                   ██╗    ██╗██╗███╗   ██╗                  \n                   ██║    ██║██║████╗  ██║                  \n                   ██║ █╗ ██║██║██╔██╗ ██║                  \n                   ██║███╗██║██║██║╚██╗██║                  \n                   ╚███╔███╔╝██║██║ ╚████║                  \n                    ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝                  ");
                Console.ResetColor();
                Console.WriteLine("\n당신은 모든 도형을 분류하는데에 성공했습니다. 축하합니다! ");

            }
            // 패배의 경우
            // 생명이 0인 경우
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("\n          ██████╗ ██████╗ ██████╗ ███████╗                  \n         ██╔═══██╗██╔══██╗██╔══██╗██╔════╝                  \n         ██║   ██║██████╔╝██████╔╝███████╗                  \n         ██║   ██║██╔═══╝ ██╔═══╝ ╚════██║                  \n         ╚██████╔╝██║     ██║     ███████║██╗██╗██╗         \n          ╚═════╝ ╚═╝     ╚═╝     ╚══════╝╚═╝╚═╝╚═╝         ");
                Console.ResetColor();
                Console.WriteLine("\n당신은 아쉽게도 주어진 기회를 모두 소진했습니다. \n다음 기회를 노려보세요");
            }
            Console.WriteLine("\t\t→ 종료하기");
            Console.ReadKey();
            Console.Clear();
        }

    }
}