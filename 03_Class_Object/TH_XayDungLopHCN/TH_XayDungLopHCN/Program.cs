using System;

namespace TH_XayDungLopHCN
{
    class Program
    {
        static void Main(string[] args)
        {
            int widght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            Rectangle rectangle = new Rectangle(widght, height);
            rectangle.display();
            Console.WriteLine("Chu vi HCN: " + rectangle.getPerimeter());
            Console.WriteLine("Dien tich HCN: " + rectangle.getArea());
        }
    }
}
