using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using CoreApiResponse;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/serviciosproductos")]
    [ApiController]
    public class ServiciosProductosController : BaseController
    {
        private readonly AppDbContext _context;

        public ServiciosProductosController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<Servicios Productos>
        
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var studentList = await _context.serviciosProductos.FromSqlRaw("Exec ShowRNP").ToListAsync();
            return Ok(studentList);
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{c1}", Name = "GetServProd")]
        public ActionResult Get(string c1)
        {
            try { 
                var servprodg = _context.serviciosProductos.FirstOrDefault(g => g.c1 == c1);
                return Ok(servprodg); 
            } catch (Exception ex) { 
                return BadRequest(ex.Message); 
            }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ServiciosProductos serviciosproductosp)
        {
            try { _context.serviciosProductos.Add(serviciosproductosp); _context.SaveChanges(); return CreatedAtRoute("GetServProd", new { c1 = serviciosproductosp.c1 }, serviciosproductosp); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{c1}")]
        public ActionResult Put(string c1, [FromBody] ServiciosProductos serviciosproductospt)
        {
            try
            {
                if (serviciosproductospt.c1 == c1)
                {
                    _context.Entry(serviciosproductospt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetServProd", new { c1 = serviciosproductospt.c1 }, serviciosproductospt);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }

        }

        // DELETE api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpDelete("{c1}")]
        public ActionResult Delete(string c1)
        {
            try
            {
                var serviciosproductosd = _context.serviciosProductos.FirstOrDefault(g => g.c1 == c1);
                if (serviciosproductosd != null)
                {
                    _context.serviciosProductos.Remove(serviciosproductosd);
                    _context.SaveChanges();
                    return Ok(c1);
                }
                else
                {
                    return BadRequest();

                }

            }
            catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }

}
