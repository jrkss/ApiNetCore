using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_PE_TabThree")]
    public class ProEcoTabThreeByPlanta
    {
        [Key]
        public int partida { get; set; }
        public string? id_prospecto { get; set; }
        public string? planta { get; set; }
        public string? pe_tabb_equip { get; set; }
        public decimal? pe_tabb_cant { get; set; }
        public string? pe_tabb_prod { get; set; }
        public string? pe_tabb_cinturon { get; set; }
        public string? pe_tabb_tipofrec { get; set; }
        public string? pe_tabb_cantfrec { get; set; }
        public string? pe_tabb_comentario { get; set; }
    }
}
