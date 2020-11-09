namespace Ex6_Command.Commands
{
    public class ChangeCommand : ICommand
    {
        private IChangeable _target;
        private int _id;

        public ChangeCommand(IChangeable target, int id)
        {
            _target = target;
            _id = id;
        }
        
        public void Execute()
        {
            _target.Change(_id);
        }
    }
}