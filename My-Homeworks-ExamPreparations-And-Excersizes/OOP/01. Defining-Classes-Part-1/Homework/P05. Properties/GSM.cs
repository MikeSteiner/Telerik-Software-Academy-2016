namespace P05_Properties
{
    using System;

    public class GSM
    {
        private string model;
        private string manufacturer;
        private int price;
        private string owner;

        public GSM() : this("No gsm model set", "No gsm manufacturer set", 0, "No gsm owner set")
        {

        }

        public GSM(string gsmModel)
        {
            this.model = gsmModel;
        }

        public GSM(string gsmModel, string gsmManufacturer) : this(gsmModel)
        {
            this.manufacturer = gsmManufacturer;
        }

        public GSM(string gsmModel, string gsmManufacturer, int gsmPrice) : this(gsmModel, gsmManufacturer)
        {
            this.price = gsmPrice;
        }

        public GSM(string gsmModel, string gsmManufacturer, int gsmPrice, string gsmOwner) : this(gsmModel, gsmManufacturer, gsmPrice)
        {
            this.owner = gsmOwner;
        }

        // Properties
        public string Model
        {
            get
            {
                return this.model;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM model should not be empty string");
                }
                if (value.Length <= 1)
                {
                    throw new ArgumentException("GSM model should be longer than 1 symbols");
                }

                this.model = value;
            }
        }

        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("GSM manufacturer should not be empty string");
                }
                if (value.Length <= 1)
                {
                    throw new ArgumentException("GSM manufacturer should be longer than 1 symbols");
                }

                this.manufacturer = value;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("GSM price should not be negative");
                }

                this.price = value;
            }
        }

        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("GSM should have a valid owner");
                }

                this.owner = value;
            }
        }


        //Print information
        public void PrintInfo()
        {
            Console.WriteLine("------ GSM information -------");
            Console.WriteLine("model: {0}", this.model);
            Console.WriteLine("manufacturer: {0}", this.manufacturer);
            Console.WriteLine("price: {0}", this.price);
            Console.WriteLine("owner: {0}", this.owner);
        }

        public override string ToString()
        {           
            return "GSM: " + this.model + "; " + this.manufacturer + "; " + this.price + "; " + this.owner;
        }
    
    }
}
