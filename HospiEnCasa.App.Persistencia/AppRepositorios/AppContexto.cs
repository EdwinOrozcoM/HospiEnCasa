using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<persona> Personas { get; set; }
        public DbSet<paciente> Pacientes { get; set; }
        public DbSet<medico> Medicos { get; set; }
        public DbSet<enfermera> Enfermeras { get; set; }
        public DbSet<familiarDesignado> FamiliaresDesignados { get; set; }
        public DbSet<signoVital> SignosVitales { get; set; }
        public DbSet<historia> Historias { get; set; }
        public DbSet<sugerenciaCuidado> SugerenciasCuidado { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder confi)
        {
            if (!confi.IsConfigured)
            {
                confi.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = HospiEnCasaData");
            }
        }
    }

}