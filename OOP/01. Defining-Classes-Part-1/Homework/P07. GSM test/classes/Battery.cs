namespace P07_GsmTest
{
    using System;

    public class Battery : Display
    {
        private ulong hoursIdle;
        private ulong hoursTalk;
        private BattType batteryType;

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

        public Battery(ulong batteryHoursIdle, ulong batteryHoursTalk, BattType batteryType) : this(batteryHoursIdle, batteryHoursTalk)
        {
            this.batteryType = batteryType;
        }

        // Properties   
        public ulong HoursIdle
        {
            get { return this.hoursIdle; }
            set { this.hoursIdle = value;  }
        }  
        
        public ulong HoursTalk
        {
            get { return this.hoursTalk; }
            set { this.hoursTalk = value; }
        }

        public BattType BatteryType
        {
            get
            {
                return this.batteryType;
            }
            set
            {
                this.batteryType = value;
            }
        }

        // Printing
        public void PrintBatteryInfo()
        {
            Console.WriteLine("------ Battery information -------");
            Console.WriteLine("battery type: {0}", this.BatteryType);
            Console.WriteLine("hoursIdle: {0}", this.HoursIdle);
            Console.WriteLine("hoursTalk: {0}", this.HoursTalk);
        }

        public override string ToString()
        {
            return "Battery type: " + this.BatteryType + "; " + this.HoursIdle + "; " + this.HoursTalk;
        }
    }
}
