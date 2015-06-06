using System;
using System.Collections.Generic;
using System.Text;

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

        public Computer()   //empty constructor
        {
            
        }

        public Computer(string name)    //constructor which takes only Name
        {
            if (name == null || name.Trim() == "")
            {
                throw new ArgumentException("Name must not be empty");
            }
            this.name = name;
        }

        public void AddComponent(Component component)   //adds the component to the computer and updates its price
        {
            this.components.Add(component);
            this.price += component.Price;
        }

        //private decimal CalcPrice(IList<Component> components)
        //{
        //    decimal totalPrice = 0m;
        //    foreach (var c in components)
        //    {
        //        totalPrice += c.Price;
        //    }
        //    return totalPrice;
        //}

        private void PrintComponents()  //prints all the components by calling the toString() override
        {
            foreach (var component in this.components)
            {
                Console.WriteLine(component);
            }
        }

        public void PrintComputer() //method which prints the computer data
        {
            Console.WriteLine(new string('=', 50) + "\n\nComputer name: " + this.name + "\n\n" +
                              "Components:\n-----------");
            PrintComponents();
            Console.WriteLine("\n" + 
                "Total Price: " + this.price + " lv\n\n" + new string('=', 50));
        }
    }
}
