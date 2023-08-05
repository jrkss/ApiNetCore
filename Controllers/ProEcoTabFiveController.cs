using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/proecotabfive")]
    [ApiController]
    public class ProEcoTabFiveController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProEcoTabFiveController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.proEcoTabFives.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEcoTabFive")]
        public ActionResult Get(int partida)
        {
            try { var proecotabfiveg = _context.proEcoTabFives.FirstOrDefault(g => g.partida == partida); return Ok(proecotabfiveg); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ProEcoTabFive proEcoTabFiveP)
        {
            try { _context.proEcoTabFives.Add(proEcoTabFiveP); _context.SaveChanges(); return CreatedAtRoute("GetProEcoTabFive", new { partida = proEcoTabFiveP.partida }, proEcoTabFiveP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] ProEcoTabFive proEcoTabFivept)
        {
            try
            {
                if (proEcoTabFivept.partida == partida)
                {
                    _context.Entry(proEcoTabFivept).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEcoTabFive", new { partida = proEcoTabFivept.partida }, proEcoTabFivept);
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
                var proecotabfived = _context.proEcoTabFives.FirstOrDefault(g => g.partida == partida);
                if (proecotabfived != null)
                {
                    _context.proEcoTabFives.Remove(proecotabfived);
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
