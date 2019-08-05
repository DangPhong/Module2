using System;

namespace TH_HeCacDoiTuongHinhHoc
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
            circle1.toString();

            Rectangle rectangle = new Rectangle(5, 10, "red", false);
            rectangle.toString();
            Square square = new Square(5, "yellow", true);
            square.toString();
        }
    }
}
