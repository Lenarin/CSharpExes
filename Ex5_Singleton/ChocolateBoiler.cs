using System;

namespace Ex5_Singleton
{
    public class ChocolateBoiler
    {
        private static bool IsBoiled { get; set; }
        private static bool IsEmpty { get; set; }

        private static volatile ChocolateBoiler _instance = null;
        private static object _lock = new object();
        
        public static ChocolateBoiler Instance()
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    Console.WriteLine("Создаем экземпляр");
                    _instance = new ChocolateBoiler();
                }
            }

            return _instance;
        }

        private ChocolateBoiler()
        {
            IsBoiled = false;
            IsEmpty = true;
        }

        public void Boil()
        {
            if (IsBoiled) Console.WriteLine("Уже закипел");
            if (IsEmpty) Console.WriteLine("Пусто");
            IsBoiled = true;
            Console.WriteLine("Закипает");
        }

        public void Fill()
        {
            if (!IsEmpty) Console.WriteLine("Уже полный");
            IsEmpty = false;
            Console.WriteLine("Наполняем");
        }

        public void Empty()
        {
            if (IsEmpty) Console.WriteLine("Уже пустой");
            IsEmpty = true;
            IsBoiled = true;
            Console.WriteLine("Опустошаем");
        }
    }
}