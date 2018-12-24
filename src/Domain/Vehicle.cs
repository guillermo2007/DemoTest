using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public abstract class Vehicle 
    {
        public Vehicle()
        {

        }

        public Vehicle(string name, int wheels, decimal weight, Color color)
        {
            Name = name;
            Wheels = wheels;
            Weight = weight;
            Color = color;
        }

        public Guid Id { get; set; }

        public string Name { get; set; }
        public int Wheels { get; protected set; }
        public decimal Weight { get; set; }
        public Color Color { get; set; }
    }
}
