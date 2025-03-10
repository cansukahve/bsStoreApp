using Entities.Models;

namespace Services.Contract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GelAllCategoriesAsync(bool trackChanges);
        Task<Category> GetOneCategoryByIdAsync(int id, bool trackChanges);
    }

}
