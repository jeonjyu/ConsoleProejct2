using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ShapeSort
{
    internal class Program
    {
        // static Stopwatch watch = new Stopwatch();
        // static int timeLimit = 90;

        static void Main(string[] args)
        {
            Player player = new Player();

            // 시작 화면 출력
            Screen.PrintStartScreen();
            Console.Clear();
            
            // 대기열 채우기
            ShapeQueue shapes = new ShapeQueue();
            shapes.EqShapes();
            
            // watch.Start();
            // 분류 반복 시작
            while (player.Life > 0 || shapes.Counts() != 0)
            {
                // 화면 변경 + 화면 출력
                Screen.Update(player, shapes);
                player.SortShape(player.GetPlayerInput(), shapes.DqShapes());
            }
            
            // 플레이어 승패 판정
            Screen.PrintResult(shapes.Counts(), player.Life);
        }
    }
}
