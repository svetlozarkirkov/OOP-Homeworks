using System;
using System.Collections.Generic;

namespace P3_PcCatalog
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //creating computer objects below
            Computer msi = new Computer();
            Computer asus = new Computer();
            Computer apple = new Computer("Apple");

            //setting the empty computer objects names below
            msi.Name = "MSI";
            asus.Name = "ASUS";

            //below are components which have only their name set
            Component saitek = new Component("Saitek Gamepad");
            Component sony = new Component("Sony Headphones");

            //creating bunch of random component objects below, using the constructor which takes name and price
            Component intelProc = new Component("i5-3230", 450.20m);
            Component kingstonRam = new Component("Kingston 8GB DDR4", 102.48m);
            Component amdProc = new Component("AMD X4-380", 348.12m);
            Component nvidiaGFX = new Component("GTX 580", 458.54m);
            Component amdGFX = new Component("HD9760", 573.26m);
            Component corsairRam = new Component("Corsair 18GB DDR5", 345.78m);

            //two components with the optional details constructor
            Component asusMotherboard = new Component("Asus RT-12","Made in 2020",450.98m);
            Component buffaloCard = new Component("Buffalo HJ-24244", "Wi-Fi Card", 45.12m);

            //populating the MSI computer with components
            msi.AddComponent(intelProc);
            msi.AddComponent(nvidiaGFX);
            msi.AddComponent(corsairRam);
            msi.AddComponent(buffaloCard);

            //populating the ASUS computer with components
            asus.AddComponent(amdProc);
            asus.AddComponent(amdGFX);
            asus.AddComponent(kingstonRam);

            //populating the Apple computer with components
            apple.AddComponent(intelProc);
            apple.AddComponent(amdGFX);
            apple.AddComponent(corsairRam);
            apple.AddComponent(asusMotherboard);

            //adding the computers to a list below
            var computers = new List<Computer>
            {
                msi,
                asus,
                apple
            };

            //sorting and printing the computers in the above list using the method at the end of this class
            SortComputersByPriceAndPrint(computers);
        }

        static void SortComputersByPriceAndPrint(List<Computer> computers)
        {
            computers.Sort((x, y) => x.Price.CompareTo(y.Price));
            foreach (var comp in computers)
            {
                comp.PrintComputer();
            }
        }
    }
}
