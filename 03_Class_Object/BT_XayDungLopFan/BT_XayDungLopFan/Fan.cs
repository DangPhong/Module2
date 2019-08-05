using System;
using System.Collections.Generic;
using System.Text;

namespace BT_XayDungLopFan
{
    class Fan
    {
        private const int SLOW = 1;
        private const int MEDIUM = 2;
        private const int FAST = 3;
        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private String color = "blue";

        public static int SLOW1 => SLOW;

        public static int MEDIUM1 => MEDIUM;

        public static int FAST1 => FAST;

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public Fan()
        {
        }

        public String toString()
        {
            if (on)
            {
                String a = "toc do: " + this.speed + ", mau: " + this.color + ", ban kinh " + this.radius + ", Fan is on";
                Console.WriteLine(a);
                return a;
            }
            else
            {
                String b = " mau: " + this.color + ", ban kinh " + this.radius + ", Fan is off";
                Console.WriteLine(b);
                return b;
            }
        }
    }
}
