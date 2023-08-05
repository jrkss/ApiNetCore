using API_SECOPLA_KPL.Context;
using API_SECOPLA_KPL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_SECOPLA_KPL.Controllers
{
    [Route("api/tabthreebyplanta")]
    [ApiController]
    public class ProEcoTabThreeByPlantaController : ControllerBase
    {
        private readonly AppDbContext _dbcontext;
        public ProEcoTabThreeByPlantaController(AppDbContext dbConext)
        {
            _dbcontext = dbConext;
        }
        
        [HttpGet("{planta}")]
        public IActionResult Get(string planta) 
        {
            try
            {
                List<ProEcoTabThreeByPlanta> proEcoTabThreeByPlantas = new List<ProEcoTabThreeByPlanta>();
                if (planta == null)
                {
                    proEcoTabThreeByPlantas = _dbcontext.proEcoTabThreeByPlantas.ToList();
                }
                else
                {
                    //proEcoTabThreeByPlantas = _dbcontext.proEcoTabThreeByPlantas.Where(x => x.planta.ToLower().IndexOf(planta) > -1).ToList();
                    SqlConnection con = (SqlConnection)_dbcontext.Database.GetDbConnection();
                    SqlCommand command = con.CreateCommand();
                    con.Open();
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.CommandText = "tabThreeByPlanta";
                    command.Parameters.Add("@planta", System.Data.SqlDbType.VarChar, 10).Value = planta;
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ProEcoTabThreeByPlanta byPlanta = new ProEcoTabThreeByPlanta();
                        byPlanta.partida = (int)reader["partida"];
                        byPlanta.id_prospecto = (string)reader["id_prospecto"];
                        byPlanta.planta = (string)reader["planta"];
                        byPlanta.pe_tabb_equip = (string)reader["pe_tabb_equip"];
                        byPlanta.pe_tabb_cant = (decimal)reader["pe_tabb_cant"];
                        byPlanta.pe_tabb_prod = (string)reader["pe_tabb_prod"];
                        byPlanta.pe_tabb_cinturon = (string)reader["pe_tabb_cinturon"];
                        byPlanta.pe_tabb_tipofrec = (string)reader["pe_tabb_tipofrec"];
                        byPlanta.pe_tabb_cantfrec = (string)reader["pe_tabb_cantfrec"];
                        byPlanta.pe_tabb_comentario = (string)reader["pe_tabb_comentario"];
                        proEcoTabThreeByPlantas.Add(byPlanta);
                    }
                    con.Close();
                }
                return Ok(proEcoTabThreeByPlantas);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);

            }
           


        }
    }
}
