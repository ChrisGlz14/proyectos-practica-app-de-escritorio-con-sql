using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        public int Numero  { get; set; }
        public String Nombre { get; set; }
        public String Biografia { get; set; }
        public String Imagen {  get; set; }
        public TipoPokemon Tipo { get; set; }
        public TipoPokemon Debilidad { get; set; }
    }
}
