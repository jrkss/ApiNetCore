using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_pe_tabfour")]
    public class ProEcoTabFour
    {
        [Key]
        public int partida { get; set; }
        public string? id_prospecto { get; set; }
        public string? planta { get; set; }
        public string? pe_tabc_servadic { get; set; }
        public string? pe_tabc_cantmen { get; set; }
        public string? pe_tabc_espe { get; set; }
    }
}
