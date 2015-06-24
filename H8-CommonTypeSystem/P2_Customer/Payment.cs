namespace P2_Customer
{
    class Payment
    {
        public string ProductName { get; set; }

        public decimal Price { get; set; }

        public Payment(string productName, decimal price)
        {
            this.ProductName = productName;
            this.Price = price;
        }

        public override string ToString()
        {
            return string.Format("[ Name: {0} , Price: {1:C} ]", this.ProductName, this.Price);
        }
    }
}
