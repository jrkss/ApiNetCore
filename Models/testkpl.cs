using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_SECOPLA_KPL.Models
{
    [Table("kpl_testdos")]
    public class testkpl
    {
        [Key]
        public int id_tes { get; set; }

        public string? dataservice { get; set; }


    }
}
