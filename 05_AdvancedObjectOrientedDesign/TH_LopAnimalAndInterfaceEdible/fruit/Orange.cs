using System;
using System.Collections.Generic;
using System.Text;

namespace TH_LopAnimalAndInterfaceEdible.fruit
{
    class Orange : Fruit
    {
        public override string howToEat()
        {
            string a = "Orange could be juiced";
            Console.WriteLine(a);
            return a;
        }
    }
}
