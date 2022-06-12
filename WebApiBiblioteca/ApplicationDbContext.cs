using WebApiBiblioteca.Entidades;
using WebApiBiblioteca.Entidades.Seed;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace WebApiBiblioteca
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override  void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Libro>().Property(l => l.Paginas).HasPrecision(precision:1, scale:5);


            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            //Para rellenar las tablas con datos
            SeedData.Seed(modelBuilder);
        }

        public DbSet<Libro> Libros { get; set; }
        public DbSet<Editorial> Editoriales { get; set; }
    }
}
