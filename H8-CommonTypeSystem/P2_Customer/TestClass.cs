using System;
using System.Collections.Generic;

namespace P2_Customer
{
    class TestClass
    {
        static void Main()
        {
            Payment bag = new Payment("Bag",20);
            Payment laptop = new Payment("Laptop", 1000);
            Customer billGates = new Customer("Bill","Atanasov","Gates","5004041221",
                "Silicon Valley","555121212","billgates@bullshit.com",Customer.TypeOfCustomer.Golden);
            billGates.AddPayment(bag);
            billGates.AddPayment(laptop);
            
          
            Customer billGatesTwo = new Customer("Bill", "Atanasov", "Gates", "444444",
                "Silicon Valley", "555121212", "billgates@bullshit.com", Customer.TypeOfCustomer.Golden);
            Customer billGateSameReference = billGates;
            Customer billGatesClone = billGates.Clone();

            var steveJobs = new Customer("Steve", "Pavlikenov", "Jobs", "5004041221", "Grave Street",
                "12123344","stevejobs@apple.com",Customer.TypeOfCustomer.Diamond);
            var tyrionLannister = new Customer("Tyrion","Tywinov","Lannister","8248428","Casterly Rock",
                "123456678","tyrion@brothel.org",Customer.TypeOfCustomer.Regular);
            var jimiHendrix = new Customer("Jimi","Immortal","Hendrix","47267264","Woodstock Street 22",
                "24242424","jimi@guitar.com",Customer.TypeOfCustomer.OneTime);

            var gibsonGuitar = new Payment("Gibson Guitar", 2000);
            var kinslayerCrossbow = new Payment("Kinslayer Crossbow", 500);
            var iphone = new Payment("Iphone 7",8899);

            steveJobs.AddPayment(iphone);
            tyrionLannister.AddPayment(kinslayerCrossbow);
            jimiHendrix.AddPayment(gibsonGuitar);
            
            var customerList = new List<Customer>
            {
                steveJobs,
                billGates,
                tyrionLannister,
                billGatesTwo,
                jimiHendrix
            };

            customerList.Sort();

            foreach (var customer in customerList)
            {
                Console.WriteLine(customer + "\n");
            }
        }
    }
}
