using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentals
{
    public class Bicycle : Vehicle
    {
        public Bicycle(string name, int hour):base(name , hour)
        {
          
        }

        public override string id()
        {
            return "Bicycle";
        }

        public override int getRentals
        {
            get
            {
                int money = 10000;
                if (Hour > 0)
                {
                    money = money + 8000 * (Hour - 1);
                }
                return money;
            }
        }
        public override void output()
        {
            Console.WriteLine(Name + "\t" + Hour + "\t" + getRentals + "\t");
        }
    }


}
