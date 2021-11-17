using Carreras_Back.usuarios;
using CarrerasBackend.datos;
using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.servicios
{
    public class Aplicacion : Iaplicacion
    {
        private ICarreraDao dao;

        public Aplicacion()
        {
            dao = new CarreraDao();
        }

        public List<Asignatura> ConsultarAsignaturas()
        {
            return dao.GetAsignaturas();
        }

        public List<Carrera> ConsultarCarreras()
        {
            return dao.GetCarreras();
        }

        public DataTable ConsultarTiposCarreras() //Esto lo vamos a cargar directo en el formulario
        {                                         //Si lo tratamos de pasar por la web api explota todo.
            return dao.GetTiposCarreras();
        }

        public DataTable ConsultarTiposCursadas() //Lo mismo que arriba. Al ser DataTable y no Json explota todo 
        {
            return dao.GetTiposCursadas();
        }

        public DataTable ConsultarTablaAsignaturas()
        {
            return dao.GetTablaAsignaturas();
        }


        public DataTable ConsultarCarrerasPorMateria(string asignatura)
        {
            return dao.GetCarrerasPorMateria(asignatura);

        }

        public bool CrearCarrera(Carrera oCarrera)
        {
            return dao.Save(oCarrera);
        }

        public bool InsertarAsignatura(Asignatura oAsignatura)
        {
            return dao.SaveAsignatura(oAsignatura);
        }

        public bool RegistrarUsuario(Usuario oUsuario)
        {
            return dao.SaveUsuario(oUsuario);
        }

        public bool ValidarLogin(string usuario, string contrasenia)
        {
            return dao.GetLogin(usuario, contrasenia);
        }

        public DataTable ConsultarMateriasPorCarrera(string nombre)
        {
            return dao.GetMateriasPorCarrera(nombre);
        }

        public DataTable ConsultarUsuarios()
        {
            return dao.GetUsuarios();
        }

        public bool BorrarUsuario(string usuario)
        {
            return dao.DeleteUsuario(usuario);
        }

        public int ConseguirIdCarrera(string nombre)
        {
            return dao.GetIdCarrera(nombre);
        }

        public bool InsertarSoloDetalle(DetalleCarrera detalle, int idCarrera, int idAsignatura)
        {
            return dao.SaveSoloDetalle(detalle, idCarrera, idAsignatura);
        }

        public bool BorrarUnDetalle(int idAsignatura)
        {
            return dao.DeleteUnDetalle(idAsignatura);
        }

        public bool BorrarAsignaturaYDetalles(int idAsignatura)
        {
            return dao.DeleteAsignaturaYDetalle(idAsignatura);
        }

        public bool BorrarCarreraYDetalle(int idCarrera)
        {
            return dao.DeleteCarreraYDetalles(idCarrera);
        }
    }
}
