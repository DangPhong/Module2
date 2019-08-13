using System;
using FishClass.fish;
using FishClass.IFace;
namespace FishClass
{
    class Program
    {
        static void Main(string[] args)
        {
            GuppyFish guppyFish = new GuppyFish("Ca bay mau", 10,  "Colorful", true);
            guppyFish.howToSwim();

            Catfish catfish = new Catfish("Ca tre", 2000, "black", false);
            catfish.howToSwim();
            catfish.howToCreep();

            Flyingfish flyingfish = new Flyingfish("Ca chuon", 500, "white", true);
            flyingfish.howToSwim();
            flyingfish.howToFly();
        }
    }
}
