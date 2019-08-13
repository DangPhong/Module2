using System;
using System.Collections.Generic;
using System.Text;

namespace BT_ThietKeVaTrienKhaiLopTriangle
{
    class Triangle : Shape
    {
        private int side1, side2, side3;

        public Triangle()
        {
        }

        public Triangle(int side1, int side2, int side3, string color) : base(color)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public int Side1 { get => side1; set => side1 = value; }
        public int Side2 { get => side2; set => side2 = value; }
        public int Side3 { get => side3; set => side3 = value; }

        public double getPerimeter()
        {
            double chuVi = Side1 + Side2 + Side3;
            return chuVi;
        }

        public double getArea()
        {
            double p = getPerimeter() / 2;
            double dienTich = Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
            dienTich = Math.Round(dienTich, 2);
            return dienTich;
        }

        public override string toString()
        {
            return base.toString() + " S= " + getArea() + " p= " + getPerimeter();
        }
    }
}
