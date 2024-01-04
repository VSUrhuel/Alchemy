using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class Potion : Consumable
    {
        private int points;

        public Potion(string name, int points, int value) : base (name,value,1.0, false)
        {
            this.points = points;
        }
        public override void Use()
        {
            Console.WriteLine("The " + base.Name + " potion was consumed.");
            base.SetConsumed(true);
        }
    }
}
