using System;

namespace P1_Persons
{
    class Person
    {
        // no getters or setters below, the constructors assign the values of fields
        private string Name;
        private int Age;
        private string Email;

        public Person(string name, int age)
            : this(name, age, "")
        {
            
        }

        public Person(string name, int age, string email)
        {
            if (name == null || name.Trim() == "" || (age <= 0 || age > 100))
            {
                throw new ArgumentException("Invalid name or age!");
            }
            else
            {
                this.Name = name;
                this.Age = age;
            }
            
            if (!email.Contains("@") || email.Trim() == "")
            {
                this.Email = null;
            }
            else
            {
                this.Email = email;
            }
        }

        public override string ToString()
        {
            return string.Format
                ("Name -> " + this.Name + " , Age -> " + this.Age + (this.Email != null ? " , E-mail -> " + this.Email : ""));
        }
    }
}