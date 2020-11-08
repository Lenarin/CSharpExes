using System;

namespace Ex3_Decorator
{
    public class Product
    {
        public double Price { get; protected set; }
        public string Description { get; protected set; }
        public Size Size { get; protected set; }

        public Product(float price, string description, Size size)
        {
            if (size == Size.Small)
            {
                Price = price * 0.8;
            } else if (size == Size.Medium)
            {
                Price = price;
            }
            else
            {
                Price = price * 1.2;
            }
            Description = description;
            Size = size;
        }

        protected Product()
        {
        }

        public virtual void Check()
        {
            Console.WriteLine($"{Description} - {Price}р");
        }
    }
}