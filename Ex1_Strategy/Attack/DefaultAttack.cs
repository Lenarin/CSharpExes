using System;

namespace Ex1_Strategy.Attack
{
    public class DefaultAttack: IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("No attack :c");
        }
    }
}