using System;

namespace P1_Persons
{
    class Person
    {
        public string Name;
        public int Age;
        public string Email;

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
                this.Email = "empty";
            }
            else
            {
                this.Email = email;
            }
        }

        public override string ToString()
        {
            return string.Format
                ("Name -> {0} , Age -> {1} , E-mail -> {2}", this.Name, this.Age, this.Email);
        }
    }
}