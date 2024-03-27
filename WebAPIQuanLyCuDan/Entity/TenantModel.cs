using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPIQuanLyCuDan.Entity
{
    public class TenantModel
    {
        public int tenant_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
       
        public string email { get; set; }
   
        public IList<TenantApartmentModel> tenant_apartments { get; set; } = new List<TenantApartmentModel>();
    }
}
