using System;
using System.Collections.Generic;
using System.Text;

namespace TH_XayDungLopHCN
{
    class Rectangle
    {
        private int widght, height;

        public int Widght { get => widght; set => widght = value; }
        public int Height { get => height; set => height = value; }

        public Rectangle()
        {
        }

        public Rectangle(int widght, int height)
        {
            this.widght = widght;
            this.height = height;
        }


        public double getArea()
        {
            return this.height * this.widght;
        }

        public double getPerimeter()
        {
            return (this.height + this.widght) * 2;
        }

        public void display()
        {
            Console.WriteLine("HCN co chieu dai " + widght + ", co chieu rong " + height);
        }
    }
}
