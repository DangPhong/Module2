using System;
using System.Collections.Generic;
using System.Text;

namespace BT_TrienKhaiInterface_Resizeable_ChoCacLopHinhHoc
{
    public class Square : Rectangle
    {
        private double side;
        public Square(double side)
        {
            this.Width = side;
            this.Height = side;
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
            this.Width = side;
            this.Height = side;
        }

        public double Side { get => Width; set => side = value; }

        public override string toString()
        {
            String a = " A Square with side " + Side + ", which is a subclass of " + base.toString();
            Console.WriteLine(a);
            return a;
        }
    }
}
