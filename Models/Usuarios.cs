using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API_SECOPLA_KPL.Models
{
    [Table("kpl_users")]
    public class Usuarios
    {
        [Key]
        public int id { get; set; }
        public string username { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string direccion{ get; set; }
        public string region { get; set; }
        public string zona { get; set; }
        public string password { get; set; }
    }
}
