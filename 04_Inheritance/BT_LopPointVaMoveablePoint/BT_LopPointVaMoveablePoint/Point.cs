using System;
using System.Collections.Generic;
using System.Text;

namespace BT_LopPointVaMoveablePoint
{
    class Point
    {
        private float x = 0f;
        private float y = 0f;
        private float[] xy; 

        public Point()
        {
        }
        public Point(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float[] XY { get => xy; set => xy = value; }

        public virtual string toString()
        {
            String a = "Point co toa do x=" + X + " va y= " + Y;
            Console.WriteLine(a);
            return a;
        }
    }
}
