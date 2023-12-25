using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightingGame
{
    class CanTeleport : ITeleports
    {
        public string teleport()
        {
            return "Teleports away";
        }

        // Could this and CantTeleport be an Enum? Probably. But this was to practice the basics of interfaces
    }
}
