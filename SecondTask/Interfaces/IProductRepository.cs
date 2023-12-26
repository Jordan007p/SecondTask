
using SecondTask.Models;

namespace SecondTask.Interfaces
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        ICollection<Product> GetAll();
        ICollection<Product> GetAllProductsOrderedByMostSold();
    }
}
