using System;

namespace Ex1_Strategy.Walk
{
    public class FastWalk: IWalkBehaviour
    {
        public void Walk()
        {
            Console.WriteLine("Fast walking");
        }
    }
}