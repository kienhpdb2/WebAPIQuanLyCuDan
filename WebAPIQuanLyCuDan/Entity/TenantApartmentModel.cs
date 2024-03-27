using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace WebAPIQuanLyCuDan.Entity
{
    public class TenantApartmentModel
    {
        public int tenant_id { get; set; }
        
        public int apartment_id { get; set; }
       

  
    }
}