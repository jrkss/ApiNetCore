using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/areasprospecto")]
    [ApiController]
    public class AreasProspectoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AreasProspectoController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.areasProspectos.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{c1}", Name = "GetAreasProspecto")]
        public ActionResult Get(string c1)
        {
            try { 
                var areasprospectog = _context.areasProspectos.FirstOrDefault(g => g.c1 == c1);
                return Ok(areasprospectog); 
            } catch (Exception ex) { 
                return BadRequest(ex.Message); 
            }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] AreasProspecto areasProspectoP)
        {
            try { _context.areasProspectos.Add(areasProspectoP); _context.SaveChanges(); return CreatedAtRoute("GetAreasProspecto", new { c1 = areasProspectoP.c1 }, areasProspectoP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{c1}")]
        public ActionResult Put(string c1, [FromBody] AreasProspecto areasProspectoPt)
        {
            try
            {
                if (areasProspectoPt.c1 == c1)
                {
                    _context.Entry(areasProspectoPt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetAreasProspecto", new { c1 = areasProspectoPt.c1 }, areasProspectoPt);
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
                var areasprospectod = _context.areasProspectos.FirstOrDefault(g => g.c1 == c1);
                if (areasprospectod != null)
                {
                    _context.areasProspectos.Remove(areasprospectod);
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
