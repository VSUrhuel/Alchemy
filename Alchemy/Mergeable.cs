using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy
{
    internal interface Mergeable
    {
        Weapon Merge(Weapon weapon);
        void Destroy();
    }
}
