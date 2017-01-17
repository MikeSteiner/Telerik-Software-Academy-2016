using System;

namespace WarMachines.Machines
{
    public abstract class Unit
    {
        protected Unit(string name)
        {
            if (name == string.Empty)
            {
                throw new ArgumentOutOfRangeException();
            }

            this.Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}