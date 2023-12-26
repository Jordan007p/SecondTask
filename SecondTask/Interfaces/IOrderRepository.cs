

using SecondTask.Models;

namespace SecondTask.Interfaces
{
    internal interface IOrderRepository
    {
        void AddOrder(Order order);
        ICollection<Order> GetAll();
        ICollection<Order> GetAllOrdersOrderedByDate();
    }
}
