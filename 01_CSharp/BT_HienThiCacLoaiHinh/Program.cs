using System;

namespace BT_HienThiCacLoaiHinh
{
    class Program
    {
        public static void drawRect()
        {
            Console.WriteLine("Ve HCN: ");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public static void drawSquareTriangle()
        {
            int number = 1;
            while (number <= 5)
            {

                for (int i = 0; i < number; i++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
                number++;
            }
        }
    
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 0)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Ve HCN");
                Console.WriteLine("2. Ve tam giac");
                Console.WriteLine("3. Thoat");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        drawRect();
                        break;
                    case 2:
                        drawSquareTriangle();
                        break;
                    default:
                        Console.WriteLine("Chon lai");
                        break;
                }
            }
           
        }
    }
}
