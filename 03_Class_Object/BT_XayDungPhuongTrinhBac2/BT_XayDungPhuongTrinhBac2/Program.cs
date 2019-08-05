using System;

namespace BT_XayDungPhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap c: ");
            int c = int.Parse(Console.ReadLine());

            QuadraticEquation cbh = new QuadraticEquation(a, b, c);
            if (cbh.getDiscriminant() < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (cbh.getDiscriminant() == 0)
            {
                Console.WriteLine("pt co nghiem kep " + cbh.getRoot());
            }
            else if (cbh.getDiscriminant() > 0)
            {
                Console.WriteLine("Pt có 2 nghiem pb x1= {0} va x2={1}" , cbh.getRoot1() , cbh.getRoot2());
            }
        }
    }
}
