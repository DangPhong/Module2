using System;

namespace LopCircleVaLopCylinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle("black", 5.5F);
            circle.toString();

            Cylinder cylinder = new Cylinder(6.5F, "white", 6.5F);
            cylinder.toString();

        }
    }
}
