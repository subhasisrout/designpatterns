namespace Visitor
{
    internal class Employee : IElement
    {
        public int YearsServed { get; set; }
        public int Discount { get; set; }

        public string Name { get; set; }

        public Employee(string name, int yearsServed)
        {
            this.Name = name;
            this.YearsServed = yearsServed;
        }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitEmployee(this);
            Console.WriteLine($"visited employee {Name} with years served {YearsServed} - Discount given - {Discount}");
        }
    }
}
