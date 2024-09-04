using Microsoft.EntityFrameworkCore;

namespace WebAppCrudEf.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) 
        {
        }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=MATIAS\\SQLEXPRESS;Initial Catalog=WebAppCrudEf;Integrated Security=True;Trust Server Certificate=True");
        //}

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Domicilio> Domicilios { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<AlumnoCurso> AlumnosCursos { get; set; }
    }
}
