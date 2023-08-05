using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/cinturones")]
    [ApiController]
    public class CinturonController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CinturonController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.cinturones.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{c1}", Name = "GetCinturon")]
        public ActionResult Get(string c1)
        {
            try { var cinturonesg = _context.cinturones.FirstOrDefault(g => g.c1 == c1); return Ok(cinturonesg); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] Cinturones cinturonesp)
        {
            try { _context.cinturones.Add(cinturonesp); _context.SaveChanges(); return CreatedAtRoute("GetCinturon", new { c1 = cinturonesp.c1 }, cinturonesp); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{c1}")]
        public ActionResult Put(string c1, [FromBody] Cinturones cinturonespt)
        {
            try
            {
                if (cinturonespt.c1 == c1)
                {
                    _context.Entry(cinturonespt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetCinturon", new { c1 = cinturonespt.c1 }, cinturonespt);
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
                var cinturonesd = _context.cinturones.FirstOrDefault(g => g.c1 == c1);
                if (cinturonesd != null)
                {
                    _context.cinturones.Remove(cinturonesd);
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
