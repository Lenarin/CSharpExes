using System;

namespace Ex7_Adapter
{
    public class LazyProgrammer : IProgrammer
    {
        public void DoNothing()
        {
            Console.WriteLine("LazyProgrammer: Мне лень делать что либо");
        }

        public void Walk()
        {
            Console.WriteLine("LazyProgrammer: Мне лень идти");
        }
    }
}