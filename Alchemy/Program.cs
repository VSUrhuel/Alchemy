using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Item i = new Potion("small HP", 100, 50);
            Console.WriteLine(i.Id);

            i = new Potion("small HP", 100, 50);
            Console.WriteLine(i.Value);

            i = new Potion("small HP", 100, 50);
            Console.WriteLine(i.Name); // "small HP"

            i = new Potion("small HP", 100, 50);
            Console.WriteLine(i.Weight); // 1.0

            i = new Potion("small HP", 100, 50);
            i.Value = 200;
            Console.WriteLine(i.Value);

            i = new Potion("small HP", 100, 50);
            i.Name = "small MP";
            Console.WriteLine(i.Name); // "small MP"

            i = new Potion("small HP", 100, 50);
            i.Weight = 5;
            Console.WriteLine(i.Weight); // 5.0

            i = new Potion("small HP", 100, 50);
            Item j = new EnergyBall(50);
            Console.WriteLine(i.CompareByValue(j)); // 50

            i = new Potion("small HP", 100, 50);
            j = new EnergyBall(50);
            Console.WriteLine(i.CompareByWeight(j)); // -1

            Weapon w = new Dagger(20, 5, 200);
            Console.WriteLine(w.BaseDamage); // 20.0

            w.Enhance();
            Console.WriteLine(w.BaseDamage); // 23.6

            w = new Dagger(20, 5, 200);
            Console.WriteLine(w.DamageModifier); // 3.6

            w = new Dagger(20, 5, 200);
            Console.WriteLine(w.BaseDurability); // 5.0

            w = new Dagger(20, 5, 200);
            Console.WriteLine(w.DurabilityModifier); // 1.4

            w = new Dagger(20, 5, 200);
            w.BaseDamage = 17;
            Console.WriteLine(w.BaseDamage); // 17.0

            w = new Dagger(20, 5, 200);
            w.DamageModifier = 1.1;
            Console.WriteLine(w.DamageModifier); // 1.1

            w = new Dagger(20, 5, 200);
            w.BaseDurability = 500;
            Console.WriteLine(w.BaseDurability); // 500.0

            w = new Dagger(20, 5, 200);
            w.DurabilityModifier = 99;
            Console.WriteLine(w.DurabilityModifier); // 99.0

            w = new Dagger(20, 5, 200);
            w.Destroy();
            w.Use(); // "You can't use your dagger. It is destroyed"

            Consumable c = new Potion("small HP", 100, 50);
            Console.WriteLine(c.IsConsumed()); // false

            

        }
    }
}
