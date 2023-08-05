using API_SECOPLA_KPL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API_SECOPLA_KPL.Context
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Usuarios> usuarios { get; set; }
        public DbSet<GridLevantamiento> gridLevantamientos { get; set; }
        public DbSet<FormLevantamiento> formLevantamientos { get; set; }
        public DbSet<testkpl> testkpl { get; set; }
        public DbSet<ProEcoTabThree>  proEcoTabThrees{ get; set; }
        public DbSet<ProEcoTabTwo> proEcoTabTwos { get; set; }
        public DbSet<ProEcoTabOne> proEcoTabOnes { get; set; }
        public DbSet<KDS_Aprobaciones> kDS_Aprobaciones { get; set; }
        public DbSet<PropuestaEconomica> propuestaEconomicas { get; set; }
        public DbSet<LevantamientosFiles> levantamientosFiles { get; set; }
        public DbSet<AreasProspecto> areasProspectos { get; set; }
        public DbSet<Cinturones> cinturones { get; set; }
        public DbSet<ServiciosProductos> serviciosProductos { get; set; }
        public DbSet<ProductosRNP> productosRNPs { get; set; }
        public DbSet<Frecuencia> frecuencias { get; set; }
        public DbSet<ServiciosTrampasDispositivos> serviciosTrampasDispositivos { get; set; }
        public DbSet<ProEcoTabThreeByPlanta> proEcoTabThreeByPlantas { get; set; }
        public DbSet<ProEcoTabFour> proEcoTabFours { get; set; }   
        public DbSet<ProEcoTabFive> proEcoTabFives { get; set; }

    }
}
