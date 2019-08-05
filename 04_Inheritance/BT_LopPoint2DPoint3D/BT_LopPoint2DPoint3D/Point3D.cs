using System;
using System.Collections.Generic;
using System.Text;

namespace BT_LopPoint2DPoint3D
{
    class Point3D : Point2D
    {
        private float z = 0;
        private float[] xyz;

        public Point3D() { }

        public Point3D(float x, float y, float[] xy, float z) : base(x, y, xy)
        {
            this.z = z;
        }


        public float Z { get => z; set => z = value; }
        public float[] Xyz { get => xyz; set => xyz = value; }

        public float[] getXYZ()
        {
            float[] xyz = { X, Y, Z };
            return xyz;
        }

        //public void setXYZ(float x, float y, float z): base(x,y)
        //{
        //    this.z = z;
        //}

        public override string toString()
        {
            string a = base.toString() + " va toa do Z: " + Z;
            Console.WriteLine(a);
            return a;
        }
    }



}
