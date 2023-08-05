using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kds_levantamientos_files")]
    public class LevantamientosFiles
    {
        [Key]
        public int id { get; set; }
        public string? partida { get; set; }
        [NotMapped]
        public IFormFile? FileUri { get; set; }
        public string? AcctualFileUrl { get; set; }
    }
}
