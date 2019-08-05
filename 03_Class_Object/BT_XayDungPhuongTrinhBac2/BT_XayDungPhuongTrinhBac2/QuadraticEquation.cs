using System;
using System.Collections.Generic;
using System.Text;

namespace BT_XayDungPhuongTrinhBac2
{
    class QuadraticEquation
    {
        protected int a, b, c;

        public QuadraticEquation(int a, int b, int c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }

        public int A { get => a; set => a = value; }
        public int B { get => b; set => b = value; }
        public int C { get => c; set => c = value; }

        public double getDiscriminant()
        {
            int delta = b * b - 4 * a * c;
            return delta;
        }

        public double getRoot()
        {
            double r = -b / (2 * a);
            return r;
        }
        public double getRoot1()
        {
            double r1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            return r1;
        }

        public double getRoot2()
        {
            double r2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2 * a;
            return r2;
        }
    }
}
