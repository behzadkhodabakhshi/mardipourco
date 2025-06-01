using EndPoint.Entities.Product;
using EndPoint.Repository;
using EndPoint.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EndPoint.Services.Impelementations
{
    public class ProductService : IProductService
    {
        private IGenericRepository<Product> productrepository;

        public ProductService(IGenericRepository<Product> productrepository)
        {
            this.productrepository = productrepository;
        }
        public async Task<List<Product>> GetAllProduct()
        {
            return await productrepository.GetEntitiesQuery().ToListAsync();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

    }
}
