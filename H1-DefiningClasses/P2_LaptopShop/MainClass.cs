using System;

namespace P2_LaptopShop
{
    internal class MainClass
    {
        private static void Main()
        {
            Console.Write("Enter Model: ");
            string model = Console.ReadLine();
            Console.Write("Enter Price in Lv: ");
            decimal price = decimal.Parse(Console.ReadLine());
            var laptopOne = new Laptop(model,price);
            Console.WriteLine("Laptop constructor 1 -> {0}", laptopOne);
            Console.WriteLine("Optional stuff below...");
            Console.Write("Enter Manufacturer (optional): ");
            string manufacturer = Console.ReadLine();
            Console.Write("Enter Processor (optional): ");
            string processor = Console.ReadLine();
            Console.Write("Enter RAM quantity in gigabytes (optional): ");
            uint memory = uint.Parse(Console.ReadLine());
            Console.Write("Enter Graphics card (optional): ");
            string graphicsCard = Console.ReadLine();
            Console.Write("Enter HDD quantity in gigabytes (optional): ");
            uint hardDisk = uint.Parse(Console.ReadLine());
            Console.Write("Enter Screen (optional): ");
            string screen = Console.ReadLine();
            Console.Write("Enter Battery type (optional): ");
            string batteryType = Console.ReadLine();
            Console.Write("Enter Battery life in hours (optional): ");
            double batteryLife = double.Parse(Console.ReadLine());
            
            var laptopTwo = new Laptop(model,price,manufacturer,processor,memory,graphicsCard,hardDisk,screen,
                batteryType,batteryLife);
            Console.WriteLine("Laptop constructor 2 -> {0}",laptopTwo);
            
        }
    }
}
