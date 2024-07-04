using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicRPG.entities
{
    internal abstract class Character
    {
        public string Name { get; set; }
        protected double TotalLife { get; set; }
        protected int Level { get; set; }
        private double attackPower;
        public double AttackPower 
        {
            get { return attackPower; }
            protected set { attackPower = value; }
        }
        private double defensePower;
        public double DefensePower 
        {
            get { return defensePower; }
            protected set { defensePower = value; }
        }
        private double actualLife;
        public double ActualLife 
        {
            get { return actualLife; }
            set { actualLife = value; }
        }

        protected Character(string name)
        {
            Name = name;
            Level = 1;
            this.actualLife = this.TotalLife;
        }
    }
}
