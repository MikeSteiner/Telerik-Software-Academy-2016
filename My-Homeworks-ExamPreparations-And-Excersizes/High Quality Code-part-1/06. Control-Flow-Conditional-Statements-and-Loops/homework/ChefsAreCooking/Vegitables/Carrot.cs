using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefsAreCooking
{
    public class Carrot : IVegetable
    {
        private string name;
        private bool hasNotBeenPeeled;
        private bool isRotten;

        public Carrot(string name = "carrot")
        {
            this.Name = name;
            this.hasNotBeenPeeled = true;
            this.isRotten = false;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                this.name = value;
            }
        }

        public bool HasNotBeenPeeled
        {
            get
            {
                return this.hasNotBeenPeeled;
            }

            set
            {
                this.hasNotBeenPeeled = value;
            }
        }

        public bool IsRotten
        {
            get
            {
                return this.isRotten;
            }

            set
            {
                this.isRotten = value;
            }
        }
    }
}
