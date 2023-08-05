using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{

    [EnableCors("corspolicy")]
    [Route("api/kds_propuestaeconomica")]
    [ApiController]
    public class PropuestaEconomicaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PropuestaEconomicaController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.propuestaEconomicas.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEco")]
        public ActionResult Get(int partida)
        {
            try { var proecog = _context.propuestaEconomicas.FirstOrDefault(g => g.partida == partida); return Ok(proecog); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] PropuestaEconomica proEcoP)
        {
            try { _context.propuestaEconomicas.Add(proEcoP); _context.SaveChanges(); return CreatedAtRoute("GetProEco", new { partida = proEcoP.partida }, proEcoP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] PropuestaEconomica proEcopt)
        {
            try
            {
                if (proEcopt.partida == partida)
                {
                    _context.Entry(proEcopt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEco", new { partida = proEcopt.partida }, proEcopt);
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
                var proecod = _context.propuestaEconomicas.FirstOrDefault(g => g.partida == partida);
                if (proecod != null)
                {
                    _context.propuestaEconomicas.Remove(proecod);
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
