using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [EnableCors("corspolicy")]
    [Route("api/formlevantamiento")]
    [ApiController]
    public class FormLevantamientoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public FormLevantamientoController(AppDbContext context)
        {
            _context = context;
        }
        // GET: api/<FormLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(_context.formLevantamientos.ToList());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{planta}", Name = "GetFLeva")]
        public ActionResult Get(string planta)
        {
            try { var formleva = _context.formLevantamientos.FirstOrDefault(g => g.planta == planta); return Ok(formleva); } catch (Exception ex) { return BadRequest(ex.Message); }
        }

        // POST api/<FormLevantamientoController>
        [EnableCors("corspolicy")]
        [HttpPost]
        public ActionResult Post([FromBody] FormLevantamiento formlevap)
        {
            try { 
                _context.formLevantamientos.Add(formlevap); 
                _context.SaveChanges(); 
                return CreatedAtRoute("GetFLeva", new { 
                    id_documento = formlevap.planta }, formlevap); 
            } catch (Exception ex) 
            { 
                return BadRequest(ex); }
        }


        // PUT api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpPut("{planta}")]
        public ActionResult Put(string planta, [FromBody] FormLevantamiento formlevap)
        {
            try
            {
                if (formlevap.planta == planta)
                {
                    _context.Entry(formlevap).State = EntityState.Modified;
                    _context.SaveChanges();
                    return CreatedAtRoute("GetFLeva", new { planta = formlevap.planta }, formlevap);
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
        [HttpDelete("{planta}")]
        public ActionResult Delete(string planta)
        {
            try
            {
                var formlevad = _context.formLevantamientos.FirstOrDefault(g => g.planta == planta);
                if (formlevad != null)
                {
                    _context.formLevantamientos.Remove(formlevad);
                    _context.SaveChanges();
                    return Ok(planta);
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
