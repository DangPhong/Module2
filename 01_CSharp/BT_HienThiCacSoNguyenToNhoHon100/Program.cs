using System;

namespace BT_HienThiCacSoNguyenToNhoHon100
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
            //    check == true;
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
                Console.Write(num + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Cac so nguyen to <100 ");
            for (int i = 0; i < 100; i++)
            {
                isPrime(i);
            }
        }
    }
}
