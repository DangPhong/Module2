using System;

namespace BT_HienThi20SoNguyenToDauTien
{
    class Program
    {
        public static bool isPrime(int num)
        {
          
            if (num < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % 2 == 0)
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            int dem = 0;
            int i = 2;
            Console.WriteLine("20 so nguyen to dau tien la: ");
            while (dem <=20)
            {
                if (isPrime(i))
                {
                    Console.Write((i) +"  ");
                    dem++; 
                }
                i++;
            } 
            
        }
    }
}
