using System.ComponentModel.DataAnnotations;

namespace BooklyNugget.Models
{
    public class LibrosDetalles
    {
        public Libros Libro { get; set; }
        public List<Etiquetas> Etiquetas { get; set; }
        public List<Resenas> Resenas { get; set; }
        public int ListaLibro { get; set; }
    }
}
