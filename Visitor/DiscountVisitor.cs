namespace Visitor
{
    internal class DiscountVisitor : IVisitor
    {
        public int TotalDiscountGiven { get; set; }
        public void VisitCustomer(Customer customer)
        {
            //discount logic for customer
            var discount = customer.AmountOrdered / 10;

            //modify the object itself (in this case - the customer)
            customer.Discount = discount;

            //accumulate all discounts in one place
            this.TotalDiscountGiven += discount;
        }

        public void VisitEmployee(Employee employee)
        {
            //discount logic for employee
            var discount = employee.YearsServed > 10 ? 500 : 100;

            //modify the object itself (in this case - the employee)
            employee.Discount = discount;

            //accumulate all discounts in one place
            this.TotalDiscountGiven += discount;
        }
    }
}
