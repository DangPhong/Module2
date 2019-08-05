using System;
using System.Collections.Generic;
using System.Text;

namespace BT_LopPointVaMoveablePoint
{
    class MoveablePoint : Point
    {
        private float xSpeed;
        private float ySpeed;
        private float[] speed;

        public MoveablePoint()
        {
        }

        public MoveablePoint(float xSpeed, float ySpeed)
        {
            this.XSpeed = xSpeed;
            this.YSpeed = ySpeed;
        }

        public MoveablePoint(float xSpeed, float ySpeed, float x, float y) : base(x, y)
        {
            this.XSpeed = xSpeed;
            this.YSpeed = ySpeed;
        }

        public float XSpeed { get => xSpeed; set => xSpeed = value; }
        public float YSpeed { get => ySpeed; set => ySpeed = value; }
        public float[] Speed { get => speed; set => speed = value; }

        public MoveablePoint move()
        {
            X += XSpeed;
            Y += YSpeed;
            return this;
        }
        public override string toString()
        {
            string a = base.toString() + " speed(" + XSpeed + "," + YSpeed + ")";
            Console.WriteLine(a);
            return a;
        }
    }



}
