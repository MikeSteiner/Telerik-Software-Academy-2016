namespace P03_Enumeration
{
    using System;

    class Battery
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


        public enum BatteryType
        {
            LiIon,
            NiMH,
            NiCd, 
        }        

    }
}
