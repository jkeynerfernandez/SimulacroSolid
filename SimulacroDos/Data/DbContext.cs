using Microsoft.EntityFrameworkCore;
using SimulacroDos.Models;

namespace SimulacroDos.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Especialidad> Especialidades { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Cita> Citas { get; set; }
         public DbSet<Tratamiento> Tratamientos { get; set; }

        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     modelBuilder.Entity<Medico>()
        //         .HasOne(m => m.Especialidad) // un medico tine una especialidad
        //         .WithMany() // Una especialidad puede tener varios médicos
        //         .HasForeignKey(m => m.EspecialidadID);   // La clave foránea en Medico es EspecialidadI

            
        
        // }
    }
}
