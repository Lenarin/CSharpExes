using System;
using System.Collections.Generic;
using System.Linq;
using Ex6_Command.Commands;

namespace Ex6_Command
{
    public class Remote
    {
        private List<ICommand> _commands = Enumerable.Repeat(new EmptyCommand() as ICommand, 10).ToList();

        public void SetMapping(ICommand command, int idx)
        {
            if (idx < 0 || idx > _commands.Count)
                throw new ArgumentException();

            _commands[idx] = command;
        }

        public void PressButton(int idx)
        {
            if (idx < 0 || idx > _commands.Count)
                throw new ArgumentException();
            
            _commands[idx].Execute();
        }
    }
}