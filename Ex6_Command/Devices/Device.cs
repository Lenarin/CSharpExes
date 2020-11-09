using System;
using Ex6_Command.Commands;

namespace Ex6_Command.Devices
{
    public class Device : ISwitchable
    {
        protected bool Powered = false;
        public Guid Guid = new Guid();

        public virtual void Switch()
        {
            Powered = !Powered;
            if (Powered) Console.WriteLine($"{Guid.ToString()}: Включен");
            else Console.WriteLine($"{Guid.ToString()}: Выключен");
        }
    }
}