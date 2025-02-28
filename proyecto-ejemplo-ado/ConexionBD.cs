using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  //Una vez importada la libreria de SQL para base de datos podemos usar sus configuraciones

namespace proyecto_ejemplo_ado
{
    internal class ConexionBD
    {
        public List<Pokemon> PokemonList()
        {
            List<Pokemon> list = new List<Pokemon>();

            SqlConnection conexionDB = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                // Configuración de la cadena de conexión a la base de datos local SQL Server
                conexionDB.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true";

                // En caso de conectar a una base de datos en línea, se debe reemplazar "server" por la IP del servidor.
                // La propiedad "database" indica la base de datos a la que nos conectaremos.
                // La autenticación puede ser integrada (Windows Authentication) o con usuario y contraseña:
                // Ejemplo de autenticación con usuario: "integrated security=false; user=user; password=1234"

                // Configuración del comando SQL
                comando.CommandType = System.Data.CommandType.Text;
                // Define el tipo de comando como texto plano, lo que indica que ejecutará una consulta SQL.

                comando.CommandText = "SELECT Nombre, Numero, Bio , ImagenUrl FROM pokemon";
                // Consulta SQL para obtener los campos "Nombre", "Numero" y "Bio" de la tabla "pokemon".

                comando.Connection = conexionDB; // Asocia el comando con la conexión a la base de datos.

                conexionDB.Open(); // Abre la conexión con la base de datos.

                lector = comando.ExecuteReader();
                // Ejecuta la consulta y almacena el resultado en "lector", permitiendo recorrer los registros obtenidos.

                // Procesamiento de los resultados obtenidos
                while (lector.Read())
                {
                    // Mientras haya registros en el resultado, se procesará cada uno.
                    Pokemon aux = new Pokemon(); // Se crea un objeto "Pokemon" para almacenar los datos del registro actual.

                    aux.Numero = (int)lector["Numero"]; // Obtiene el valor del campo "Numero" y lo asigna a la propiedad correspondiente
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Biografia = (string)lector["Bio"];
                    aux.Imagen = (string)lector["ImagenUrl"];
                  
                    //Otra forma de hacerlo tal vez mas intuitiva 
                    list.Add(aux);
                }
                conexionDB.Close();

                return list; // Retorna la lista con los objetos Pokémon obtenidos de la base de datos.
            }

            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
