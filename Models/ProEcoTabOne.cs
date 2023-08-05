using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_PE_TabOne")]
    public class ProEcoTabOne
    {
        [Key]
        public int partida { get; set; }
        public string? planta { get; set; }
        public string? id_prospecto { get; set; }
        public string? pe_ae_acomodato { get; set; }    
        public string? pe_ae_procliente { get; set; }
        public string? pe_ec_fisica { get; set; }
        public string? pe_ec_digital { get; set; }
        public string? pe_tec_fulltime { get; set; }
        public string? pe_tec_partime { get; set; }
        public string? pe_tec_asigruta { get; set; }
    }
}
