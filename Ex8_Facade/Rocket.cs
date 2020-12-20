using System;

namespace Ex8_Facade
{
    public class Rocket
    {
        private bool _fuel;
        private bool _inFly;

        public void FillFuel()
        {
            _fuel = true;
            Console.WriteLine("Заправили топливо");
        }

        public void Fly()
        {
            if (_fuel)
            {
                _inFly = true;
                Console.WriteLine("Взлетаем");
            }
            else
            {
                Console.WriteLine("Не можем взлететь без топлива");
            }
        }

        public void RemoveStage1()
        {
            if (_inFly)
            {
                Console.WriteLine("Отстегнули первую стадию");
            }
            else
            {
                Console.WriteLine("Не возможно отстегнуть первую стадию на земле");
            }
        }
    }
}