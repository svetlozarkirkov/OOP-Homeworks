using System;

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
            
            Console.WriteLine(billGates);
            
            Console.WriteLine("-------------");
            
            Customer billGatesSame = new Customer("Bill", "Atanasov", "Gates", "5004041221",
                "Silicon Valley", "555121212", "billgates@bullshit.com", Customer.TypeOfCustomer.Golden);
            Customer billGateSameReference = billGates;
            Customer billGatesCopy = (Customer) billGates.Clone();

            Console.WriteLine("Two customers are equal (billGates & billGatesSame) -> {0}" ,
                billGates == billGatesSame);
            Console.WriteLine("Two customers have same reference (billGates & billGatesSame) -> {0}",
                ReferenceEquals(billGates,billGatesSame));
            Console.WriteLine("Two customers are equal (billGates & billGateSameReference) -> {0}"
                , billGates == billGateSameReference);
            Console.WriteLine("Two customers have same reference " +
                              "(billGates & billGatesSameReference) -> {0}",
                ReferenceEquals(billGates, billGateSameReference));
            Console.WriteLine("Two customers are equal (billGates & billGatesCopy): {0}", 
                billGates == billGatesCopy);
            Console.WriteLine("Two customers have same reference (billGates & billGatesCopy) -> {0}",
                ReferenceEquals(billGates, billGatesCopy));
            Console.WriteLine(billGates.CompareTo(billGatesCopy));
        }
    }
}
