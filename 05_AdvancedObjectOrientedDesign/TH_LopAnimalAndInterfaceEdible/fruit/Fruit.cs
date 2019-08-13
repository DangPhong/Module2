using System;
using System.Collections.Generic;
using System.Text;
using TH_LopAnimalAndInterfaceEdible.edible;

namespace TH_LopAnimalAndInterfaceEdible.fruit
{
    public abstract class Fruit : IEdible
    {
        public abstract string howToEat();
    }
}
