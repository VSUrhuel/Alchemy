using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Sword : Weapon
    {
        public Sword(double baseDamage, double baseDurability, int value) : base ("Sword", baseDamage, baseDurability, value, 1) 
        {
            DurabilityModifier = 3;
        }   
        public override void Enhance()
        {
            BaseDamage += DurabilityModifier;
        }
        public override void Use()
        {
            if (BaseDurability == 0)
                Console.WriteLine("You cannot use your sword. It is destroyed");
            else
                Console.WriteLine("You have used your sword to attack.");
        }
        public override Weapon Merge(Weapon weapon)
        {
            if(weapon.BaseDurability > this.BaseDamage && weapon.BaseDurability > this.BaseDurability)
            {
                base.Destroy();
                if(weapon is Staff)
                {
                    Staff t = new Staff(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return t;
                }
                if(weapon is Dagger)
                {
                    Dagger d = new Dagger(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return d;
                }
                if(weapon is Bow)
                {
                    Bow b = new Bow(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return b;
                }
            }
            weapon.Destroy();
            Sword s = new Sword(this.BaseDamage, this.BaseDurability, this.Value);
            base.Destroy();
            return s;
        }

    }
}
