using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Bow : Weapon, Chargeable
    {
        public Bow(double baseDamage, double baseDurability, int value) : base ("Bow", baseDamage, baseDurability, value, 90)
        {
            DamageModifier = 3;
            DurabilityModifier = 3.6;
        }
        public override void Enhance()
        {
            BaseDamage = BaseDamage + DurabilityModifier;
        }
        public void Charge()
        {
            BaseDamage *= DurabilityModifier;
        }
        public override void Use()
        {
            if(this.BaseDurability == 0)
            {
                Console.WriteLine("You cannot use your bow. It is destroyed.");
                this.BaseDamage /= DamageModifier;
            }
            else if(this.BaseDamage % 3 == 0)
            {
                Console.WriteLine("You have used your charged-bow to attack.");
                this.BaseDamage /= DamageModifier;
            }
            else
            {
                Console.WriteLine("You have used your bow to attack.");
                this.BaseDamage /= DamageModifier;
            }
        }
        public Weapon Merge(Weapon weapon)
        {
            if(weapon.BaseDamage > this.BaseDamage && weapon.BaseDurability > this.BaseDurability)
            {
                base.Destroy();
                if(weapon is Sword)
                {
                    Sword s = new Sword(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                }

            }
        }
    }
}
