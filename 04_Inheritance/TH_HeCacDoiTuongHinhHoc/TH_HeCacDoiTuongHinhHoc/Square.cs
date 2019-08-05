using System;
using System.Collections.Generic;
using System.Text;

namespace TH_HeCacDoiTuongHinhHoc
{
    public class Square : Rectangle
    {
        public Square(double side)
        {
            this.Width = side;
            this.Height = side;
        }

        public Square(double side, string color, bool filled) : base(side, side, color, filled)
        {
            //this.Width = side;
            //this.Height = side;
        }
        public override string toString()
        {
            String a = " A Square with side " + Width + ", which is a subclass of " + base.toString();
            Console.WriteLine(a);
            return a;
        }
    }
}
