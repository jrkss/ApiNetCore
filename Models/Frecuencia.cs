using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_frecuencia")]
    public class Frecuencia
    {
        [Key]
        public string? c1 { get; set; }
        public string? c2 { get; set; }
        public string? c3 { get; set; }
    }
}
