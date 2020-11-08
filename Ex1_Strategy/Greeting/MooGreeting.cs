using System;

namespace Ex1_Strategy.Greeting
{
    public class MooGreeting: IGreetingBehaviour
    {
        public void Greeting()
        {
            Console.WriteLine("Moooo");
        }
    }
}