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

        bool Save(Carrera oCarrera);

        bool SaveAsignatura(Asignatura oAsignatura);


        bool DeleteUsuario(string usuario);


        //Login
        bool GetLogin(string usuario, string contrasenia);  //Loguearse

      
        bool SaveUsuario(Usuario oUsuario);   //Registrar nuevo usuario

    }
}
