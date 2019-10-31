using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Espectaculos
{
    public static class BD
    {
        public static string connectionString = "Server=.;Database=Espectaculos;Trusted_Connection=True;";

        private static SqlConnection Conectar()
        {
            SqlConnection Conn = new SqlConnection(connectionString);
            Conn.Open();
            return Conn;
        }
        public static void desconectar(SqlConnection Conexion)
        {
            Conexion.Close();
        }

        public static List<TipoShow> ListarTiposShows()
        {
            List<TipoShow> Lista = new List<TipoShow>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * FROM TipoShow order by Nombre asc";
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                int idTipoShow = Convert.ToInt32(dataReader["IdTipoShow"]);
                string Nombre = dataReader["Nombre"].ToString();
                
                TipoShow nuevo = new TipoShow(idTipoShow, Nombre);
                Lista.Add(nuevo);
            }
            desconectar(Conexion);
            return Lista;
        }

        public static List<Show> ListarShows(int idTipoShow)
        {
            List<Show> Lista = new List<Show>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * FROM Shows WHERE IdTipoShow=" + idTipoShow.ToString();
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                int idShow = Convert.ToInt32(dataReader["IdShow"]);
                string NombreShow = dataReader["NombreShow"].ToString();

                Show nuevo = new Show(idShow, idTipoShow, NombreShow);
                Lista.Add(nuevo);
            }
            desconectar(Conexion);
            return Lista;
        }

        public static List<Horario> ListarHorarios(int IdShow)
        {
            List<Horario> Lista = new List<Horario>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * FROM Horarios WHERE IdShow=" + IdShow.ToString();
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                int idShow = Convert.ToInt32(dataReader["IdShow"]);
                int idHorario = Convert.ToInt32(dataReader["IdHorario"]);
                string Dia = dataReader["Dia"].ToString();
                string Hora = dataReader["Hora"].ToString();
                string Canal = dataReader["Canal"].ToString();

                Horario nuevo = new Horario(idHorario, idShow, Dia, Hora, Canal);
                Lista.Add(nuevo);
            }
            desconectar(Conexion);
            return Lista;
        }

        public static List<Actor> ListarActores(int IdShow)
        {
            List<Actor> Lista = new List<Actor>();
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "SELECT * FROM Actores WHERE IdShow=" + IdShow.ToString();
            Consulta.CommandType = System.Data.CommandType.Text;
            SqlDataReader dataReader = Consulta.ExecuteReader();
            while (dataReader.Read())
            {
                int idShow = Convert.ToInt32(dataReader["IdShow"]);
                int idActor = Convert.ToInt32(dataReader["IdActor"]);
                string Nombre = dataReader["Nombre"].ToString();

                Actor nuevo = new Actor(idActor, idShow, Nombre);
                Lista.Add(nuevo);
            }
            desconectar(Conexion);
            return Lista;
        }

        public static void EliminarActor(int IdActor)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "DELETE FROM Actores WHERE IdActor=" + IdActor.ToString();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.ExecuteNonQuery();
            desconectar(Conexion);
        }
        public static void EliminarHorario(int IdHorario)
        {
            SqlConnection Conexion = Conectar();
            SqlCommand Consulta = Conexion.CreateCommand();
            Consulta.CommandText = "DELETE FROM Horarios WHERE IdHorario=" + IdHorario.ToString();
            Consulta.CommandType = System.Data.CommandType.Text;
            Consulta.ExecuteNonQuery();
            desconectar(Conexion);
        }

    }
}
