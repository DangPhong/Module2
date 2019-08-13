using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentals
{
    public class Store
    {
        public int n;
        Vehicle[] motorForRent;

        public Store(int size)
        {
            n = size;
            motorForRent = new Vehicle[size];
        }

        public int menu()
        {
            int choice = 2;
            do
            {
                Console.WriteLine("Bang chon nhap: ");
                Console.WriteLine("1. Chon xe dap ");
                Console.WriteLine("2. Chon xe may");

            } while ((choice != 1) && (choice != 2));
            return choice;
        }

        public void inputVehicleForRentList()
        {
            int choice;
            for (int i = 0; i < n; i++)
            {
                choice = menu();
                if (choice == 1)
                {
                    Console.WriteLine("Ban cho nhap xe dap");
                    Console.WriteLine("Ho ten nguoi cho thue");
                    string name = Console.ReadLine();
                    Console.WriteLine("So gio cho thue");
                    int hour = int.Parse(Console.ReadLine());
                    motorForRent[i] = new Bicycle(name, hour);
                }
                else
                {
                    Console.WriteLine("Ban chon nhap xe may");
                    Console.WriteLine("Nguoi thue");
                    string name = Console.ReadLine();
                    Console.WriteLine("So gio cho thue");
                    int hour = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ban nhao vao loai xe (100 hoac 250) phan khoi: ");
                    string type = Console.ReadLine();
                    Console.WriteLine("Bien so: ");
                    string licensePlate = Console.ReadLine();
                    motorForRent[i] = new Motorbike(name, hour, type, licensePlate);
                }
            }
        }

        public void outputVehicleForRentList()
        {
            for (int i = 0; i < n; i++)
            {
                motorForRent[i].output();
            }
        }

        public long totalMoney()
        {
            long total = 0;
            for (int i = 0; i < n; i++)
            {
                total = total + motorForRent[i].getRentals;
            }
            Console.WriteLine(total);
            return total;
        }

        public void outputBicycle()
        {
            for (int i = 0; i < n; i++)
            {
                if (motorForRent[i].id() == "Bicycle")
                {
                    motorForRent[i].output();
                }
            }
        }

        public long outputMotor250()
        {
            long total = 0;
            for (int i = 0; i < n; i++)
            {

                if (motorForRent[i].id() == "100")
                {
                    total += motorForRent[i].getRentals;
                }
            }
            Console.WriteLine(total);
            return total;
        }
    }
}
