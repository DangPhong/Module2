using System;
using System.Collections.Generic;
using System.Text;

namespace CarRentals
{
    public class Vehicle
    {
        private string name;
        private int hour;

        public Vehicle(string name, int hour)
        {
            this.name = name;
            this.hour = hour;
        }

        public string Name { get => name; set => name = value; }
        public int Hour { get => hour; set => hour = value; }

        public virtual int getRentals
        {
            get { return 0; }
        }

        public virtual void output() { }
        public virtual string id()
        {
            return "X";
        }
        
    }
}
