using System;

namespace Ex9_TemplateMethod
{
    abstract class PizzaMaker
    {
        public void PreparePizza()
        {
            MakeDough();
            AddIngredients();
            Bake();
            if (CustomerWantSlices)
            {
                Slice();
            }
        }

        public abstract void AddIngredients();

        public abstract void Slice();

        public virtual void MakeDough()
        {
            Console.WriteLine("Boiling water");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Pouring in cup");
        }

        public virtual bool CustomerWantSlices
        {
            get
            {
                Console.WriteLine("Slice it?");
                var ans = Console.ReadLine();

                return ans.ToLower().StartsWith("y");
            }
        }
    }

    class AmericanPizza: PizzaMaker
    {
        public override void AddIngredients()
        {
            Console.WriteLine("Adding cheese and meat");
        }

        public override void Slice()
        {
            Console.WriteLine("Slice it as triangles");
        }

        public override bool CustomerWantSlices => true;
    }

    class HomePizza : PizzaMaker
    {
        public override void AddIngredients()
        {
            Console.WriteLine("Add everything from the fride");
        }

        public override void Slice()
        {
            Console.WriteLine("Cut it in squares");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var american = new AmericanPizza();
            american.PreparePizza();
            
            var home = new HomePizza();
            home.PreparePizza();
        }
    }
}