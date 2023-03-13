using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using dominio;

namespace negocio
{
    public class ArnesNegocio
    {
        public List<Arnes> listar()
        {
            List<Arnes> lista = new List<Arnes>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=ARNESES_DB; integrated security=true";
                comando.CommandType = System.Data.CommandType.Text;
                comando.CommandText = "Select NombreArnes, FechaFabricacion, TipoUsuario, UrlImagen, U.IdTipoUso UsoRecomendado, N.IdTipoUso UsoNoRecomendado From ARNESES A, USOS U, USOS N Where U.Id = A.UsoRecomendado And N.Id = A.UsoNoRecomendado";
                comando.Connection = conexion;

                conexion.Open();
                lector = comando.ExecuteReader();

                while (lector.Read())
                {
                    Arnes aux = new Arnes();
                    aux.NombreArnes = (String)lector["NombreArnes"];
                    aux.FechaFabricacion = (DateTime)lector["FechaFabricacion"];
                    aux.TipoUsuario = (int)lector["TipoUsuario"];
                    aux.UrlImagen = (string)lector["UrlImagen"];
                    aux.UsoRecomendado = new Uso();
                    aux.UsoRecomendado.Descripcion = (string)lector["UsoRecomendado"];
                    aux.UsoNoRecomendado = new Uso();
                    aux.UsoNoRecomendado.Descripcion = (string)lector["UsoNoRecomendado"];

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void agregar(Arnes nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Insert into ARNESES (NombreArnes, TipoUsuario, UsoRecomendado, UsoNoRecomendado)values('" + nuevo.NombreArnes + "', '" + nuevo.TipoUsuario + "', '" + nuevo.UsoRecomendado + "', '" + nuevo.UsoNoRecomendado + "')");
                datos.ejecutarAccion();
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

        public void modificar(Arnes modificar)
        {

        }
    }
}
