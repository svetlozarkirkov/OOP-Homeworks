using System;
using System.Collections.Generic;
using System.Text;

namespace P2_Customer
{
    class Customer : ICloneable, IComparable<Customer>
    {
        public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set; }
        public string Id { get; private set; }
        public string PermanentAddress { get; private set; }
        public string MobilePhone { get; private set; }
        public string Email { get; private set; }
        public List<Payment> Payments { get; private set; }
        public TypeOfCustomer CustomerType { get; private set; }

        public string FullName
        {
            get { return string.Format("{0} {1} {2}", this.FirstName, this.MiddleName, this.LastName); }
        }

        public enum TypeOfCustomer { OneTime,Regular,Golden,Diamond }

        public Customer(string firstName, string middleName, string lastName, string id, 
            string permanentAddress, string mobilePhone, string email, TypeOfCustomer customerType)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.Id = id;
            this.PermanentAddress = permanentAddress;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Payments = new List<Payment>();
            this.CustomerType = customerType;
        }

        public void AddPayment(Payment payment)
        {
            this.Payments.Add(payment);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Customer) obj);
        }

        protected bool Equals(Customer customer)
        {
            return string.Equals(FirstName, customer.FirstName) && 
                string.Equals(MiddleName, customer.MiddleName) && 
                string.Equals(LastName, customer.LastName) && 
                string.Equals(Id, customer.Id) && 
                string.Equals(PermanentAddress, customer.PermanentAddress) && 
                string.Equals(MobilePhone, customer.MobilePhone) && 
                string.Equals(Email, customer.Email);
        }

        public static bool operator ==(Customer one, Customer two)
        {
            return Equals(one, two);
        }

        public static bool operator !=(Customer one, Customer two)
        {
            return !Equals(one, two);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (FirstName != null ? FirstName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (MiddleName != null ? MiddleName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (LastName != null ? LastName.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Id != null ? Id.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (PermanentAddress != null ? PermanentAddress.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (MobilePhone != null ? MobilePhone.GetHashCode() : 0);
                hashCode = (hashCode*397) ^ (Email != null ? Email.GetHashCode() : 0);
                return hashCode;
            }
        }

        public override string ToString()
        {
            StringBuilder payments = new StringBuilder();
            if (this.Payments.Count != 0)
            {
                foreach (var payment in this.Payments)
                {
                    payments.Append(payment + " ");
                }
            }
            else
            {
                payments.Append("Empty");
            }
            return string.Format("Full Name: {0}\nEGN: {1}\nPermanent Address: {2}\nMobile phone: {3}\n" +
                        "Email: {4}\nCustomer type: {5}\nPayments: {6}"
                        ,this.FullName,this.Id, this.PermanentAddress,
                        this.MobilePhone,this.Email,this.CustomerType, payments);
        }

        public Customer Clone()
        {
            return new Customer(this.FirstName,this.MiddleName,this.LastName,
                this.Id,this.PermanentAddress,this.MobilePhone,this.Email,this.CustomerType);
        }

        object ICloneable.Clone() { return Clone(); }

        public int CompareTo(Customer other)
        {
            if (this.FullName == other.FullName)
            {
                return this.Id.CompareTo(other.Id);
            }
            return this.FullName.CompareTo(other.FullName);
        }
    }
}
