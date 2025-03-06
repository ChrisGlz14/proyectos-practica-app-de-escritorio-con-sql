using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto_ejemplo_ado
{
    internal class TipoPokemon
    {
        public int Id { get; set; }
        public string Tipo { get; set; }

        public override string ToString()
        {
            return Tipo;
        }

        public string Debilidad { get; set; }
    }
}
