using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSort
{
    public class Player
    {
        static int life;

        public int Life { get; set; }

        public Player()
        {
            Life = 5;
        }

        // 
        public Shape GetPlayerInput()
        {
            bool isValid = false;
            while (!isValid)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.KeyChar)
                {
                    case 'W':
                        return Shape.Etc;
                    case 'A':
                        return Shape.Circle;
                    case 'S':
                        return Shape.Triangle;
                    case 'D':
                        return Shape.Square;
                    default:
                        continue;
                }
                isValid = true;
            }
            return Shape.Etc;
        }

        // 플레이어가 분류한 도형이 맞는지 판단하는 함수
        public void SortShape(Shape inShape, Shape desBasket)
        {
            if (desBasket == Shape.Etc && inShape != desBasket)
            {
                Life--;
            }
        }
        
    }
}
