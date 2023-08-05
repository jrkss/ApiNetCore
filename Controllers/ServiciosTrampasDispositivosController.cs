using API_SECOPLA_KPL.Context;
using CoreApiResponse;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{

    [EnableCors("corspolicy")]
    [Route("api/serviciostrampasdispositivos")]
    [ApiController]
    public class ServiciosTrampasDispositivosController : BaseController
    {
        private readonly AppDbContext _context;

        public ServiciosTrampasDispositivosController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<Servicios Productos>

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var actionget = await _context.serviciosTrampasDispositivos.FromSqlRaw("Exec ShowServiTramp").ToListAsync();
            return Ok(actionget);
        }
    }

}
