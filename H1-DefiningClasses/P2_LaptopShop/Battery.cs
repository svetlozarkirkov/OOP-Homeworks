using System;

namespace P2_LaptopShop
{
    class Battery
    {
        private string BatteryName;
        private double BatteryLife;

        public Battery(string batteryName, double batteryLife)
        {
            if (batteryName == null || batteryName.Trim() == "" || batteryLife < 0)
            {
                throw new ArgumentException("Invalid battery data!");
            }
            else
            {
                this.BatteryName = batteryName;
                this.BatteryLife = batteryLife;
            }
        }
    }
}
