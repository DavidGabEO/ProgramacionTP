using Carreras_Back.usuarios;
using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.servicios
{
   public interface Iaplicacion
    {

        List<Asignatura> ConsultarAsignaturas();

        List<Carrera> ConsultarCarreras();


        DataTable ConsultarTiposCarreras();

        DataTable ConsultarTiposCursadas();

        DataTable ConsultarTablaAsignaturas();

        DataTable ConsultarCarrerasPorMateria(string asignatura);

        DataTable ConsultarMateriasPorCarrera(string nombre);

        DataTable ConsultarUsuarios();

        bool CrearCarrera(Carrera oCarrera);


        bool ValidarLogin(string usuario, string contrasenia);

        bool InsertarAsignatura(Asignatura oAsignatura);

        bool RegistrarUsuario(Usuario oUsuario);

        bool BorrarUsuario(string usuario);

    }
}
