namespace Ex6_Command.Commands
{
    public class SwitchCommand : ICommand
    {
        private ISwitchable _target;

        public SwitchCommand(ISwitchable target)
        {
            _target = target;
        }
        public void Execute()
        {
            _target.Switch();
        }
    }
}