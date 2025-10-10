using System;
using System.Collections.Generic;

namespace ShapeSort
{
    public enum ShapeType
    {
        Circle,
        Triangle,
        Square,
        Cross
    }
    
    public class ShapeQueue
    {
        public static Dictionary<ShapeType, string> ShapeDictionary = new Dictionary<ShapeType, string>()
        {
            { ShapeType.Circle, "● " },
            { ShapeType.Square, "□ " },
            { ShapeType.Triangle , "▲ " },
            { ShapeType.Cross , "⨳ "}
        };
     
        
        Random random = new Random();
        private Queue<ShapeType> _shapesQueue = new Queue<ShapeType>(30);

        public int Counts()
        {
            return _shapesQueue.Count;
        }

        public ShapeType CurrentShape()
        {
            return _shapesQueue.Peek();
        }

        // 대기열 큐에 무작위로 도형을 채우는 함수
        public Queue<ShapeType> EqShapes()
        {
            for (int i = 0; i < 30; i++)
            {
                _shapesQueue.Enqueue((ShapeType)random.Next(0, 4));
            }
            return _shapesQueue;
        }

        // 플레이어에게 도형을 전달하기 위해 대기열에서 dequeue하는 함수
        public ShapeType DqShapes()
        {
            return _shapesQueue.Dequeue();
        }

        public void PrintQueue()
        {
            Console.WriteLine("————————————————————————————————————————————————————————————");
            foreach (var shape in _shapesQueue)
            {
                PrintShape(shape);
            }
            Console.WriteLine();
            Console.WriteLine("————————————————————————————————————————————————————————————");
        }

        // 매개변수로 들어온 도형의 문자를 딕셔너리에서 찾아 출력하는 함수
        public void PrintShape(ShapeType inShapeKey)
        {
            Console.Write(ShapeDictionary[inShapeKey]);
        }
    }
}
