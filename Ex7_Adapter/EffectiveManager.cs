using System;

namespace Ex7_Adapter
{
    public class EffectiveManager : IManager
    {
        public void DoEverything()
        {
            Console.WriteLine("EffectiveManager: Эффективно делаю вещи");
        }

        public void Walk()
        {
            Console.WriteLine("EffectiveManager: Эффективно иду");
        }
    }
}