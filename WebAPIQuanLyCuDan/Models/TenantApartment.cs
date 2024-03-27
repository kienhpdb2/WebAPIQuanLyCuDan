using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIQuanLyCuDan.Models
{
    [Table("tenant_apartment")]
    public class TenantApartment
    {
        [Key, Required]
        public int tenant_id { get; set; }
        
        [Key, Required]
        public int apartment_id { get; set; }
       
        public  Tenant tenant { get; set; }
        public  Apartment apartment { get; set; }

  
    }
}