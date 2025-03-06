using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace segunda_practica_stock_zapatillas
{
    internal class ZapatillasStore
    {
        public List<Zapatilla> listar()
        {
            List<Zapatilla> lista = new List<Zapatilla>();

            SqlConnection conexionDB = new SqlConnection();
            SqlCommand sqlCommand = new SqlCommand();
            SqlDataReader lector;
            try
            {
                conexionDB.ConnectionString = "server =.\\SQLEXPRESS; database=TIENDA_DB; integrated security = true;";
                sqlCommand.CommandType = System.Data.CommandType.Text;

                sqlCommand.CommandText = "SELECT Marca, Talle, Nombre, EstaDisponible, T.Descripcion tipo From ZAPATILLAS Z, TIPOS T Where T.IdTipo = Z.IdTipo\r\n";

                sqlCommand.Connection = conexionDB;

                conexionDB.Open();

                lector = sqlCommand.ExecuteReader();

                while (lector.Read())
                {
                    Zapatilla ejemploZapatilla = new Zapatilla();
                    ejemploZapatilla.Nombre = (string)lector["Nombre"];
                    ejemploZapatilla.EstaDisponible = (bool)lector["EstaDisponible"];
                    ejemploZapatilla.Talle = (int)lector["Talle"];
                    ejemploZapatilla.Marca = (string)lector["Marca"];
                    ejemploZapatilla.Tipo = new Tipo();
                    ejemploZapatilla.Tipo.Descripcion = (string)lector["Tipo"];
                    lista.Add(ejemploZapatilla);
                }
                conexionDB.Close();
                return lista;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
