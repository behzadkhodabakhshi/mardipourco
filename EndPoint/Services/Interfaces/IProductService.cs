using EndPoint.Entities.Product;

namespace EndPoint.Services.Interfaces
{
    public interface IProductService:IDisposable
    {
        Task<List<Product>> GetAllProduct();
    }
}
