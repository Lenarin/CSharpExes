using System;
using System.Diagnostics;

namespace Ex4_SimpleFactory
{
    public class Pizza
    {
        public double Price { get; protected set; }
        public string Name { get; protected set; }
        public string Description { get; protected set; }

        public Pizza(double price, string name, string description)
        {
            Price = price;
            Name = name;
            Description = description;
        }

        public void Describe()
        {
            Console.WriteLine($"Пицца {Name} - {Description} по цене {Price}");
        }
    }
}