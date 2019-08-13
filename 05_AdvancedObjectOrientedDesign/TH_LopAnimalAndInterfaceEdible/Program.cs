using System;
using TH_LopAnimalAndInterfaceEdible.animal;
using TH_LopAnimalAndInterfaceEdible.edible;
using TH_LopAnimalAndInterfaceEdible.fruit;
namespace TH_LopAnimalAndInterfaceEdible
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[2];
            animals[0] = new Tiger();
            animals[1] = new Chicken();

            foreach (Animal i in animals)
            {
                i.makeSound();
            }

            Fruit[] fruits = new Fruit[2];
            fruits[0] = new Apple();
            fruits[1] = new Orange();

            foreach (Fruit i in fruits)
            {
                i.howToEat();
            }
        }
    }
}
