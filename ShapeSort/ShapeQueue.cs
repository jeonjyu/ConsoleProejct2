using System;
using System.Collections.Generic;

namespace ShapeSort
{
    public class ShapeQueue
    {
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
            Random random = new Random();
            for (int i = 0; i < _shapesQueue.Count; i++)
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
            foreach (var shape in _shapesQueue)
            {
                switch (shape)
                {
                    case Shape.Circle:
                        Console.Write("● ");
                        break;
                    case Shape.Square:
                        Console.Write("■ ");
                        break;
                    case Shape.Triangle:
                        Console.Write("▲ ");
                        break;
                    default:
                        Console.Write("▩ ");
                        break;
                }
            }
        }
    }
}