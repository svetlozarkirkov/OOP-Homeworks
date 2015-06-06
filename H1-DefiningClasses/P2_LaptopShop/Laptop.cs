using System;

namespace P2_LaptopShop
{
    class Laptop
    {
        private string Model;
        private string Manufacturer;
        private string Processor;
        private uint Memory;
        private string GraphicsCard;
        private uint HardDisk;
        private string Screen;
        private decimal Price;
        private Battery Battery;

        public Laptop(string model, decimal price)
        {
            this.Model = model;
            this.Price = price;
        }

        public Laptop(string model, decimal price, string manufacturer, string processor, uint memory,
            string graphicsCard, uint hardDisk, string screen, string batteryType, double batteryLife)
        {
            this.Model = model;
            this.Price = price;
            this.Manufacturer = manufacturer;
            this.Processor = processor;
            this.Memory = memory;
            this.GraphicsCard = graphicsCard;
            this.HardDisk = hardDisk;
            this.Screen = screen;
            this.Battery = new Battery(batteryType, batteryLife);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
