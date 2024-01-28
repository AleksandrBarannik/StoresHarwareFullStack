using System.ComponentModel.DataAnnotations;

namespace StoresHardware_HardWareAPI.Models.Dto
{
    public class ShopCreateDto
    {
        [Required]
        public int ShopId { get; set; }
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        [Required]
        public int Phone { get; set; }
        public string Adress { get; set; }     
        
       
    }
}
