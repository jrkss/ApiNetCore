using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/proecotabtwo")]
    [ApiController]
    public class ProEcoTabTwoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProEcoTabTwoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.proEcoTabTwos.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEcoTabTwo")]
        public ActionResult Get(int partida)
        {
            try { var proeco = _context.proEcoTabTwos.FirstOrDefault(g => g.partida == partida); return Ok(proeco); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ProEcoTabTwo proecoP)
        {
            try { _context.proEcoTabTwos.Add(proecoP); _context.SaveChanges(); return CreatedAtRoute("GetProEcoTabTwo", new { partida = proecoP.partida }, proecoP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] ProEcoTabTwo proecopt)
        {
            try
            {
                if (proecopt.partida == partida)
                {
                    _context.Entry(proecopt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEcoTabTwo", new { partida = proecopt.partida }, proecopt);
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
                var proecod = _context.proEcoTabTwos.FirstOrDefault(g => g.partida == partida);
                if (proecod != null)
                {
                    _context.proEcoTabTwos.Remove(proecod);
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
