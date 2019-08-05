using System;

namespace TH_KTNamNhuan
{
    class Program
    {
        public static void isLeap(int year)
        {
            if (year < 0)
            {
                Console.WriteLine(year + " la nam TCN!");
            }
            else if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine(year+ " la nam nhuan");
            }
            else Console.WriteLine(year + " ko phai la nam nhuan");
        }
        static void Main(string[] args)
        {
            Console.Write("Nhap nam muon kiem tra: ");
            int year = int.Parse(Console.ReadLine());
            isLeap(year);
        }
    }
}
