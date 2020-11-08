using System;
using System.Collections.Generic;

namespace Ex4_SimpleFactory
{
    public class PizzaDictVars
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
    
    public class PizzaFactory
    {
        private static Dictionary<PizzaType, PizzaDictVars> PizzasDict = new Dictionary<PizzaType, PizzaDictVars>
        {
            {PizzaType.Greek, new PizzaDictVars{Name = "Греческая", Price = 1100, Description = "Пицца по-гречески"}},
            {PizzaType.Hawaii, new PizzaDictVars{Name = "Гавайская", Price = 900, Description = "Пицца по-гавайски"}},
            {PizzaType.Peperoni, new PizzaDictVars{Name = "С Пепперони", Price = 1200, Description = "Пицца с колбасой пепперони"}},
            {PizzaType.FourCheese, new PizzaDictVars{Name = "Четыре сыра", Price = 800, Description = "Пицца с четырьма сырами"}},
            {PizzaType.MeatAndCherry, new PizzaDictVars{Name = "Мясо и вишня", Price = 1900, Description = "Пиццы с мясом с вишневым соусом"}}
        };
        public HashSet<PizzaType> AvaliableTypes { get; private set; }
        
        public string Name { get; private set; }

        public PizzaFactory(HashSet<PizzaType> avaliableTypes, string name)
        {
            AvaliableTypes = avaliableTypes;
            Name = name;
        }

        public Pizza MakePizza(PizzaType type, List<string> toppings)
        {
            if (AvaliableTypes.Contains(type))
            {
                Console.WriteLine($"Фабрика {Name}: делаю пиццу");
                var pizza = new Pizza(PizzasDict[type].Price, PizzasDict[type].Name, PizzasDict[type].Description +
                                                                                     (toppings.Count > 0 ? " c " + string.Join(", ", toppings) : ""));
                Console.WriteLine($"Фабрика {Name}: запекаю пиццу");
                return pizza;
            }
            else
            {
                Console.WriteLine($"Фабрика {Name}: недоступный тип пиццы");
                return null;
            }
        }
    }
}