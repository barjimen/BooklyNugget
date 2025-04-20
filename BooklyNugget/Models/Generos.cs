using BooklyNugget.Models;

namespace BooklyNugget.Models
{
    public class Generos
    {
        public Etiquetas Genero { get; set; }
        public List<LibrosDTO> Libros { get; set; }
    }
}
