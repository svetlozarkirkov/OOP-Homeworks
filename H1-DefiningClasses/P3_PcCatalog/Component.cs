using System;
using System.Collections.Generic;

namespace P3_PcCatalog
{
    class Component
    {
        private string name;
        private string details;
        private decimal price;

        //getters and setters for the fields below
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
            //constructor which takes Name and Price only and then calls the below constructor
        }

        // full constructor below which takes also the details, if they are empty they are not printed and no exception is raised
        public Component(string name, string details, decimal price)
        {
            if (name == null || name.Trim() == "" || price < 0)
            {
                throw new ArgumentException("Invalid data!");
            }
            else
            {
                this.name = name;
                this.price = price;
                this.details = details;
            }
        }

        public override string ToString()   // if the component has details they are printed, otherwise only the name and the price is printed
        {
            return string.Format("Name: " + this.name +
                (String.IsNullOrEmpty(this.details) ? "": " , Details: " + this.details) + " , Price: " + this.price);
        }
    }
}
