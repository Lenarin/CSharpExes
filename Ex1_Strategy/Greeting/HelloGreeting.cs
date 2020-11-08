using System;

namespace Ex1_Strategy.Greeting
{
    public class HelloGreeting: IGreetingBehaviour
    {
        public void Greeting()
        {
            Console.WriteLine("Hello there");
        }
    }
}