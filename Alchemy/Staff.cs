using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Staff : Weapon, Chargeable
    {
        public Staff(double baseDamage, double baseDurability, int value) : base("Staff", baseDamage, baseDurability, value, 90)
        {
            DurabilityModifier = 3.6;
            DamageModifier = 3;
        }
        public override void Enhance()
        {
            BaseDamage += DurabilityModifier;
        }
        public void Charge()
        {
            BaseDamage *= DamageModifier;
        }
        public override void Use()
        {
            if (BaseDurability == 0)
            {
                Console.WriteLine("You cannot use your staff. It is destroyed");
                this.BaseDamage /= DamageModifier;
            }
            else if(BaseDamage % 3 == 0)
            {
                Console.WriteLine("You have used your charged-staff to attack.");
                BaseDamage /= DamageModifier;
            }
            else
            {
                Console.WriteLine("You have used your staff to attack");
                BaseDamage /= DamageModifier;
            }
        }
        public Weapon Merge(Weapon weapon)
        {
            if (weapon.BaseDurability > this.BaseDamage && weapon.BaseDurability > this.BaseDurability)
            {
                base.Destroy();
                if (weapon is Sword)
                {
                    Sword s = new Sword(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return s;
                }
                if (weapon is Dagger)
                {
                    Dagger d = new Dagger(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return d;
                }
                if (weapon is Bow)
                {
                    Bow b = new Bow(weapon.BaseDamage, weapon.BaseDurability, weapon.Value);
                    weapon.Destroy();
                    return b;
                }
            }
            weapon.Destroy();
            Staff  t= new Staff(this.BaseDamage, this.BaseDurability, this.Value);
            base.Destroy();
            return t;
        }
    }
}
