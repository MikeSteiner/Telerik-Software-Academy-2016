namespace P05_Properties
{
    using System;

    public class Battery : Display
    {
        //private string model;
        //private ulong hoursIdle;
        //private ulong hoursTalk;
        private BatteryType type;

        //Constructors
        public Battery()
        {
            this.HoursIdle = 0UL;
            this.HoursTalk = 0UL;
        }        

        public Battery(ulong batteryHoursIdle) : this()
        {            
            this.HoursIdle = batteryHoursIdle;
        }

        public Battery(ulong batteryHoursIdle, ulong batteryHoursTalk) : this(batteryHoursIdle)
        {            
            this.HoursTalk = batteryHoursTalk;
        }

        public Battery(ulong batteryHoursIdle, ulong batteryHoursTalk, BatteryType batteryType) : this(batteryHoursIdle, batteryHoursTalk)
        {
            this.type = batteryType;
        }   
                   
        // Properties       
        public ulong HoursIdle { get; set; }  
        
        public ulong HoursTalk { get; set; }

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }

        // Printing
        public void PrintBatteryInfo()
        {
            Console.WriteLine("------ Battery information -------");
            Console.WriteLine("type: {0}", this.type);
            Console.WriteLine("hoursIdle: {0}", this.HoursIdle);
            Console.WriteLine("hoursTalk: {0}", this.HoursTalk);
        }

        public override string ToString()
        {
            return "Battery: " + this.type + "; " + this.HoursIdle + "; " + this.HoursTalk;
        }
    }
}
