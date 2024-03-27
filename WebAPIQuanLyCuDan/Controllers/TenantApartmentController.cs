using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebAPIQuanLyCuDan.Entity;
using WebAPIQuanLyCuDan.Models;

namespace WebAPIQuanLyCuDan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TenantApartmentController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TenantApartmentController(AppDbContext context)
        {
            _context = context;
        }

        // Lấy tất cả các cư dân
        [HttpGet("tenants")]
        public async Task<ActionResult<IEnumerable<Tenant>>> GetTenants()
        {
            return await _context.tenants.ToListAsync();
        }
        // Lấy thông tin cư dân dựa trên ID
        [HttpGet("tenant/{id}")]
        public IActionResult GetTenantById(int id)
        {
            var tenant = _context.tenants.FirstOrDefault(t => t.tenant_id == id);

            if (tenant == null)
            {
                return NotFound();
            }

            return Ok(tenant);
        }
        // Lấy tất cả các căn hộ
        [HttpGet("apartments")]
        public async Task<ActionResult<IEnumerable<Apartment>>> GetApartments()
        {
            return await _context.apartments.ToListAsync();
        }
        // Lấy thông tin căn hộ dựa trên ID
        [HttpGet("apartment/{id}")]
        public IActionResult GetApartment(int id)
        {
            var apartment = _context.apartments.FirstOrDefault(a => a.apartment_id == id);

            if (apartment == null)
            {
                return NotFound();
            }

            return Ok(apartment);
        }
        // Lấy tất cả các căn hộ thuộc sở hữu của một cư dân 
        [HttpGet("tenant/{tenantId}/apartments")]
        public IActionResult GetApartmentsByTenantId(int tenantId)
        {
            var tenant = _context.tenants.Include(t => t.tenant_apartments).ThenInclude(ta => ta.apartment).FirstOrDefault(t => t.tenant_id == tenantId);

            if (tenant == null)
            {
                return NotFound();
            }

            var apartments = tenant.tenant_apartments.Select(ta => ta.apartment);
            return Ok(apartments);
        }
        // POST: api/tenant
        [HttpPost("tenant")]
        public IActionResult PostTenant(TenantModel tenantModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var tenant = new Tenant
            {
                first_name = tenantModel.first_name,
                last_name = tenantModel.last_name,
                email = tenantModel.email,
               // tenant_apartments = tenantModel.tenant_apartments,
            };

            _context.tenants.Add(tenant);
            _context.SaveChanges();

            return CreatedAtAction("GetTenant", new { id = tenant.tenant_id }, tenant);
        }
        

        // POST: api/apartment
        [HttpPost("apartment")]
        public IActionResult PostApartment(ApartmentModel apartmentModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var apartment = new Apartment
            {
                address = apartmentModel.address
            };

            _context.apartments.Add(apartment);
            _context.SaveChanges();

            return CreatedAtAction("GetApartment", new { id = apartment.apartment_id }, apartment);
        }

        // PUT: api/tenant/5
        [HttpPut("tenant/{id}")]
        public IActionResult PutTenant(int id, TenantModel tenantModel)
        {
            if (!ModelState.IsValid || id != tenantModel.tenant_id)
            {
                return BadRequest(ModelState);
            }

            var tenant = _context.tenants.Find(id);
            if (tenant == null)
            {
                return NotFound();
            }

            tenant.first_name = tenantModel.first_name;
            tenant.last_name = tenantModel.last_name;
            tenant.email = tenantModel.email;

            _context.SaveChanges();

            return NoContent();
        }

        // PUT: api/apartment/5
        [HttpPut("apartment/{id}")]
        public IActionResult PutApartment(int id, ApartmentModel apartmentModel)
        {
            if (!ModelState.IsValid || id != apartmentModel.apartment_id)
            {
                return BadRequest(ModelState);
            }

            var apartment = _context.apartments.Find(id);
            if (apartment == null)
            {
                return NotFound();
            }
           /* while (apartment.tenant_apartments.Count < apartmentModel.tenant_apartments.Count)
            {
                apartment.tenant_apartments.Add(new TenantApartment());
            }
       
            while (apartment.tenant_apartments.Count > apartmentModel.tenant_apartments.Count)
            {
                apartment.tenant_apartments.RemoveAt(apartment.tenant_apartments.Count - 1);
            }

            for (int i = 0; i < apartment.tenant_apartments.Count; i++)
            {
                apartment.tenant_apartments[i].tenant_id = apartmentModel.tenant_apartments[i].tenant_id;
                apartment.tenant_apartments[i].apartment_id = apartmentModel.tenant_apartments[i].apartment_id;
            }*/
            apartment.apartment_id = apartmentModel.apartment_id;
            apartment.address = apartmentModel.address;
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/tenant/5
        [HttpDelete("tenant/{id}")]
        public IActionResult DeleteTenant(int id)
        {
            var tenant = _context.tenants.Find(id);
            if (tenant == null)
            {
                return NotFound();
            }

            _context.tenants.Remove(tenant);
            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/apartment/5
        [HttpDelete("apartment/{id}")]
        public IActionResult DeleteApartment(int id)
        {
            var apartment = _context.apartments.Find(id);
            if (apartment == null)
            {
                return NotFound();
            }

            _context.apartments.Remove(apartment);
            _context.SaveChanges();

            return NoContent();
        }

    }
}
