using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/proecotabone")]
    [ApiController]
    public class ProEcoTabOneController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProEcoTabOneController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.proEcoTabOnes.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEcoTabOne")]
        public ActionResult Get(int partida)
        {
            try { var proecotaboneg = _context.proEcoTabOnes.FirstOrDefault(g => g.partida == partida); return Ok(proecotaboneg); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ProEcoTabOne proEcoTabOneP)
        {
            try { _context.proEcoTabOnes.Add(proEcoTabOneP); _context.SaveChanges(); return CreatedAtRoute("GetProEcoTabOne", new { partida = proEcoTabOneP.partida }, proEcoTabOneP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] ProEcoTabOne proEcoTabOnept)
        {
            try
            {
                if (proEcoTabOnept.partida == partida)
                {
                    _context.Entry(proEcoTabOnept).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEcoTabOne", new { partida = proEcoTabOnept.partida }, proEcoTabOnept);
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
        [HttpDelete("{partida}")]
        public ActionResult Delete(int partida)
        {
            try
            {
                var proecotaboned = _context.proEcoTabOnes.FirstOrDefault(g => g.partida == partida);
                if (proecotaboned != null)
                {
                    _context.proEcoTabOnes.Remove(proecotaboned);
                    _context.SaveChanges();
                    return Ok(partida);
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
