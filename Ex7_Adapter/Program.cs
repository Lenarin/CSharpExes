using System;

namespace Ex7_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var programmer = new LazyProgrammer();
            var manager = new EffectiveManager();
            
            programmer.DoNothing();
            manager.DoEverything();
            
            var adapter = new ProgManagerAdapter(programmer);
            adapter.DoEverything();
            adapter.Walk();
        }
    }
}