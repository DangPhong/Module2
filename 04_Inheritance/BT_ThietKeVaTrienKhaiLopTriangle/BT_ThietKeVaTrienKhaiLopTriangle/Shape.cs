using System;
using System.Collections.Generic;
using System.Text;

namespace BT_ThietKeVaTrienKhaiLopTriangle
{
    class Shape
    {
        private string color;

        public Shape()
        {
        }
        public Shape(string color)
        {
            this.Color = color;
        }

        public string Color { get => color; set => color = value; }

        public virtual string toString()
        {
            return "hinh co mau la: " + Color;
        }
    }
}
