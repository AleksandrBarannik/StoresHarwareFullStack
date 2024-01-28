using System.ComponentModel.DataAnnotations;

namespace StoresHardware_HardWareAPI.Models.Dto
{
    public class ProductCreateDto
    {
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string ProductModel { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public int Price { get; set; }
        [Required]
        public int CategoryId { get; set; } //foreign key
        [Required]
        public int ShopId { get; set; }
        
    }
}
