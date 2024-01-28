using StoresHardware_HardWareAPI.Data;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Repository.IRepository;

namespace StoresHardware_HardWareAPI.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<Product> UpdateAsync(Product entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.Products.Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
