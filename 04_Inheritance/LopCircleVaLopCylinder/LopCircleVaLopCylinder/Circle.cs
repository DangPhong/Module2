using System;
using System.Collections.Generic;
using System.Text;

namespace LopCircleVaLopCylinder
{
    class Circle
    {
        private string color;
        private float radius;

        public Circle()
        {
        }
        public Circle(string color, float radius)
        {
            this.color = color;
            this.radius = radius;
        }
        public string Color { get => color; set => color = value; }
        public float Radius { get => radius; set => radius = value; }

        public virtual string toString()
        {
            string a = "Hinh co mau la " + Color + ", ban kinh " + Radius;
            Console.WriteLine(a);
            return a;
        }
    }
}
