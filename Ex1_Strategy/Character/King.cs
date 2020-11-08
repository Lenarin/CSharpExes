using Ex1_Strategy.Attack;
using Ex1_Strategy.Greeting;
using Ex1_Strategy.Walk;

namespace Ex1_Strategy.Character
{
    public class King: Character
    {
        public King() : base(attackBehaviour: new SwordAttack(), greetingBehaviour: new HelloGreeting(),
            walkBehaviour: new FastWalk())
        {
        }
    }
}