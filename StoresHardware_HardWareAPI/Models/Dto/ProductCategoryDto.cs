using System.ComponentModel.DataAnnotations;

namespace StoresHardware_HardWareAPI.Models.Dto
{
    public class ProductCategoryDto
    {
        public int CategoryId { get; set; }
        [Required][MaxLength(40)]
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
    }
}
