using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_Area_Prospecto")]
    [PrimaryKey(nameof(c1), nameof(c2))]

    public class AreasProspecto
    {
        [Key]
        public string? c1 { get; set; }
        [Key]
        public string? c2 { get; set; }
        public string? c3 { get; set; }
        public string? c4 { get; set; }
    }
}
