using System;
using Ex6_Command.Commands;
using Ex6_Command.Devices;

namespace Ex6_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            var tv = new TV();
            var light1 = new Light();
            var light2 = new Light();
            
            var remote = new Remote();
            
            remote.SetMapping(new SwitchCommand(tv), 0);
            remote.SetMapping(new SwitchCommand(light1), 1);
            remote.SetMapping(new SwitchCommand(light2), 2);
            
            remote.SetMapping(new ChangeCommand(tv, 1), 3);
            remote.SetMapping(new ChangeCommand(tv, 2), 4);
            remote.SetMapping(new ChangeCommand(tv, 3), 5);
            remote.SetMapping(new ChangeCommand(tv, 4), 6);
            
            remote.PressButton(0);
            remote.PressButton(1);
            remote.PressButton(2);
            remote.PressButton(4);
            remote.PressButton(5);
            remote.PressButton(0);
            remote.PressButton(3);
            remote.PressButton(0);
            remote.PressButton(3);
            remote.PressButton(2);
            remote.PressButton(0);
        }
    }
}