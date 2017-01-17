using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_GsmTest
{
    public class SmartPhone : Battery
    {
        public SmartPhone(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        private List<string> smartPhoneInfo;
        private void SmartPhoneInfo()
        {
            smartPhoneInfo = new List<string>();

            //extract GSM info
            smartPhoneInfo.Add(this.Manufacturer);
            smartPhoneInfo.Add(this.Model);
            smartPhoneInfo.Add(this.Price.ToString());
            smartPhoneInfo.Add(this.Owner);
            smartPhoneInfo.Add(this.Raiting.ToString());

            //extract Display info
            smartPhoneInfo.Add(this.DisplaySize.ToString());
            smartPhoneInfo.Add(this.NumberOfColors.ToString());

            //extract Battery info
            smartPhoneInfo.Add(this.HoursIdle.ToString());
            smartPhoneInfo.Add(this.HoursTalk.ToString());
            smartPhoneInfo.Add(this.BatteryType.ToString());
        }

        public string GetSmartPhoneInfo()
        {
            SmartPhoneInfo();

            return string.Join("; ", smartPhoneInfo);
        }
    }
}
