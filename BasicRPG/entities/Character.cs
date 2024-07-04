using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal abstract class Character
    {
        private string name;
        public string Name 
        { 
            get {return name; }
            set {name = value; }
        }
        private double totalLife;
        public double TotalLife
        {
            get {return totalLife; }
            set {totalLife = value; }
        }
        protected int Level { get; set; }
     
        protected double AttackPower 
        {
            get { return AttackPower; }
            set { AttackPower = value; }
        }
        protected double DefensePower
        {
            get { return DefensePower; }
            set { DefensePower = value; }
        }

        protected Character(string name)
        {
            Name = name;
            Level = 1;
        }
    }
}
