using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_PE_TabTwo")]
    public class ProEcoTabTwo
    {
        [Key]
        public int partida { get; set; }
        public string? planta { get; set; }
        public string? id_prospecto { get; set; }
        public string? pe_taba_apli { get; set; }
        public string? pe_taba_prod { get; set; }
        public string? pe_taba_cant { get; set; }
        public string? pe_taba_area { get; set; }
        public string? pe_taba_tipofrec { get; set; }
        public decimal? pe_taba_cantfrec { get; set; }
        public string? pe_taba_comentfrec { get; set; }
    }
}
