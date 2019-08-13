using System;
using System.Collections.Generic;
using System.Text;

namespace TH_LopAnimalAndInterfaceEdible.fruit
{
    class Apple : Fruit
    {
        public override string howToEat()
        {
            string a = "Apple could be slided";
            Console.WriteLine(a);
            return a;
        }
    }
}
