using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal abstract class Character
    {
        protected string Name { get; set; }
        protected double TotalLife { get; set; }
        protected int Level { get; set; }
        protected double AttackPower { get; set; }
        protected double DefensePower { get; set; }

        protected Character(string name)
        {
            Name = name;
        }
    }
}
