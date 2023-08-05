using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/tabtwobyplanta")]
    [ApiController]
    public class ProEcoTabTwoByPlantaController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public ProEcoTabTwoByPlantaController(AppDbContext dbConext)
        {
            _dbcontext = dbConext;
        }

        [HttpGet("{planta}")]
        public IActionResult Get(string planta)
        {
            try
            {
                List<ProEcoTabTwo> proEcoTabTwos = new List<ProEcoTabTwo>();
                if (planta == null)
                {
                    proEcoTabTwos = _dbcontext.proEcoTabTwos.ToList();
                }
                else
                {
                    //proEcoTabTwos = _dbcontext.proEcoTabTwos.Where(x => x.planta.ToLower().IndexOf(planta) > -1).ToList();
                    SqlConnection con = (SqlConnection)_dbcontext.Database.GetDbConnection();
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "tabTwoByPlanta";
                    command.Parameters.Add("@planta", System.Data.SqlDbType.VarChar, 10).Value = planta;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProEcoTabTwo byPlanta = new ProEcoTabTwo();
                        byPlanta.partida = (int)reader["partida"];
                        byPlanta.id_prospecto = (string)reader["id_prospecto"];
                        byPlanta.planta = (string)reader["planta"];
                        byPlanta.pe_taba_apli = (string)reader["pe_taba_apli"];
                        byPlanta.pe_taba_cant = (string)reader["pe_taba_cant"];
                        byPlanta.pe_taba_prod = (string)reader["pe_taba_prod"];
                        byPlanta.pe_taba_area = (string)reader["pe_taba_area"];
                        byPlanta.pe_taba_tipofrec = (string)reader["pe_taba_tipofrec"];
                        byPlanta.pe_taba_cantfrec = (decimal)reader["pe_taba_cantfrec"];
                        byPlanta.pe_taba_comentfrec = (string)reader["pe_taba_comentfrec"];
                        proEcoTabTwos.Add(byPlanta);
                    }
                    con.Close();
                }
                return Ok(proEcoTabTwos);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }



        }
    }
}
