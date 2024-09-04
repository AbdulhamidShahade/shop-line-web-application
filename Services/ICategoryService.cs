using ShopLineWebApplication.Models;

namespace ShopLineWebApplication.Services
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetProductCategoriesAsync();
    }
}
