﻿namespace P07_GsmTest
{
    using System;

    public class GSM
    {
        public static bool hasIMEI = true;

        private static string iPhone4S = "IPhone4S".ToLower();
        public static int iPhone4sCount = 0;

        private string model;
        private string manufacturer;
        private int price;
        private string owner;
        private double raiting;        //raiting is from 0 to 10 points

        public GSM() : this("No gsm model set", "No gsm manufacturer set", 0, "No gsm owner set")
        {
        }

        public GSM(string gsmModel)
        {
            this.model = gsmModel;
            IncreaseIPhoneCounter(gsmModel);            
        }
        //Increase the static counter with a static mathod
        private static void IncreaseIPhoneCounter(string gsmModel)
        {
            if (gsmModel.ToLower().Equals(iPhone4S))
            {
                iPhone4sCount++;
            }
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
                IncreaseIPhoneCounter(value);
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

        public double Raiting
        {
            get
            {
                return this.raiting;
            }
            set
            {
                if (value < 0.0d && value > 10.0d)
                {
                    throw new ArgumentOutOfRangeException("GSM raiting should be between 0 and 10 pints");
                }

                this.raiting = value;
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
