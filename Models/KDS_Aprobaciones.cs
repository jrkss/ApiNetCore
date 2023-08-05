using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_aprobaciones")]
    public class KDS_Aprobaciones
    {
        [Key]
        public int partida { get; set; }
        public string? planta { get; set; }
        public string? apro_nombre { get; set; }
        public string? apro_asesor { get; set; }
        public DateTime? apro_fecha { get; set; }
        public decimal? apro_precio { get; set; }
        public string? apro_comentarios { get; set; }
        public string? apro_estatus { get; set; }
        public string? apro_folio_cot { get; set; }
    }
}
