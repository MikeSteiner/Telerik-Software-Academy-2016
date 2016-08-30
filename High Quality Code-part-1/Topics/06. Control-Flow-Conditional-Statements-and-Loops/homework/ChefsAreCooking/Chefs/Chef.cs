using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsAreCooking
{
    public class Chef
    {
        public Chef()
        {
        }

        public void Cook(IVegetable vegitable)
        {
            Potato potato = this.GetPotato();
            Carrot carrot = this.GetCarrot();            

            this.Peel(potato);
            this.Peel(carrot);
            this.Cut(potato);
            this.Cut(carrot);

            Bowl bowl;
            bowl = this.GetBowl();            
            bowl.Add(carrot);
            bowl.Add(potato);
        }

        private Bowl GetBowl()
        {
            Bowl bowl = new Bowl();

            return bowl;
        }

        private Potato GetPotato()
        {
            Potato potato = new Potato();

            return potato;
        }

        private Carrot GetCarrot()
        {
            Carrot carrot = new Carrot();

            return carrot;
        }

        private void Cut(IVegetable vegitavle)
        {
            // TODO implement the cutting process
        }

        private void Peel(IVegetable vegitavle)
        {
            // TODO implement the peeling process
        }               
    }
}
