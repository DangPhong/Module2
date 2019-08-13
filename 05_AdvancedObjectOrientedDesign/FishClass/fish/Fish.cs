using System;
using System.Collections.Generic;
using System.Text;
using FishClass.IFace;
namespace FishClass.fish
{
    public abstract class Fish : ISwim
    {
        private string name;
        private float weight;
        private string color;
        // scales: vay ca
        private bool isScales;

        public Fish(string name, float weight, string color, bool isScales)
        {
            this.name = name;
            this.weight = weight;
            this.color = color;
            this.isScales = isScales;
        }

        public string Name { get => name; set => name = value; }
        public float Weight { get => weight; set => weight = value; }
        public string Color { get => color; set => color = value; }
        public bool IsScales { get => isScales; set => isScales = value; }

        public virtual void howToSwim()
        {
            Console.WriteLine("Ca nao cung biet boi! ");
        }
    }
}
