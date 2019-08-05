using System;
using System.Collections.Generic;
using System.Text;

namespace TH_HeCacDoiTuongHinhHoc
{
    public class Rectangle : Shape
    {
        private double width = 1.0;
        private double height = 1.0;

        public Rectangle()
        {
        }
        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public Rectangle(double width, double height, string color, bool filled) : base(color, filled)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get => width; set => width = value; }
        public double Height { get => height; set => height = value; }

        public double getArea()
        {
            return this.width * this.height;
        }

        public double getPerimeter()
        {
            return (this.width + this.height) * 2;
        }

        public override String toString()
        {
            String a = " A Rectangle with width " + Width + " height " + Height + ", which is a subclass of " + base.toString();
            Console.WriteLine(a);
            return a;
        }
    }
}

