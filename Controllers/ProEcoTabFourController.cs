using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{

    [EnableCors("corspolicy")]
    [Route("api/proecotabfour")]
    [ApiController]
    public class ProEcoTabFourController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProEcoTabFourController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.proEcoTabFours.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetProEcoTabFour")]
        public ActionResult Get(int partida)
        {
            try { var proecotabfourg = _context.proEcoTabFours.FirstOrDefault(g => g.partida == partida); return Ok(proecotabfourg); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] ProEcoTabFour proEcoTabFourP)
        {
            try { _context.proEcoTabFours.Add(proEcoTabFourP); _context.SaveChanges(); return CreatedAtRoute("GetProEcoTabFour", new { partida = proEcoTabFourP.partida }, proEcoTabFourP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] ProEcoTabFour proEcoTabFourpt)
        {
            try
            {
                if (proEcoTabFourpt.partida == partida)
                {
                    _context.Entry(proEcoTabFourpt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetProEcoTabFour", new { partida = proEcoTabFourpt.partida }, proEcoTabFourpt);
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
                var proecotabfourd = _context.proEcoTabFours.FirstOrDefault(g => g.partida == partida);
                if (proecotabfourd != null)
                {
                    _context.proEcoTabFours.Remove(proecotabfourd);
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
