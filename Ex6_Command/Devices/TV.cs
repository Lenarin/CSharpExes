using System;
using System.Collections.Generic;
using Ex6_Command.Commands;

namespace Ex6_Command.Devices
{
    public class TV : Device, IChangeable
    {
        private List<string> _channels = new List<string> {"Россия 1", "Перец", "Россия 24", "Первый"};

        public void Change(int id)
        {
            if (!Powered)
            {
                Console.WriteLine($"{Guid}: Невозможно переключить канал, телевизор выключен");
                return;
            }
            if (_channels.Count > id)
            {
                Console.WriteLine($"{Guid}: Канал сменен на {_channels[id - 1]}");
            }
            else
            {
                Console.WriteLine($"{Guid}: Канал сменен на пустой канал");
            }
        }
    }
}