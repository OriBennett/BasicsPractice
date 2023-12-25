using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class Battle
    {
        public static void StartFight(Warrior warrior1, Warrior warrior2)
        {
            // war1 attacks war2, war2 is damaged and health decreases
            //GetAttackResult
            // war2 attacks war1, war1 is damaged and health decreases
            //GetAttackResult
            bool notDead = true;
            while (notDead)
            {
                notDead = GetAttackResult(warrior1, warrior2) && GetAttackResult(warrior2,warrior1);
            }
            Console.WriteLine("Game Over");
        }

        public static bool GetAttackResult(Warrior warriorA, Warrior warriorB)
        {
            double warriorAAttackResult = warriorA.Attack();
            double warriorBBlockResult = warriorB.Block();
            double dmg2WarriorB = warriorAAttackResult - warriorBBlockResult;

            if (dmg2WarriorB > 0)
            {
                warriorB.Health -= dmg2WarriorB;
            }
            else dmg2WarriorB = 0;

            Console.WriteLine($"{warriorA.Name} attacks {warriorB.Name} and deals {dmg2WarriorB} damage.");
            Console.WriteLine($"{warriorB.Name} has {warriorB.Health} Health\n");

            if (warriorB.Health < 0)
            {
                Console.WriteLine($"{warriorB.Name} has died and {warriorA.Name} is victorious!.");
                    return false; //dead
            }
            else
            {
                return true;
            }
        }
    }
}
