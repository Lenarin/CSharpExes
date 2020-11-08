using System;

namespace Ex3_Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Latte(Size.Big);
            product = new Chocolate(product, Size.Medium);
            product = new Cinnamon(product, Size.Small);
            product.Check();
            
            product = new Espresso(Size.Small);
            product.Check();
        }
    }
}