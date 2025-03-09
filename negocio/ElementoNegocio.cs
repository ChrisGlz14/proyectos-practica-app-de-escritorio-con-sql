using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.ComponentModel.Design;
using dominio;


namespace negocio
{
    public class ElementoNegocio
    {
        public List<Elemento> listar()
        {

            List<Elemento> lista = new List<Elemento>();
            AccesoDatos datos = new AccesoDatos(); //Nace un objeto que tiene un lector, un comando, una conexion

            try
            {
                //Aca seteamos la consulta que debemos hacer para setear los datos.
                datos.setConsulta("SELECT P.Id, P.Nombre, P.Numero, P.Bio, P.ImagenUrl, P.Tipo, P.idDebilidad FROM Pokemon P");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon p = new Pokemon();

                    Elemento el = new Elemento();
                    p.Nombre = (string)datos.Lector["Nombre"];
                    p.Imagen = (string)datos.Lector["ImagenUrl"];

                   
                    lista.Add(el);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            { 
                datos.cerrarConexion();
            }
           
        }
    }
}
