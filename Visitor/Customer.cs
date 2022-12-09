namespace Visitor
{
    internal class Customer : IElement
    {
        public int AmountOrdered { get; set; }
        public int Discount { get; set; }

        public string Name { get; set; }

        public Customer(string name, int amountOrdered)
        {
            this.Name = name;
            this.AmountOrdered = amountOrdered;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCustomer(this);
            Console.WriteLine($"visited customer {Name} with amount order {AmountOrdered} - Discount given - {Discount}");
        }
    }
}
