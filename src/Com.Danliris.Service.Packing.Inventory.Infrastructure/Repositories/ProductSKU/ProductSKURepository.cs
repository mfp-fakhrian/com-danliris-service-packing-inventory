using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Com.Danliris.Service.Packing.Inventory.Data.Models;

namespace Com.Danliris.Service.Packing.Inventory.Infrastructure.Repositories.ProductSKU
{
    public class ProductSKURepository : IProductSKURepository
    {
        public ProductSKURepository(PackingInventoryDbContext dbContext)
        {

        }

        public Task<int> DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> InsertAsync(ProductSKUModel model)
        {
            throw new System.NotImplementedException();
        }

        public IQueryable<ProductSKUModel> ReadAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<ProductSKUModel> ReadByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<int> UpdateAsync(int id, ProductSKUModel model)
        {
            throw new System.NotImplementedException();
        }
    }
}