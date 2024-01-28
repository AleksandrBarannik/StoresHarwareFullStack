using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoresHardware_HardWareAPI.Models.Dto
{
    public class ProductDto
    {
        public int ProductId { get; set; }       
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductDescription { get; set; }
        public int Price { get; set; }

        public int CategoryId { get; set; }
        public ProductCategoryDto ProductCategory { get; set; }

        public int ShopId { get; set; }
        public ShopDto Shop { get; set; }
    }
}
