using System;

namespace CarRentals
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store(2);
            store.inputVehicleForRentList();
            Console.WriteLine("Xuat tat ca nhung thong tin thue xe: ");
            store.outputVehicleForRentList();
            Console.WriteLine("Tong tien thue xe: " + store.totalMoney());
            Console.WriteLine("Thong tin ve xe dap cho thue: ");
            store.outputBicycle();
            Console.WriteLine("Thong tin ve xe may 250 phan khoi cho thue: ");
            store.outputMotor250();
        }
    }
}
