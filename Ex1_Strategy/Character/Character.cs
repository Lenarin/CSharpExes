using Ex1_Strategy.Attack;
using Ex1_Strategy.Greeting;
using Ex1_Strategy.Walk;

namespace Ex1_Strategy.Character
{
    public class Character
    {
        public IAttackBehaviour AttackBehaviour { get; set; }
        public IGreetingBehaviour GreetingBehaviour { get; set; }
        public IWalkBehaviour WalkBehaviour { get; set; }

        public Character(IAttackBehaviour attackBehaviour = null, IGreetingBehaviour greetingBehaviour = null,
            IWalkBehaviour walkBehaviour = null)
        {
            AttackBehaviour = attackBehaviour ?? new DefaultAttack();
            GreetingBehaviour = greetingBehaviour ?? new DefaultGreeting();
            WalkBehaviour = walkBehaviour ?? new SlowWalk();
        }

        public void Attack()
        {
            AttackBehaviour.Attack();
        }

        public void Greet()
        {
            GreetingBehaviour.Greeting();
        }

        public void Walk()
        {
            WalkBehaviour.Walk();
        }
    }
}