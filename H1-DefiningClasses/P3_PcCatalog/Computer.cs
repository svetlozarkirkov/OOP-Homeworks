using System;
using System.Collections.Generic;

namespace P3_PcCatalog
{
    class Computer
    {
        private string name;
        private IList<Component> components = new List<Component>();
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public IList<Component> Components
        {
            get { return this.components; }
        }

        public decimal Price
        {
            get { return this.price; }
        }

        public void AddComponent(Component component)
        {
            this.components.Add(component);
        }

        public decimal CalcPrice(IList<Component> components)
        {
            decimal totalPrice = 0m;
            foreach (var c in components)
            {
                totalPrice += c.Price;
            }
            return totalPrice;
        }

        public string PrintComponents()
        {
            
        }

        public void PrintData()
        {
            Console.WriteLine("Computer name: " + this.name + "\n" + 
                "Components: " + this.components + "\n" + 
                "Total Price: " + CalcPrice(this.components));
        }
    }
}
