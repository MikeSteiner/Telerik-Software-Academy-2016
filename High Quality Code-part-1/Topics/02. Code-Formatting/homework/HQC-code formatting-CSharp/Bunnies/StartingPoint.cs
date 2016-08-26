namespace BunniesSpace
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Bunnies
    {
        public static void Main(string[] args)
        {
            List<Bunny> bunnies = new List<Bunny>();
            bunnies.Add(new Bunny("Leonid", 1, FurType.NotFluffy));
            bunnies.Add(new Bunny("Rasputin", 2, FurType.ALittleFluffy));
            bunnies.Add(new Bunny("Tiberii", 3, FurType.ALittleFluffy));
            bunnies.Add(new Bunny("Neron", 1, FurType.ALittleFluffy));
            bunnies.Add(new Bunny("Klavdii", 3, FurType.Fluffy));
            bunnies.Add(new Bunny("Klavdii", 3, FurType.Fluffy));
            bunnies.Add(new Bunny("Vespasian", 3, FurType.Fluffy));
            bunnies.Add(new Bunny("Domician", 4, FurType.FluffyToTheLimit));
            bunnies.Add(new Bunny("Tit", 2, FurType.FluffyToTheLimit));

            // Introduce all bunnies
            var consoleWriter = new ConsoleWriter();
            foreach (var bunny in bunnies)
            {
                bunny.Introduce(consoleWriter);
            }

            // Create bunnies text file
            var bunniesFilePath = @"..\..\bunnies.txt";
            var fileStream = File.Create(bunniesFilePath);
            fileStream.Close();

            // Save bunnies to a text file
            using (var streamWriter = new StreamWriter(bunniesFilePath))
            {
                foreach (var bunny in bunnies)
                {
                    streamWriter.WriteLine(bunny.ToString());
                }
            }
        }
    }
}
