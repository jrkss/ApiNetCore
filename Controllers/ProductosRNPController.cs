using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using CoreApiResponse;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/productosrnp")]
    [ApiController]
    public class ProductosRNPController : BaseController
    {
        private readonly AppDbContext _context;

        public ProductosRNPController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<Servicios Productos>

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var actionget = await _context.productosRNPs.FromSqlRaw("Exec ShowProductRNP").ToListAsync();
            return Ok(actionget);
        }
    }

}
