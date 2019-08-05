using System;

namespace BT_LopPointVaMoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(6.5f, 5f);
            point.toString();

            MoveablePoint moveablePoint = new MoveablePoint(2, 2, 6, 6);
            moveablePoint.toString();
            
            moveablePoint.toString();
            moveablePoint.Speed = new float[] { moveablePoint.X, moveablePoint.Y};
            Console.WriteLine(string.Join(",", moveablePoint.Speed));
            moveablePoint.move();
            moveablePoint.Speed = new float[] { moveablePoint.X, moveablePoint.Y};
            Console.WriteLine(string.Join(",", moveablePoint.Speed));
            moveablePoint.toString();
        }
    }
}
