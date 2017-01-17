namespace P04_ToString
{
    using System;

    public class Battery
    {
        private string model;
        private ulong hoursIdle;
        private ulong hoursTalk;
        private BatteryType type;

        public Battery() : this("None battery model set")
        {

        }

        public Battery(string batteryModel)
        {
            this.model = batteryModel;            
        }

        public Battery(string batteryModel, ulong batteryHoursIdle) 
                        : this(batteryModel)
        {            
            this.hoursIdle = batteryHoursIdle;
        }

        public Battery(string batteryModel, ulong batteryHoursIdle, ulong batteryHoursTalk) 
                        : this(batteryModel, batteryHoursIdle)
        {            
            this.hoursTalk = batteryHoursTalk;
        }

        public Battery(string batteryModel, ulong batteryHoursIdle, ulong batteryHoursTalk, BatteryType batteryType) 
                        : this(batteryModel, batteryHoursIdle, batteryHoursTalk)
        {
            this.type = batteryType;
        }              

        public void PrintInfo()
        {
            Console.WriteLine("------ Battery information -------");
            Console.WriteLine("model: {0}", this.model);
            Console.WriteLine("type: {0}", this.type);
            Console.WriteLine("hoursIdle: {0}", this.hoursIdle);
            Console.WriteLine("hoursTalk: {0}", this.hoursTalk);
        }


        public override string ToString()
        {
            return "Battery: " + this.model + "; " + this.type + "; " + this.hoursIdle + "; " + this.hoursTalk;
        }
    }
}
