using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIQuanLyCuDan.Models
{
    [Table("tenant")]
    public class Tenant
    {
        [Key, Required]
        public int tenant_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string first_name { get; set; }

        [Required]
        [MaxLength(100)]
        public string last_name { get; set; }
       
        public string email { get; set; }
   
        public IList<TenantApartment> tenant_apartments { get; set; } = new List<TenantApartment>();
    }
}
