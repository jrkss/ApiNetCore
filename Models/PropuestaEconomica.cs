using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_pro_eco")]
    public class PropuestaEconomica
    {
        [Key]
        public int partida { get; set; }
        public string? planta { get; set; }
        public string? id_prospecto { get; set; }
        public string? proeco_nombre { get; set; }
        public string? proeco_asesor { get; set; }
        public DateTime? proeco_fecha { get; set; }
        public string? proeco_estatus { get; set; }
    }
}
