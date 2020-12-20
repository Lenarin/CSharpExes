using System;

namespace Ex7_Adapter
{
    public class ProgManagerAdapter : IManager
    {
        private IProgrammer _programmer;
        
        public ProgManagerAdapter(IProgrammer programmer)
        {
            _programmer = programmer;
        }
        
        public void DoEverything()
        {
            Console.WriteLine("ProgManagerAdapter: Собираюсь с силами");
            _programmer.DoNothing();
        }

        public void Walk()
        {
            Console.WriteLine("ProgManagerAdapter: Собираюсь идти гулять");
            _programmer.DoNothing();
        }
    }
}