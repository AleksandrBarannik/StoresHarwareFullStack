using StoresHardware_HardWareAPI.Models;

namespace StoresHardware_HardWareAPI.Repository.IRepository
{
    public interface IProductCategoryRepository: IRepository<ProductCategory>
    {
        Task<ProductCategory> UpdateAsync(ProductCategory entity);
    }
}
