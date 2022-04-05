using GeekShopping.web.Models;

namespace GeekShopping.web.Services.IServices
{
    public interface IProductService
    {
        Task<IEnumerable<ProductModel>> FindAllProducts();
        Task<ProductModel> FindProductById();
        Task<ProductModel> CreateProduct(ProductModel product);
        Task<ProductModel> UpdateProduct(ProductModel product);
        Task<bool> DeleteProductById(int id);
    }
}
