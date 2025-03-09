using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // Una vez importada la librería de SQL para base de datos, podemos usar sus configuraciones.
using dominio;
using negocio;

namespace negocio
{
    public class PokemonNegocio
    {
        public List<Pokemon> PokemonList()
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            ElementoNegocio elementoNegocio = new ElementoNegocio();

            try
            {
                datos.setConsulta("Select P.Nombre, P.Numero, P.Bio, P.ImagenUrl, E.Tipo,D.tipo Debilidad From Pokemon P ,Elementos E, Elementos D Where P.Tipo = E.id AND P.idDebilidad = D.id");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon p = new Pokemon();

                    p.Numero = (int)datos.Lector["Numero"];
                    p.Nombre = (string)datos.Lector["Nombre"];
                    p.Biografia = (string)datos.Lector["Bio"];
                    p.Imagen = (string)datos.Lector["ImagenUrl"];

                    p.Tipo = new TipoPokemon();
                    p.Debilidad = new TipoPokemon();
                    p.Tipo.Tipo = (string)datos.Lector["Tipo"];
                    p.Debilidad.Tipo = (string)datos.Lector["Debilidad"];


                    lista.Add(p);
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion();
            }
            return lista;
        }

        public void agregar(Pokemon nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("insert into Pokemon (Numero,Nombre, Bio) values(" + nuevo.Numero + ",'"+ nuevo.Nombre +"','"+ nuevo.Biografia +"')");
                //datos.ejecutarLectura(); No puedo hacer esto porque lo que quiero hacer  es una insercion
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            } finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Pokemon modificar)
        {

        }
    }
        
}
