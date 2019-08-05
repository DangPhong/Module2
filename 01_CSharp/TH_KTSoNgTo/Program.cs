using System;

namespace TH_KTSoNgTo
{
    class Program
    {
        public static void isPrime(int num)
        {
            bool check = true;
            if (num < 2)
            {
                check = false;
            }
            //if (num == 2)
            //{
            //    check = true;
            //}
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % 2 == 0)
                {
                    check = false;
                    break;
                }
            }
            if (check)
            {
                Console.WriteLine(num + " la so nguyen to.");
            }
            else
            {
                Console.WriteLine(num + " ko phai la so nguyen to");
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Nhap so can kiem tra: ");
            int n = int.Parse(Console.ReadLine());
            isPrime(n);
        }
    }
}
