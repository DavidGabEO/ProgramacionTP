using Carreras_Back.usuarios;
using CarrerasBackend.dominio;
using CarrerasBackend.servicios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarrerasWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarrerasController : ControllerBase
    {

        private Iaplicacion app;

        public CarrerasController()
        {
            app = new Aplicacion();
        }

        
        [HttpGet("/asignaturas")]
        public IActionResult GetAsignaturas()
        {
            return Ok(app.ConsultarAsignaturas());
        }

       


        [HttpPost("asignaturas")]
        public IActionResult PostAsignatura(Asignatura oAsignatura)
        {
            if(oAsignatura == null)
            {
                return BadRequest("prueba si es null y le estoy apuntando bien");
            }

            if (app.InsertarAsignatura(oAsignatura))
            {
                return Ok("Ok");
            }
            else
            {
                return Ok("La asignatura no pudo registrarse");
            }
        }



        [HttpGet("/carreras")]
        public IActionResult GetCarreras()
        {
            return Ok(app.ConsultarCarreras());
        }


        [HttpPost]
        public IActionResult PostCarrera(Carrera oCarrera)
        {

            if (oCarrera == null)
            {
                return BadRequest();
            }


            if (app.CrearCarrera(oCarrera))
            {
                return Ok("Ok");
            }

            else
            {
                return Ok("No se pudo registrar la carrera");
            }

        }

        [HttpPost("Usuario")]
        public IActionResult PostUsuario(Usuario oUsuario) { 
        
        if(oUsuario == null)
            {
                return BadRequest();
            }

            if (app.RegistrarUsuario(oUsuario))
            {
                return Ok("Ok");
            }

            else
            {
                return Ok("No se pudo registrar al usuario");
            }


        
        }
       // [Route("api/YOURCONTROLLER/{paramOne}/{paramTwo}")]
        [HttpGet("Login/{usuario}/{contrasenia}")]
        public IActionResult LoginUsuario(string usuario, string contrasenia) {

            if(app.ValidarLogin(usuario, contrasenia))
            {
                return Ok("Ok");
            }

            else
            {
                return BadRequest("Incorrecto"); 
            }

        }

    }
}
