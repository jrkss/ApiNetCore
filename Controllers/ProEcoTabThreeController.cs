using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/proecotabthree")]
    [ApiController]
    public class ProEcoTabThreeController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProEcoTabThreeController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabThreeController>
        [EnableCors("corspolicy")]
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.proEcoTabThrees.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEcoTabThree")]
        public ActionResult Get(int partida)
        {
            try { var proecotabthreeg = _context.proEcoTabThrees.FirstOrDefault(g => g.partida == partida); return Ok(proecotabthreeg); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ProEcoTabThree proEcoTabThreeP)
        {
            try { _context.proEcoTabThrees.Add(proEcoTabThreeP); _context.SaveChanges(); return CreatedAtRoute("GetProEcoTabThree", new { partida = proEcoTabThreeP.partida }, proEcoTabThreeP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] ProEcoTabThree proEcoTabThreept)
        {
            try
            {
                if (proEcoTabThreept.partida == partida)
                {
                    _context.Entry(proEcoTabThreept).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEcoTabThree", new { partida = proEcoTabThreept.partida }, proEcoTabThreept);
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
                var proecotabthreed = _context.proEcoTabThrees.FirstOrDefault(g => g.partida == partida);
                if (proecotabthreed != null)
                {
                    _context.proEcoTabThrees.Remove(proecotabthreed);
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
