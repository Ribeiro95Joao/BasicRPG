using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal class Battle
    {
        
        public Battle()
        {
        }

        public void BattlePVP(Character ch1, Character ch2)
        {
            ch2.TotalLife = 10;
        }
    }
}
