using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal class EnergyBall : Consumable, Chargeable
    {
        private int energy;
        private int capacity;

        public EnergyBall(int capacity) : base ("energy ball", 0, 10, false)
        {
            this.capacity = capacity; 
            this.energy = 0;
        }
        public int ReleaseEnergy()
        {
            int en = this.energy; 
            this.energy = 0;
            return en;
        }
        public void Charge()
        {
            if (this.energy < this.capacity)
                this.energy++;
            else
                Console.WriteLine("This energy ball is fully charged!");
        }
        public override void Use()
        {
            Console.WriteLine("This energy ball is fully charged.");
        }
    }
}
