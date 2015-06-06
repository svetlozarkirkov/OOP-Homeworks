using System;
using System.Collections.Generic;

namespace P3_PcCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Details
        {
            get { return this.details; }
            set { this.details = value; }
        }

        public decimal Price
        {
            get { return this.price; }
            set { this.price = value; }
        }


        public Component(string name, decimal price) : this(name, null, price)
        {
            
        }

        public Component(string name, string details, decimal price)
        {
            if (name == null || name.Trim() == "" || price < 0)
            {
                throw new ArgumentException("Invalid data!");
            }
            else
            {
                this.Name = name;
                this.Price = price;
                this.Details = details;
            }
        }

        public override string ToString()
        {
            return string.Format("Component Name: " + this.Name + 
                (this.Details == null ? " , Component Details: " + this.Details : "") + " , Component Price: " + this.Price);
        }
    }
}
