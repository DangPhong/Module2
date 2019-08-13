using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentals
{
    class Motorbike : Vehicle
    {
        private string type;
        private string licensePlate;

        public Motorbike(string name, int hour, string type, string licensePlate) : base(name, hour)
        {
            this.Type = type;
            this.LicensePlate = licensePlate;
        }

        public string Type { get => type; set => type = value; }
        public string LicensePlate { get => licensePlate; set => licensePlate = value; }

        public override string id()
        {
            if (Type == "100")
            {
                return "Xe may 100 phan khoi";
            }
            else
            {
                return "Xe may 250 phan khoi";
            }
        }

        public override int getRentals
        {
            get
            {
                int money;
                if (Type == "100")
                {
                    money = 15000;
                }
                else
                {
                    money = 20000;
                }
                if (Hour > 0)
                {
                    money = money + 10000 * (Hour - 1);
                }
                return money;
            }
        }
        public override void output()
        {
            Console.WriteLine("Xe may: "+Name + "\t" + Hour + "\t" + getRentals + "\t" + Type + "\t" + LicensePlate);
        }
    }
}
