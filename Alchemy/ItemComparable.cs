using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal interface ItemComparable
    {
        int CompareByValue(Item item);
        
        int CompareByWeight(Item item);

    }
}
