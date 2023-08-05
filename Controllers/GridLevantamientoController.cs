using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/gridlevantamiento")]
    [ApiController]
    public class GridLevantamientoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GridLevantamientoController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<GridLevantamientoController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.gridLevantamientos.ToList());

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [HttpGet("{c2}", Name ="GetGLeva")]
        public ActionResult Get(string c1)
        {
            try { var gridleva = _context.gridLevantamientos.
                    FirstOrDefault(g => g.c2 == c1); 
                return Ok(gridleva); 
            }catch(Exception ex) { 
                return BadRequest(ex.Message); 
            }
        }

        // POST api/<GridLevantamientoController>
        [HttpPost]
        public ActionResult Post([FromBody] GridLevantamiento gridlevap)
        {
            try { _context.gridLevantamientos.Add(gridlevap); _context.SaveChanges(); return CreatedAtRoute("GetGLeva", new { c1 = gridlevap.c2 }, gridlevap); }catch(Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [HttpPut("{c2}")]
        public ActionResult Put(string c1, [FromBody] GridLevantamiento gridlevap)
        {
            try {
                if (gridlevap.c2 == c1)
                {
                    _context.Entry(gridlevap).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetGLeva", new { c1 = gridlevap.c2 }, gridlevap);
                }
                else
                {
                    return BadRequest();
                }
            } catch (Exception ex) { 
                return BadRequest(ex); 
            }

        }

        // DELETE api/<GridLevantamientoController>/5
        [HttpDelete("{c2}")]
        public ActionResult Delete(string c1)
        {
            try
            {
                var gridlevad = _context.gridLevantamientos.FirstOrDefault(g => g.c2 == c1);
                if(gridlevad != null){
                    _context.gridLevantamientos.Remove(gridlevad);
                    _context.SaveChanges();
                    return Ok(c1);
                }
                else
                {
                    return BadRequest();

                }

            }catch (Exception ex) { return BadRequest(ex.Message); }
        }
    }
}
