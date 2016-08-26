namespace P02_Constructors
{
    using System;

    public class Battery
    {
        private string model;
        private ulong hoursIdle;
        private ulong hoursTalk;
        private string batteryType;

        public Battery() : this("None battery model set", 0, 0)
        {

        }

        public Battery(string batteryModel)
        {
            this.model = batteryModel;
            this.hoursIdle = 0UL;
            this.hoursTalk = 0UL;
        }

        public Battery(string batteryModel, ulong batteryHoursIdle)
        {
            this.model = batteryModel;
            this.hoursIdle = batteryHoursIdle;
            this.hoursTalk = 0UL;
        }

        public Battery(string batteryModel, ulong batteryHoursIdle, ulong batteryHoursTalk)
        {
            this.model = batteryModel;
            this.hoursIdle = batteryHoursIdle;
            this.hoursTalk = batteryHoursTalk;
        }        

    }
}
