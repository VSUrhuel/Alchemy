using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal abstract class Item : ItemComparable
    {
        private static int numberOfItems = 0;
        private int id;
        private int value;
        private string name;
        private double weight;

        public Item(string name, int value, double weight)
        {
            this.id = numberOfItems;
            numberOfItems++;
            this.name = name;
            this.value = value;
            this.weight = weight;
        }
        public abstract void Use();
        public int Id
        {
            get { return id; }
            set { this.id = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Value
        {
            get { return this.value;}
            set { this.value = value; }
        }
        public double Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }
        public int CompareByValue(Item item)
        {
            return this.value - item.Value;
        }
        public int CompareByWeight(Item item)
        {
            if (this.weight > item.Weight)
                return 1;
            else if (this.weight < item.Weight)
                return -1;
            else if (this.weight == item.Weight)
                return 0;
            return 0;
        }
    }
}
