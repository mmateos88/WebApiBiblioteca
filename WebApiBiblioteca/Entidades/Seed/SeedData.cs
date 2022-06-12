using Microsoft.EntityFrameworkCore;

namespace WebApiBiblioteca.Entidades.Seed
{
    public class SeedData
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Editoriales
            var susaeta = new Editorial { Id = 1, Nombre = "Susaeta" };
            var anaya = new Editorial { Id = 2, Nombre = "Anaya" };
            var minotauro = new Editorial { Id = 3, Nombre = "Minotauro" };

            modelBuilder.Entity<Editorial>().HasData(susaeta, anaya, minotauro);



            // Libros
            var atlas = new Libro { Id = 1, Titulo = "Mi primer atlas", Paginas = 14, EditorialId = 1 };
            var circula = new Libro { Id = 2, Titulo = "Circula por la ciudad", Paginas = 10, EditorialId = 1 };
            var dinosaurio = new Libro { Id = 3, Titulo = "Mi mascota el dinosaurio", Paginas = 32, EditorialId = 1 };

            var alma = new Libro { Id = 4, Titulo = "Alma de elefante", Paginas = 160, EditorialId = 2 };
            var bosque = new Libro { Id = 5, Titulo = "En un bosque de hoja caduca", Paginas = 120, EditorialId = 2 };
            var tarde = new Libro { Id = 6, Titulo = "La primera tarde después de navidad", Paginas = 112, EditorialId = 2 };
            var arca = new Libro { Id = 7, Titulo = "El arca y yo", Paginas = 152, EditorialId = 2 };
            var chicas = new Libro { Id = 8, Titulo = "Las chicas de la 305", Paginas = 248, EditorialId = 2 };

            var naturaleza = new Libro { Id = 9, Titulo = "La naturaleza de la tierra media", Paginas = 504, EditorialId = 3 };
            var cine = new Libro { Id = 10, Titulo = "Sinopsis de cine", Paginas = 344, EditorialId = 3 };

            modelBuilder.Entity<Libro>().HasData(atlas, circula, dinosaurio, alma,bosque,tarde,arca,chicas, naturaleza,cine);
        }
    }
}
