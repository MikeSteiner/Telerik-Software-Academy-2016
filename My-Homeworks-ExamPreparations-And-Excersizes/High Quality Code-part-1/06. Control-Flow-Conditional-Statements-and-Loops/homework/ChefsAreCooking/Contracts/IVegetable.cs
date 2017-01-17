using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsAreCooking
{
    public interface IVegetable
    {
        string Name { get; } 

        bool HasNotBeenPeeled { get; set; }

        bool IsRotten { get; set; }
    }
}
