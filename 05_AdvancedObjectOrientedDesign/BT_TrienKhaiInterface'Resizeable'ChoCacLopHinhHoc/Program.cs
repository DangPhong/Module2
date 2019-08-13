using System;

namespace BT_TrienKhaiInterface_Resizeable_ChoCacLopHinhHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.toString();

            Shape shape1 = new Shape("red", false);
            shape1.toString();

            Circle circle = new Circle();
            circle.toString();
            Circle circle1 = new Circle("brown", true, 5);
            circle.resize(100);
            circle1.toString();

            Rectangle rectangle = new Rectangle(5, 10, "red", false);
            rectangle.toString();
            rectangle.resize(100);
            rectangle.toString();

            Square square = new Square(5, "yellow", true);
            square.toString();
        }
    }
}
