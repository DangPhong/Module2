using System;
using System.Collections.Generic;
using System.Text;
using FishClass.IFace;
namespace FishClass.fish
{
    public class GuppyFish : Fish
    {
        public GuppyFish(string name, int weight, string color, bool isScales) : base(name, weight, color, isScales)
        {
            Console.WriteLine(".................. ");
            Console.WriteLine("Ten: {0} " ,Name);
            Console.WriteLine("Can nang: {0} ", Weight);
            Console.WriteLine("La ca: {0} ",IsScales?" co vay":" ko co vay");
            Console.WriteLine("Mau: {0}", Color);
        }

        public override void howToSwim()
        {
            base.howToSwim();
            Console.WriteLine("Boi tren loanh quanh tren mat nuoc!"); 
        }



    }
}
