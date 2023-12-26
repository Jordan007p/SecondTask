

using SecondTask.Models;

namespace SecondTask.Interfaces
{
    public interface ICategoryRepository
    {
        void AddCategory(Category category);
        ICollection<Category> GetAllCategories();
        ICollection<Category> GetAllCategoriesOrderedByMostSold();
    }
}
