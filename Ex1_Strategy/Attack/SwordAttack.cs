using System;

namespace Ex1_Strategy.Attack
{
    public class SwordAttack: IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("Attack with a sword");
        }
    }
}