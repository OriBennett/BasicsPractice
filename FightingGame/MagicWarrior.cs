using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    internal class MagicWarrior : Warrior
    {
        int teleportChance = 0;
        public Teleports Teleports = new CanTeleport(); //so can be changed when teleportation is blocked

        public MagicWarrior(int teleportChance = 0, string name = "Warrior", double health=0, double attkMax = 0, double blockMax = 0) 
            : base(name, health, attkMax, blockMax)
        {
            this.teleportChance = teleportChance;
        }
        public override double Block()
        {
            Random rnd = new Random();
            int rndDodge = rnd.Next(1,100);
            if (rndDodge < this.teleportChance && Teleports.teleport() != "Fails at Teleporting")
            {
                Console.WriteLine($"{this.Name} {this.Teleports.teleport()}");
                return 10000; //higher than expected attack
            }
            return base.Block();
        }
    }
}
