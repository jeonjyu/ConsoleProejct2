using System;

namespace ShapeSort
{
    static public class Screen
    {
        // 시작화면 출력 함수
        static public void PrintStartScreen()
        {
            // 타이틀
            Console.WriteLine("도형 분류 게임");
            
            // 규칙
            Console.WriteLine("규칙");
            
            // 시작 안내
            // 시작 함수 추가
            Console.WriteLine("아무키나 눌러 시작하기");
        }
        
        // 플레이 화면 출력 함수
        static public void PrintPlayScreen()
        {
            // 플레이 화면 출력
        }
        
        
        // 플레이어 입력이 들어오면 갱신
        static public void Update(Player inPlayer, ShapeQueue inShapes)
        {
            // 남은 생명 출력
            inPlayer.PrintPlayerLife();
            // 대기열 출력
            inShapes.PrintQueue();
            // 플레이 화면 출력
            PrintPlayScreen();
        }
        
        // 승패 출력 함수
        static public void PrintResult(int count, int life)
        {
            // 승리/패배 문구 출력
            // 승리의 경우
            // 큐를 모두 소진 + 생명이 1 이상
            if (count == 0 && life > 0)
            {
                Console.WriteLine("플레이어 승리");
            }
            // 패배의 경우
            // 생명이 0인 경우
            Console.WriteLine("플레이어 패배");
        }

    }
}