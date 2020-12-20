using System;

namespace Ex8_Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var rocket = new Rocket();
            
            rocket.Fly();
            rocket.RemoveStage1();
            
            var launher = new RockerLaunher(rocket);
            launher.Launch();
        }
    }
}