
namespace P04_ToString
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
