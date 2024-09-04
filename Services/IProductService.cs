using ShopLineWebApplication.Models;

namespace ShopLineWebApplication.Services
{
    public interface IProductService
    {
        Task<ApiResponse> GetProductsAsync(string point);
    }
}
