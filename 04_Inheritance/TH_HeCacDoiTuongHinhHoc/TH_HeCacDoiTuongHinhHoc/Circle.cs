using System;
using System.Collections.Generic;
using System.Text;

namespace TH_HeCacDoiTuongHinhHoc
{
    class Circle : Shape
    {
        private double radius;

        public Circle()
        {
            this.radius = 1.0;
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public Circle(String color, bool filled, double radius) : base(color, filled)
        {
            this.radius = radius;
        }

        public double Radius { get => radius; set => radius = value; }

        public double getArea()
        {
            return Math.PI * radius * radius;
        }

        public double getPerimeter()
        {
            return 2 * radius * Math.PI;
        }

        public override string ToString()
        {

            String a = "Circle with radius" + Radius + ", which is a subclass of " + base.ToString();
            Console.WriteLine(a);
            return a;
        }
    }
}
