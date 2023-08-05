using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_PE_TabFive")]
    public class ProEcoTabFive
    {
        [Key]
        public int partida { get; set; }
        public string? id_prospecto { get; set; }
        public string? planta { get; set; }
        public string? pe_tabd_solicitud { get; set; }
        public string? pe_tabd_yesno { get; set; }
        public string? pe_tabd_espe { get; set; }
    }
}
