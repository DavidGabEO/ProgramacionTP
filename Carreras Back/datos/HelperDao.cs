using Carreras_Back.usuarios;
using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.datos
{
    class HelperDao     //Esto es una implementación de singleton
    {
        private static HelperDao instance;
        private string cnnCadena;


        private HelperDao()
        {
            cnnCadena = @"Data Source=LAPTOP-4F53OIPC\SQLEXPRESS;Initial Catalog=GestionCarreras;Integrated Security=True";
        }
       

        public static HelperDao GetInstance()
        {

            if (instance == null)
            {
                instance = new HelperDao();
            }
            return instance;
        }


        public DataTable ConsultaSQL(string storeName)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = cnnCadena;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;
                tabla.Load(cmd.ExecuteReader());

            }
            catch (SqlException)
            {
                tabla = null;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return tabla;
        }

        public DataTable ConsultaSQLCarrerasPorAsignatura(string storeName, string asignatura )
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = cnnCadena;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;

                cmd.Parameters.AddWithValue("@nombre", asignatura);

                tabla.Load(cmd.ExecuteReader());

            }
            catch (SqlException)
            {
                tabla = null;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return tabla;
        }

        public DataTable ConsultaSQLAsignaturasPorCarrera(string storeName, string nombre)
        {
            SqlConnection cnn = new SqlConnection();
            SqlCommand cmd = new SqlCommand();
            DataTable tabla = new DataTable();

            try
            {
                cnn.ConnectionString = cnnCadena;
                cnn.Open();
                cmd.Connection = cnn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = storeName;

                string titulo = "s";

                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@titulo", titulo);

                tabla.Load(cmd.ExecuteReader());

            }
            catch (SqlException)
            {
                tabla = null;
            }
            finally
            {
                if (cnn != null && cnn.State == ConnectionState.Open)
                    cnn.Close();

            }
            return tabla;
        }




        public bool InsertarCarrera(Carrera oCarrera, string spMaestro, string spDetalle)
        {

            bool ok = true;

            SqlConnection connection = new SqlConnection(cnnCadena);
            SqlTransaction transaction = null;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction();
                //Se inserta Carrera
                SqlCommand cmdMaestro = new SqlCommand(spMaestro, connection, transaction);
                cmdMaestro.CommandType = CommandType.StoredProcedure;


                //El IdCarrera lo va a poner solo el SP y después sale en el output    

                cmdMaestro.Parameters.AddWithValue("@nombre", oCarrera.Nombre);
                cmdMaestro.Parameters.AddWithValue("@titulo", oCarrera.Titulo);
                cmdMaestro.Parameters.AddWithValue("@id_tipo_carrera", oCarrera.TipoCarrera);

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@id_carrera";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmdMaestro.Parameters.Add(param);
                cmdMaestro.ExecuteNonQuery();

                int idCarrera = (int)param.Value;
                //Se inserta Detalle Receta 
                foreach (DetalleCarrera detalle in oCarrera.Detalles)
                {
                    SqlCommand cmdDetalle = new SqlCommand(spDetalle, connection, transaction);
                    cmdDetalle.CommandType = CommandType.StoredProcedure;
                    cmdDetalle.Parameters.AddWithValue("@id_carrera", idCarrera);
                    cmdDetalle.Parameters.AddWithValue("@id_asignatura", detalle.Asignatura.IdAsignatura);
                    cmdDetalle.Parameters.AddWithValue("@anioCursado", detalle.AnioCursado);
                    cmdDetalle.Parameters.AddWithValue("@id_tipo_cursada", detalle.TipoDeCursado);

                    cmdDetalle.ExecuteNonQuery();
                }

                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                ok = false;

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return ok;


        }

        public bool InsertarAsignatura(Asignatura oAsignatura, string SP)
        {
            bool ok = true;

            if (oAsignatura != null)
            {
                SqlConnection connection = new SqlConnection(cnnCadena);

                connection.Open();

                SqlCommand cmdMaestro = new SqlCommand(SP, connection);
                cmdMaestro.CommandType = CommandType.StoredProcedure;

                cmdMaestro.Parameters.AddWithValue("@nombre", oAsignatura.Nombre);
                cmdMaestro.ExecuteNonQuery();

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }

            }

            else
            {
                ok = false;
            }


            return ok;

        }



        public bool RegistrarUsuario(Usuario oUsuario, string spMaestro)
        {
            bool ok = true;

            SqlConnection connection = new SqlConnection(cnnCadena);
            try
            {
                connection.Open();
                //Se inserta Carrera
                SqlCommand cmdMaestro = new SqlCommand(spMaestro, connection);
                cmdMaestro.CommandType = CommandType.StoredProcedure;


                //El IdCarrera lo va a poner solo el SP y después sale en el output    

                cmdMaestro.Parameters.AddWithValue("@nombre", oUsuario.Nombre);
                cmdMaestro.Parameters.AddWithValue("@email", oUsuario.Email);
                cmdMaestro.Parameters.AddWithValue("@usuario", oUsuario.User);
                cmdMaestro.Parameters.AddWithValue("@contraseña", oUsuario.Contrasenia);



                cmdMaestro.ExecuteNonQuery();
            }
            catch (Exception)
            {
             
                ok = false;

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return ok;


        }

        public bool BorrarUsuario (string usuario, string SP)
        {
            bool ok = true;

            SqlConnection connection = new SqlConnection(cnnCadena);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(SP, connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@usuario", usuario);


                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {

                ok = false;

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return ok;

        }



        public bool Login(string usuario, string contrasenia, string SP)
        {
            bool ok;

            SqlConnection connection = new SqlConnection(cnnCadena);
            try
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(SP, connection);
                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@contraseña", contrasenia);


                SqlParameter param = new SqlParameter();
                param.ParameterName = "@resultado";
                param.SqlDbType = SqlDbType.Int;
                param.Direction = ParameterDirection.Output;

                cmd.Parameters.Add(param);
                cmd.ExecuteNonQuery();
                int resultado = (int)param.Value;

                if (resultado == 1)
                {
                    ok = true;
                }

                else
                {
                    ok = false;
                }

            }
            catch (Exception)
            {

                ok = false;

            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
          

            
            return ok;


        }


    }
}