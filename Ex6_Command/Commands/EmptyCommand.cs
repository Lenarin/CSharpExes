using System;

namespace Ex6_Command.Commands
{
    public class EmptyCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Пустая комманда");
        }
    }
}