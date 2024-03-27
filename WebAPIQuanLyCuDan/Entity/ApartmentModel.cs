using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebAPIQuanLyCuDan.Models;

namespace WebAPIQuanLyCuDan.Entity
{    public class ApartmentModel
    {     public int apartment_id { get; set; }

        public string address { get; set; }
      
        public  IList<TenantApartmentModel> tenant_apartments { get; set; } = new List<TenantApartmentModel>();

    }
}