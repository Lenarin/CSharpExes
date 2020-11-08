using System;

namespace Ex1_Strategy.Walk
{
    public class SlowWalk: IWalkBehaviour
    {
        public void Walk()
        {
            Console.WriteLine("Slow walking");
        }
    }
}