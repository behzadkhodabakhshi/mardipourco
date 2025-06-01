using Maripour.EndPoint.Entities.Product;

namespace EndPoint.Services.Interfaces
{
    public interface IProductService:IDisposable
    {
        Task<List<Product>> GetAllProduct();

        Task<Product> GetProductById(long id);
    }
}
