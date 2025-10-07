using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeSort
{
    public class Player
    {
        int life;

        public int Life { get; set; }

        public Player()
        {
            life = 5;
        }

        /// <summary>
        /// 플레이어 입력 받는 함수<br/>
        /// 방향키를 입력받아 할당된 도형을 반환<br/>
        /// wasd가 아니면 다시 입력받도록 무한반복
        /// </summary>
        /// <returns>각 키에 할당된 Shape 열거형</returns>
        public Shape GetPlayerInput()
        {
            while (true)
            {
                ConsoleKeyInfo input = Console.ReadKey(true);
                switch (input.KeyChar)
                {
                    case 'w':
                        return Shape.Etc;
                    case 'a':
                        return Shape.Circle;
                    case 's':
                        return Shape.Square;
                    case 'd':
                        return Shape.Triangle;
                    default:
                        continue;
                }
            }
        }

        /// <summary>
        /// 플레이어가 분류한 도형 유형이 도형 타입과 동일한지 판단하는 함수
        /// <br/>분류가 일치하지 않는다면 플레이어 생명 - 1
        /// </summary>
        /// <param name="inShape">플레이어가 입력한 도형 타입</param>
        /// <param name="desBasket">제시된 도형의 타입</param>
        public void SortShape(Shape inShape, Shape desBasket)
        {
            if (desBasket == Shape.Etc && inShape != desBasket)
            {
                Life--;
            }
        }

        public void PrintPlayerLife()
        {
            for (int i = 0; i < Life; i++)
            {
                Console.Write("❤");
            }
        }
    }
}
