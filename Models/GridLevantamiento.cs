using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kdudp")]
    public class GridLevantamiento
    {
        [Key]
        public string? c2 { get; set; }
        public string? c3 { get; set; }
        public string? c101 { get; set; }
    }
}
