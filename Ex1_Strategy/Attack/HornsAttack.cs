using System;

namespace Ex1_Strategy.Attack
{
    public class HornsAttack: IAttackBehaviour
    {
        public void Attack()
        {
            Console.WriteLine("Attack with a horns");
        }
    }
}