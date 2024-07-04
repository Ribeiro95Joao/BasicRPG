using BasicRPG.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal class Warrior : Character, ILevel
    {
        public Warrior(string name) : base(name)
        {
            this.Name = name;
            this.TotalLife = 10;
            this.AttackPower = 5;
            this.DefensePower = 5;
        }

        public void Leveling()
        {
            throw new NotImplementedException();
        }
    }
}
