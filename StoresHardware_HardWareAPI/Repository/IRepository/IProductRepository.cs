using StoresHardware_HardWareAPI.Models;

namespace StoresHardware_HardWareAPI.Repository.IRepository
{
    public interface IProductRepository:IRepository<Product>
    {
        Task<Product> UpdateAsync(Product entity);
    }
}
