using Carreras_Back.usuarios;
using CarrerasBackend.dominio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrerasBackend.datos
{
    interface ICarreraDao
    {

        List<Asignatura> GetAsignaturas();

        List<Carrera> GetCarreras();

       
        DataTable GetTiposCarreras();  //Para cargar combo

        DataTable GetTiposCursadas(); //Para cargar combo

        DataTable GetTablaAsignaturas(); //Para dgv que muestra asignaturas;

        DataTable GetCarrerasPorMateria(string asignatura);

        DataTable GetMateriasPorCarrera(string nombre);

        DataTable GetUsuarios();

        int GetIdCarrera(string nombre);

        bool Save(Carrera oCarrera);

        bool SaveAsignatura(Asignatura oAsignatura);


        bool DeleteUsuario(string usuario);

        bool DeleteUnDetalle(int idAsignatura);

        bool DeleteAsignaturaYDetalle(int idAsignatura);

        bool DeleteCarreraYDetalles(int idCarrera);


        //Login
        bool GetLogin(string usuario, string contrasenia);  //Loguearse

      
        bool SaveUsuario(Usuario oUsuario);   //Registrar nuevo usuario

        bool SaveSoloDetalle(DetalleCarrera detalle, int idCarrera, int idAsignatura);
    }
}
