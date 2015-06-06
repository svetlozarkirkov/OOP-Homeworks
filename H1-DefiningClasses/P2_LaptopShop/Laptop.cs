using System;

namespace P2_LaptopShop
{
    class Laptop
    {
        private string Model;
        private string Manufacturer;
        private string Processor;
        private double Memory;
        private string GraphicsCard;
        private string HardDisk;
        private string Screen;
        private decimal Price;
        private Battery battery;

        public Laptop(string model, decimal price)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
