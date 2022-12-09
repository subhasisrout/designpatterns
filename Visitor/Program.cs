// See https://aka.ms/new-console-template for more information
using Visitor;

Console.Title = "Visitor pattern";

var container = new Container();

container.Employees.Add(new Employee("Subhasis", 15));
container.Employees.Add(new Employee("Huzefa", 2));
container.Customers.Add(new Customer("A", 100));
container.Customers.Add(new Customer("B", 200));
container.Customers.Add(new Customer("C", 300));

//create the visitor
DiscountVisitor discountVisitor = new DiscountVisitor();

//run it through
container.Accept(discountVisitor);

//accumalate total discounts from all types of element
Console.WriteLine($"Total spendings on Discount - {discountVisitor.TotalDiscountGiven}");
