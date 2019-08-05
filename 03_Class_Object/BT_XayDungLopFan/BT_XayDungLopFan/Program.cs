using System;

namespace BT_XayDungLopFan
{
    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            Fan fan2 = new Fan();

            fan1.Speed = Fan.FAST1;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            fan2.Speed = Fan.MEDIUM1;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            fan1.toString();
            fan2.toString();
        }
    }
}
