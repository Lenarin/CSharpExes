using System;
using Ex1_Strategy.Character;
using Ex1_Strategy.Greeting;

namespace Ex1_Strategy
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var knight = new Knight();
            var king = new King();
            var cow = new Cow();

            knight.Attack();
            knight.Greet();
            knight.GreetingBehaviour = new HelloGreeting();
            knight.Greet();
            knight.Walk();

            cow.Walk();
            cow.Greet();
        }
    }
}