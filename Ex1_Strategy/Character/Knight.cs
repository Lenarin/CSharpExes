using Ex1_Strategy.Attack;

namespace Ex1_Strategy.Character
{
    public class Knight: Character
    {
        public Knight() : base(attackBehaviour: new SwordAttack())
        {
        }
    }
}