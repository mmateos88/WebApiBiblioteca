using System.ComponentModel.DataAnnotations;

namespace WebApiBiblioteca.Entidades
{
    public class Editorial
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Nombre { get; set; }

        public ICollection<Libro> Libros { get; set; }
    }
}
