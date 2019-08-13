using System;
using System.Collections.Generic;
using System.Text;
//using TH_LopAnimalAndInterfaceEdible.edible;
namespace TH_LopAnimalAndInterfaceEdible.animal
{
    public class Chicken : Animal, edible.IEdible
    {
        public override string makeSound()
        {
            string a = "Chicken: cluck-cluck!";
            Console.WriteLine(a);
            return a;
        }

        public string howToEat()
        {
            string a = "could be fried";
            Console.WriteLine(a);
            return a;
        }
    }
}
