using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Entidades
{
    public class Libro
    {
        public int Id { get; set; }

        [StringLength(150)]
        public string Titulo { get; set; }
        
        public int Paginas { get; set; }

        public int EditorialId { get; set; }
        public Editorial Editorial { get; set; }    

    }
}
