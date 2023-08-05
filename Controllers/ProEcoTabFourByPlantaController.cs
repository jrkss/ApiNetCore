using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{

    [Route("api/tabfourbyplanta")]
    [ApiController]
    public class ProEcoTabFourByPlantaController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public ProEcoTabFourByPlantaController(AppDbContext dbConext)
        {
            _dbcontext = dbConext;
        }

        [HttpGet("{planta}")]
        public IActionResult Get(string planta)
        {
            try
            {
                List<ProEcoTabFour> proEcoTabFours = new List<ProEcoTabFour>();
                if (planta == null)
                {
                    proEcoTabFours = _dbcontext.proEcoTabFours.ToList();
                }
                else
                {
                    //proEcoTabThreeByPlantas = _dbcontext.proEcoTabThreeByPlantas.Where(x => x.planta.ToLower().IndexOf(planta) > -1).ToList();
                    SqlConnection con = (SqlConnection)_dbcontext.Database.GetDbConnection();
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "tabFourByPlanta";
                    command.Parameters.Add("@planta", System.Data.SqlDbType.VarChar, 10).Value = planta;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProEcoTabFour byPlanta = new ProEcoTabFour();
                        byPlanta.partida = (int)reader["partida"];
                        byPlanta.id_prospecto = (string)reader["id_prospecto"];
                        byPlanta.planta = (string)reader["planta"];
                        byPlanta.pe_tabc_servadic = (string)reader["pe_tabc_servadic"];
                        byPlanta.pe_tabc_cantmen = (string)reader["pe_tabc_cantmen"];
                        byPlanta.pe_tabc_espe = (string)reader["pe_tabc_espe"];
                        proEcoTabFours.Add(byPlanta);
                    }
                    con.Close();
                }
                return Ok(proEcoTabFours);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
