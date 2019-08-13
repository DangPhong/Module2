using System;

namespace BT_ThietKeVaTrienKhaiLopTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape("yellow");
            Console.WriteLine(shape.toString());
            Triangle triangle = new Triangle(5, 8, 12, "red");
            Console.WriteLine(triangle.toString());
        }
    }
}
