using System;

namespace P2_LaptopShop
{
    class Battery
    {
        private string BatteryType;
        private double BatteryLife;

        public Battery(string batteryType, double batteryLife)
        {
            if (batteryType == null || batteryType.Trim() == "" || batteryLife < 0)
            {
                throw new ArgumentException("Invalid battery data!");
            }
            else
            {
                this.BatteryType = batteryType;
                this.BatteryLife = batteryLife;
            }
        }
    }
}
