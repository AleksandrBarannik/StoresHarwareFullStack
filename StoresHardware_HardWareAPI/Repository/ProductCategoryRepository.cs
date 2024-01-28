using StoresHardware_HardWareAPI.Data;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Repository.IRepository;

namespace StoresHardware_HardWareAPI.Repository
{
    public class ProductCategoryRepository : Repository<ProductCategory>, IProductCategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<ProductCategory> UpdateAsync(ProductCategory entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.ProductCategories.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
