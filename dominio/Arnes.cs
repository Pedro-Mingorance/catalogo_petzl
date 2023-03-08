using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Arnes
    {
        public string NombreArnes { get; set; }
        public DateTime FechaFabricacion { get; set; }
        public int TipoUsuario { get; set; }
        public string UrlImagen { get; set; }
        public Uso UsoRecomendado { get; set; }
        public Uso UsoNoRecomendado { get; set; }
    }
}
