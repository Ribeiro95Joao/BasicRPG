using BasicRPG.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal class Barbarian : Character, ILevel
    {
        public Barbarian(string name) : base(name)
        {
            this.Name = name;
            this.TotalLife = 10;
            this.Level = 1;
            this.AttackPower = 4;
            this.DefensePower = 6;
        }

        public void Leveling()
        {
            throw new NotImplementedException();
        }
    }
}
