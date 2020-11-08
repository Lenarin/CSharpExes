using System;

namespace Ex1_Strategy.Greeting
{
    public class DefaultGreeting: IGreetingBehaviour
    {
        public void Greeting()
        {
            Console.WriteLine("Howdy");
        }
    }
}