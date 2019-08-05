using System;

namespace BT_LopPoint2DPoint3D
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] arr = { 4, 5 };
            Point2D point2D = new Point2D(5, 8, arr);
            point2D.toString();

            Point3D point3D = new Point3D(8, 6, arr, 9);
            point3D.toString();
        }
    }
}
