using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/tabfivebyplanta")]
    [ApiController]
    public class ProEcoTabFiveByPlantaController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public ProEcoTabFiveByPlantaController(AppDbContext dbConext)
        {
            _dbcontext = dbConext;
        }

        [HttpGet("{planta}")]
        public IActionResult Get(string planta)
        {
            try
            {
                List<ProEcoTabFive> proEcoTabFives = new List<ProEcoTabFive>();
                if (planta == null)
                {
                    proEcoTabFives = _dbcontext.proEcoTabFives.ToList();
                }
                else
                {
                    //proEcoTabThreeByPlantas = _dbcontext.proEcoTabThreeByPlantas.Where(x => x.planta.ToLower().IndexOf(planta) > -1).ToList();
                    SqlConnection con = (SqlConnection)_dbcontext.Database.GetDbConnection();
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "tabFiveByPlanta";
                    command.Parameters.Add("@planta", System.Data.SqlDbType.VarChar, 10).Value = planta;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProEcoTabFive byPlanta = new ProEcoTabFive();
                        byPlanta.partida = (int)reader["partida"];
                        byPlanta.id_prospecto = (string)reader["id_prospecto"];
                        byPlanta.planta = (string)reader["planta"];
                        byPlanta.pe_tabd_solicitud = (string)reader["pe_tabd_solicitud"];
                        byPlanta.pe_tabd_yesno = (string)reader["pe_tabd_yesno"];
                        byPlanta.pe_tabd_espe = (string)reader["pe_tabd_espe"];
                        proEcoTabFives.Add(byPlanta);
                    }
                    con.Close();
                }
                return Ok(proEcoTabFives);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
