using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPIQuanLyCuDan.Models;

namespace WebAPIQuanLyCuDan.Models
{
    [Table("apartment")]
    public class Apartment
    {
        [Key, Required]
        public int apartment_id { get; set; }

        [Required]
        [MaxLength(200)]
        public string address { get; set; }
      
        public  IList<TenantApartment> tenant_apartments { get; set; } = new List<TenantApartment>();

    }
}