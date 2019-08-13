using System;
using System.Collections.Generic;
using System.Text;

namespace TH_LopAnimalAndInterfaceEdible.animal
{
    public class Tiger : Animal
    {
        public override string makeSound()
        {
            string a = "Tiger: roarrrrr!";
            Console.WriteLine(a);
            return a;
        }
    }
}
