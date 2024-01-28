using StoresHardware_HardWareAPI.Models;

namespace StoresHardware_HardWareAPI.Repository.IRepository
{
    public interface IShopRepository:IRepository<Shop>
    {
        Task<Shop> UpdateAsync(Shop entity);
    }
}
