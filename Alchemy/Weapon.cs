using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal abstract class Weapon : Item, Mergeable
    {
        private double baseDamage;
        private double damageModifier;
        private double baseDurability;
        private double durabilityModifier;

        public Weapon(string name, double baseDamage, double baseDurability, int value, double weight) : base(name, value, weight) 
        {
            this.baseDamage = baseDamage;
            this.baseDurability = baseDurability;
            this.durabilityModifier = this.damageModifier = 0;
        }
        public virtual Weapon Merge(Weapon weapon)
        {
            return null;
        }
        public abstract void Enhance();
        public double BaseDamage
        {
            get { return baseDamage; }
            set { this.baseDamage = value;}
        }
        public double DamageModifier
        {
            get { return damageModifier; }
            set { this.damageModifier = value; }
        }
        public double BaseDurability
        {
            get { return baseDurability; }
            set { this.baseDurability = value; }
        }
        public double DurabilityModifier
        {
            get { return durabilityModifier; }
            set { this.durabilityModifier = value; }
        }
        public void Destroy()
        {
            this.baseDurability = 0;
        }
    }
}
