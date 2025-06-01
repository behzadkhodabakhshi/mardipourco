
using EndPoint.Repository;
using EndPoint.Services.Interfaces;
using Maripour.EndPoint.Entities.Product;
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

        public async Task<Product> GetProductById(long id)
        {
            return await productrepository.GetEntityById(id);
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
       
}
