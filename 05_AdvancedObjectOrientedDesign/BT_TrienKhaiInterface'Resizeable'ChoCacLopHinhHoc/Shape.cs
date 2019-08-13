using System;
using System.Collections.Generic;
using System.Text;

namespace BT_TrienKhaiInterface_Resizeable_ChoCacLopHinhHoc
{
    public class Shape
    {
        private String color;
        private bool filled;

        public Shape()
        {
            this.color = "green";
            this.filled = true;
        }

        public Shape(string color, bool filled)
        {
            this.color = color;
            this.filled = filled;
        }

        public string Color { get => color; set => color = value; }
        public bool Filled { get => filled; set => filled = value; }

        public virtual String toString()
        {
            String a = "A Shape with color of " + Color + " and " + (Filled ? "filled" : "not filled");
            Console.WriteLine(a);
            return a;
        }
    }
}
