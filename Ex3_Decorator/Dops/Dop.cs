using System;

namespace Ex3_Decorator
{
    public class Dop : Product
    {
        public Product Next { get; private set; }

        public Dop(string description, double price, Product next, Size size)
        {
            if (size == Size.Small)
            {
                Price = price * 0.5;
            } else if (size == Size.Medium)
            {
                Price = price;
            }
            else
            {
                Price = price * 1.5;
            }

            Description = description;
            Size = size;
            Next = next;
        }

        public override void Check()
        {
            base.Check();
            Next.Check();
        }
    }
}