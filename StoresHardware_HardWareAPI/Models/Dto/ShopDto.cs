using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoresHardware_HardWareAPI.Models.Dto
{
    public class ShopDto
    {
        public int ShopId { get; set; }        
        public string Name { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        public string Adress { get; set; }
        
    }
}
