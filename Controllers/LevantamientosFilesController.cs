using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/kdslevantamientosfiles")]
    [ApiController]
    public class LevantamientosFilesController : ControllerBase
    {

        public readonly AppDbContext context;

        public LevantamientosFilesController(AppDbContext context)
        {
            this.context = context;
        }


        // GET: api/<LevantamientosFilesController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.levantamientosFiles.ToList());
            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        // GET: api/<FormLevantamientoController>

        // GET api/<GridLevantamientoController>/5
        [EnableCors("corspolicy")]
        [HttpGet("{id}", Name = "GetLevFil")]
        public ActionResult Get(int id)
        {
            try { var formleva = context.levantamientosFiles.FirstOrDefault(g => g.id == id); return Ok(formleva); } catch (Exception ex) { return BadRequest(ex.Message); }
        }




        [HttpPost]
        public async  Task <IActionResult> Post([FromForm] LevantamientosFiles lev)
        {
            string path = await UploadImage(lev.FileUri);
            lev.AcctualFileUrl= path;
            context.levantamientosFiles.Add(lev);
            context.SaveChanges();
            return Ok();

        }

        // POST api/<LevantamientosFilesController>
        /*[HttpPost]
        public ActionResult PostFiles([FromForm] List<IFormFile> files) 
        {
            List<LevantamientosFiles> filesLev = new List<LevantamientosFiles>();
            try
            {
                if(files.Count > 0)
                {
                    foreach(var file in files)
                    {
                        var filePath = "C:\\FilesSystemQA\\kds_levantamiento\\" + file.FileName;
                        using(var stream = System.IO.File.Create(filePath))
                        {
                            file.CopyToAsync(stream);
                        }
                        double tamanio = file.Length;
                        tamanio = tamanio / 1048576;
                        tamanio = Math.Round(tamanio, 2);
                        LevantamientosFiles levFile = new LevantamientosFiles();
                        levFile.extension= Path.GetExtension(file.FileName).Substring(1);
                        levFile.nombre=Path.GetFileNameWithoutExtension(file.FileName);
                        levFile.tamanio = tamanio;
                        levFile.partida = levFile.partida;
                        filesLev.Add(levFile);
                    }
                    context.levantamientosFiles.AddRange(filesLev);
                    context.SaveChanges();
                }
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);

            }
            return Ok(filesLev);
        }
        */
        
        public async Task<string>UploadImage(IFormFile file)
        {
            var special = Guid.NewGuid().ToString();
            var filePath=Path.Combine(Directory.GetCurrentDirectory(),@"Utility\Image", special+ "-"+file.FileName);
            using (FileStream ms = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(ms);
            }
            var filename = special + "-"+file.FileName ;
            //return Path.Combine(@"Utility\Image", filename);
            return filePath;

        }

    }
}
