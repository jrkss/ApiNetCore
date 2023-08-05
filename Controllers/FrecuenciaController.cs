using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/frecuencias")]
    [ApiController]
    public class FrecuenciaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FrecuenciaController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.frecuencias.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{c1}", Name = "GetFrecuencia")]
        public ActionResult Get(string c1)
        {
            try { var frecuenciag = _context.frecuencias.FirstOrDefault(g => g.c1 == c1); return Ok(frecuenciag); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] Frecuencia frecuenciap)
        {
            try { _context.frecuencias.Add(frecuenciap); _context.SaveChanges(); return CreatedAtRoute("GetFrecuencia", new { c1 = frecuenciap.c1 }, frecuenciap); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{c1}")]
        public ActionResult Put(string c1, [FromBody] Frecuencia frecuenciapt)
        {
            try
            {
                if (frecuenciapt.c1 == c1)
                {
                    _context.Entry(frecuenciapt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetFrecuencia", new { c1 = frecuenciapt.c1 }, frecuenciapt);
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
                var frecuenciad = _context.frecuencias.FirstOrDefault(g => g.c1 == c1);
                if (frecuenciad != null)
                {
                    _context.frecuencias.Remove(frecuenciad);
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
