using System;
using System.Collections.Generic;

namespace ShapeSort
{
    public class ShapeQueue
    {
        Random random = new Random();
        private Queue<Shape> _shapesQueue = new Queue<Shape>(30);

        public int Counts()
        {
            return _shapesQueue.Count;
        }

        public Shape CurrentShape()
        {
            return _shapesQueue.Peek();
        }

        public Queue<Shape> EqShapes()
        {
            for (int i = 0; i < 30; i++)
            {
                _shapesQueue.Enqueue((Shape)random.Next(0, 4));
            }
            return _shapesQueue;
        }

        public Shape DqShapes()
        {
            return _shapesQueue.Dequeue();
        }

        public void PrintQueue()
        {
            Console.WriteLine("————————————————————————————————————————————————————————————");
            foreach (var shape in _shapesQueue)
            {
                switch (shape)
                {
                    case Shape.Circle:
                        Console.Write("● ");
                        break;
                    case Shape.Square:
                        Console.Write("□ ");
                        break;
                    case Shape.Triangle:
                        Console.Write("▲ ");
                        break;
                    default:
                        Console.Write("⨳ ");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("————————————————————————————————————————————————————————————");
        }
    }
}