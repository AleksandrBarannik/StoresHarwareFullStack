using StoresHardware_HardWareAPI.Data;
using StoresHardware_HardWareAPI.Models;
using StoresHardware_HardWareAPI.Repository.IRepository;

namespace StoresHardware_HardWareAPI.Repository
{
    public class ShopRepository: Repository<Shop>,IShopRepository
    {
        private readonly ApplicationDbContext _db;

        public ShopRepository(ApplicationDbContext db): base(db) 
        {
            _db = db;
        }

        public async Task<Shop> UpdateAsync(Shop entity)
        {
            entity.UpdateDate = DateTime.Now;
            _db.Shops.Update(entity);           
            await _db.SaveChangesAsync();
            return entity;

        }
    }
}
