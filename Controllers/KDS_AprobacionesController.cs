using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/kds_aprobaciones")]
    [ApiController]
    public class KDS_AprobacionesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public KDS_AprobacionesController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<ProEcoTabOneController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.kDS_Aprobaciones.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{partida}", Name = "GetKDS_Aprobaciones")]
        public ActionResult Get(int partida)
        {
            try { var kds_aprobaciones = _context.kDS_Aprobaciones.FirstOrDefault(g => g.partida == partida); return Ok(kds_aprobaciones); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] KDS_Aprobaciones kds_AprobacionesP)
        {
            try { _context.kDS_Aprobaciones.Add(kds_AprobacionesP); _context.SaveChanges(); return CreatedAtRoute("GetKDS_Aprobaciones", new { partida = kds_AprobacionesP.partida }, kds_AprobacionesP); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{partida}")]
        public ActionResult Put(int partida, [FromBody] KDS_Aprobaciones kds_Aprobacionespt) 
        {
            try
            {
                if (kds_Aprobacionespt.partida == partida)
                {
                    _context.Entry(kds_Aprobacionespt).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetKDS_Aprobaciones", new { partida = kds_Aprobacionespt.partida }, kds_Aprobacionespt);
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
                var kds_Aprobacionesd = _context.kDS_Aprobaciones.FirstOrDefault(g => g.partida == partida);
                if (kds_Aprobacionesd != null)
                {
                    _context.kDS_Aprobaciones.Remove(kds_Aprobacionesd);
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
