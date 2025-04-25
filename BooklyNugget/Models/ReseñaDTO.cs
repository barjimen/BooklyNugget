using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooklyNugget.Models
{
    public class ReseñaDTO
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string NombreUsuario { get; set; }
        public string ImagenPerfil { get; set; }
        public int Calificacion { get; set; }
        public string Texto { get; set; }
        public DateTime Fecha { get; set; }
    }
}
