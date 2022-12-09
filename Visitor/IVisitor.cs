namespace Visitor
{
    interface IVisitor
    {
        void VisitCustomer(Customer customer);
        void VisitEmployee(Employee employee);
    }
}
