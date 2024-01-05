using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Dagger : Weapon
    {
        public Dagger(double baseDamage, double baseDurability, int value) : base("Dagger", baseDamage, baseDurability, value, 90) 
        {
            this.DamageModifier = 3.6;
            this.DurabilityModifier = 1.4;
        }
        public override void Enhance()
        {
            BaseDamage += DurabilityModifier;
        }
        public override void Use()
        {
            if (BaseDurability == 0)
                Console.WriteLine("You cannot use your dagger. It is destroyed");
            else
                Console.WriteLine("You have used your dagger to attack.");
        }
        public Weapon Merge(Weapon weapon)
        {
            if(weapon.BaseDamage > this.BaseDamage && weapon.BaseDurability > this.BaseDurability)
            {
                base.Destroy();
                if(weapon is Sword)
                {
                    Sword s = new Sword(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return s;
                }    
                if(weapon is Staff)
                {
                    Staff t = new Staff(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return t;
                }
                if(weapon is Bow)
                {
                    Bow b = new Bow(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return b;
                }
            }
            weapon.Destroy();
            Dagger d = new Dagger(this.BaseDamage, this.BaseDurability, this.Value);
            base.Destroy();
            return d;
        }
    }
}
