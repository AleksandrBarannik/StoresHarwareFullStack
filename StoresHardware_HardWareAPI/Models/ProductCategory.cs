using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StoresHardware_HardWareAPI.Models
{
    public class ProductCategory
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }


        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}

