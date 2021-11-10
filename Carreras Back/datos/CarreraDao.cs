using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Carreras_Back.usuarios;

namespace CarrerasBackend.datos
{
    class CarreraDao : ICarreraDao
    {
        public List<Asignatura> GetAsignaturas() //Mapear columnas del registro como propierties del objeto 
        {
            List<Asignatura> lst = new List<Asignatura>();
            DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_ASIGNATURAS");

            foreach (DataRow row in t.Rows)
            {
                Asignatura oAsignatura = new Asignatura();
                oAsignatura.IdAsignatura = Convert.ToInt32(row[0].ToString());
                oAsignatura.Nombre = row[1].ToString();
               

                lst.Add(oAsignatura);
            }

            return lst;
        }

        public List<Carrera> GetCarreras()
        {
            List<Carrera> lst = new List<Carrera>();
            DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_CARRERAS");

            foreach(DataRow row in t.Rows)
            {
                Carrera oCarrera = new Carrera();
                oCarrera.IdCarrera = Convert.ToInt32(row[0].ToString());
                oCarrera.Nombre = row[1].ToString();
                oCarrera.Titulo = row[2].ToString();
                oCarrera.TipoCarrera = Convert.ToInt32(row[3].ToString());

                lst.Add(oCarrera);

            }

            return lst;


        }


        public DataTable GetTiposCarreras()
        {
           DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_TIPOS_CARRERAS");

            return t;
        }

        public DataTable GetTiposCursadas()
        {
            DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_TIPOS_CURSADAS");

            return t;
        }

        public DataTable GetCarrerasPorMateria(string asignatura)
        {
            DataTable t = HelperDao.GetInstance().ConsultaSQLCarrerasPorAsignatura("SP_CARRERAS_POR_MATERIA", asignatura);

            return t;
        }

        public DataTable GetMateriasPorCarrera(string nombre)
        {
            DataTable t = HelperDao.GetInstance().ConsultaSQLAsignaturasPorCarrera("SP_MATERIAS_POR_CARRERA", nombre);

            return t;
        }

        public DataTable GetUsuarios()
        {
            DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_USUARIOS");
            return t;
        }



        public bool Save(Carrera oCarrera)
        {
            return HelperDao.GetInstance().InsertarCarrera(oCarrera, "SP_INSERTAR_CARRERA", "SP_INSERTAR_DETALLESCARRERAS");

           }

        public bool SaveAsignatura(Asignatura oAsignatura)
        {
            return HelperDao.GetInstance().InsertarAsignatura(oAsignatura, "SP_INSERTAR_ASIGNATURA");
        }

        public bool SaveUsuario(Usuario oUsuario)
        {
            return HelperDao.GetInstance().RegistrarUsuario(oUsuario, "SP_NUEVO_USUARIO");
        }

        public bool GetLogin(string usuario, string contrasenia)
        {
            return HelperDao.GetInstance().Login(usuario, contrasenia, "SP_LOGIN_USUARIO");
        }

        public DataTable GetTablaAsignaturas()
        {
            DataTable t = HelperDao.GetInstance().ConsultaSQL("SP_CONSULTAR_ASIGNATURAS");
            return t;
        }

        public bool DeleteUsuario(string usuario)
        {
            return HelperDao.GetInstance().BorrarUsuario(usuario, "SP_BORRAR_USUARIO");
        }
    }
}
