
using SecondTask.Models;

namespace SecondTask.Interfaces
{
    internal interface IOrderDetailsRepository
    {
        void AddOrderDetails(OrderDetails orderDetails);
        ICollection<OrderDetails> GetAll();
    }
}
