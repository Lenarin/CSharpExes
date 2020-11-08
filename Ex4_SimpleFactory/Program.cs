using System;
using System.Collections.Generic;

namespace Ex4_SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstFactory = new PizzaFactory(new HashSet<PizzaType> {PizzaType.Greek, PizzaType.Hawaii, PizzaType.FourCheese}, "Фабрика один");
            var secondFactory = new PizzaFactory(new HashSet<PizzaType> {PizzaType.MeatAndCherry, PizzaType.Peperoni}, "Фабрика два");

            var pizza = firstFactory.MakePizza(PizzaType.Hawaii, new List<string>{"Штуки", "Дрюки"});
            pizza?.Describe();

            pizza = secondFactory.MakePizza(PizzaType.FourCheese, new List<string>());
            pizza?.Describe();
        }
    }
}