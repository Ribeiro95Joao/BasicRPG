using BasicRPG.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal class Archer : Character, ILevel
    {
        public Archer(string name) : base(name)
        {
            this.Name = name;
            this.TotalLife = 10;
            this.AttackPower = 6;
            this.DefensePower = 4;
        }

        public void Leveling()
        {
            throw new NotImplementedException();
        }
    }
}
