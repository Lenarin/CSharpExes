using System;

namespace Ex5_Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var boider = ChocolateBoiler.Instance();
            
            boider.Fill();
            boider.Boil();
            
            boider = ChocolateBoiler.Instance();
            
            boider.Empty();
        }
    }
}