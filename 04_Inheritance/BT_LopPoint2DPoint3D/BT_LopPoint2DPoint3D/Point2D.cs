using System;
using System.Collections.Generic;
using System.Text;

namespace BT_LopPoint2DPoint3D
{
    class Point2D
    {
        private float x = 0;
        private float y = 0;
        private float[] xy;

        public Point2D() { }

        //public Point2D(float x, float y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        public Point2D(float x, float y, float[] xy)
        {
            this.X = x;
            this.Y = y;
            this.XY = xy;
        }

        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public float[] XY { get => xy; set => xy = value; }

        //public float[] getXY()
        //{
        //    float[] xy = { X, Y };
        //    return xy;
        //}

        //public void setXY(float x, float y)
        //{
        //    this.x = x;
        //    this.y = y;
        //}

        public virtual String toString()
        {
            String a = "Point 2D co toa do x: " + this.X + " toa do y: " + this.Y+ string.Join(",", this.XY);
            Console.WriteLine(a);
            return a;
        }


    }
}
