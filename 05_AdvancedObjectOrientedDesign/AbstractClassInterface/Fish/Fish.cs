using System;
using System.Collections.Generic;
using System.Text;
using AbstractClassInterface.Fish;
namespace AbstractClassInterface
{
    public abstract class Fish :ISwim
    {
        private string name;
        private int weight;
        // fish scales : vay ca
        private bool isScales;
        private string color;

        public Fish(string name, int weight, bool isScales, string color)
        {
            this.name = name;
            this.weight = weight;
            this.isScales = isScales;
            this.color = color;
        }

        public string Name { get => name; set => name = value; }
        public int Weight { get => weight; set => weight = value; }
        public bool IsScales { get => isScales; set => isScales = value; }
        public string Color { get => color; set => color = value; }

        public void howToSwim()
        {
            Console.WriteLine("Ca nao cung biet boi");
        }
    }
}
