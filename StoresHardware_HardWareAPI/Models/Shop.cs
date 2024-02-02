using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoresHardware_HardWareAPI.Models
{
    public class Shop
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ShopId { get; set; }
        public string Name { get; set; }

        public string Phone { get; set; }

        public string Adress { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }


}

