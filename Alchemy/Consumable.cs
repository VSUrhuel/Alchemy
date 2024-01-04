using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal abstract class Consumable : Item
    {
        private bool consumed;
        private bool spoiled;

        public Consumable(String name, int value, double weight, bool spoiled) : base(name, value, weight)
        {
            this.spoiled = spoiled;
            consumed = false;
        }
        public bool IsConsumed() { return consumed; }
        public bool IsSpoiled() {  return spoiled; }
        public void SetConsumed (bool consumed) { this.consumed = consumed;}
    }
}
