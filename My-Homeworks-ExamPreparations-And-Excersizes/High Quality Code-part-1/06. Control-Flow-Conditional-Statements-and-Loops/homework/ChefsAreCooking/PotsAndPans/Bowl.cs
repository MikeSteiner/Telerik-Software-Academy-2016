using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsAreCooking
{
    public class Bowl
    {
        private List<IVegetable> bowl;

        public Bowl()
        {
            this.bowl = new List<IVegetable>();
        }

        /// <summary>
        /// Add vegitable to the bowl
        /// </summary>
        /// <param name="vegitable"></param>
        public void Add(IVegetable vegitable)
        {
            this.bowl.Add(vegitable);
        }       
    }
}
