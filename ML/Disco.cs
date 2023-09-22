using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Disco
    {
        public int IdDico { get; set; }
        public string Titulo { get; set; }
        public string Name { get; set; }
        public string Artista { get; set; }
        public string GeneroMusical { get; set; }
        public string Duracion { get; set; }
        public string Año { get; set; }
        public string Distribuidora { get; set; }
        public int Ventas { get; set; }
        public string Disponibilidad { get; set; }
        public List<object> Discos { get; set; }

    }
}
