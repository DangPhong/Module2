using System;
using System.Collections.Generic;
using System.Text;


namespace LopCircleVaLopCylinder
{
    class Cylinder : Circle
    {
        private float height;

        public Cylinder(float radius, string color, float height) : base(color, radius)
        {
            this.Height = height;
        }

        public float Height { get => height; set => height = value; }

        public float getVolume()
        {
            float v = (float)Math.PI * Radius * Radius * Height;
            return v;
        }

        public override string toString()
        {
            string a = base.toString() + " chieu cao: " + Height + " co the tich: " + getVolume();
            Console.WriteLine(a);
            return a;
        }
    }
}
