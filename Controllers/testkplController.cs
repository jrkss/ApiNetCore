using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/testkpl")]
    [ApiController]
    public class testkplController : ControllerBase
    {
        private readonly AppDbContext _context;

        public testkplController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.testkpl.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [HttpGet("{id_tes}", Name = "GetTestkpl")]
        public ActionResult Get(int id_tes)
        {
            try { var testkpl = _context.testkpl.FirstOrDefault(g => g.id_tes == id_tes); return Ok(testkpl); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<GridLevantamientoController>
        [HttpPost]
        public ActionResult Post([FromBody] testkpl ttkpl)
        {
            try { _context.testkpl.Add(ttkpl); _context.SaveChanges(); return CreatedAtRoute("GetTestkpl", new { id_tes = ttkpl.id_tes }, ttkpl); } catch (Exception ex) { return BadRequest(ex); }
        }

        // PUT api/<GridLevantamientoController>/5
        [HttpPut("{id_tes}")]
        public ActionResult Put(int id_tes, [FromBody] testkpl ttkpl)
        {
            try
            {
                if (ttkpl.id_tes == id_tes)
                {
                    _context.Entry(ttkpl).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetTestkpl", new { id_tes = ttkpl.id_tes }, ttkpl);
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
        [HttpDelete("{id_tes}")]
        public ActionResult Delete(int id_tes)
        {
            try
            {
                var ttkpl = _context.testkpl.FirstOrDefault(g => g.id_tes == id_tes);
                if (ttkpl != null)
                {
                    _context.testkpl.Remove(ttkpl);
                    _context.SaveChanges();
                    return Ok(id_tes);
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
