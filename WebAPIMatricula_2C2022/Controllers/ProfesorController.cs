
using API.Bll.Profesor;
using API.Bll.Profesor.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIMatricula_2C2022.Controllers
{
    [Route("api/v1" + "/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProfesorController : Controller
    {
        private LnProfesor oLnProfesor;

        public ProfesorController(IAdProfesor accesoAdProfesor)
        {
            oLnProfesor = new API.Bll.Profesor.LnProfesor(accesoAdProfesor);
        }

        [HttpPost]
        [Route("AgregarProfesor")]
        public IActionResult AgregarProfesor([FromBody] API.Dto.Profesor.Entrada.AgregarProfesor pDatos)
        {
            API.Dto.Profesor.Salida.AgregarProfesor respuesta =
                new API.Dto.Profesor.Salida.AgregarProfesor();

            try
            {
                respuesta = oLnProfesor.AgregarProfesor(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(ex.Message);
                throw;
            }
        }


        [HttpPost]
        [Authorize]
        [Route("VerTodosProfesores")]
        public IActionResult VerTodosProfesores(API.Dto.Profesor.Entrada.VerTodosProfesores pDatos)
        {
            API.Dto.Profesor.Salida.VerTodosProfesores respuesta = new API.Dto.Profesor.Salida.VerTodosProfesores();

            try
            {
                respuesta = oLnProfesor.VerTodosProfesores(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("EliminarProfesor")]
        public IActionResult EliminarProfesor([FromBody] API.Dto.Profesor.Entrada.EliminarProfesor pDatos)
        {
            API.Dto.Profesor.Salida.EliminarProfesor respuesta = new API.Dto.Profesor.Salida.EliminarProfesor();

            try
            {
                respuesta = oLnProfesor.EliminarProfesor(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("VerDetalleProfesor")]
        public IActionResult VerDetalleProfesor([FromBody] API.Dto.Profesor.Entrada.VerDetalleProfesor pDatos)
        {
            API.Dto.Profesor.Salida.VerDetalleProfesor respuesta = new API.Dto.Profesor.Salida.VerDetalleProfesor();

            try
            {
                respuesta = oLnProfesor.VerDetalleProfesor(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }


        [HttpPost]
        [Route("EditarProfesor")]
        public IActionResult EditarProfesor([FromBody] API.Dto.Profesor.Entrada.EditarProfesor pDatos)
        {
            API.Dto.Profesor.Salida.EditarProfesor respuesta = new API.Dto.Profesor.Salida.EditarProfesor();

            try
            {
                respuesta = oLnProfesor.EditarProfesor(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }








    }

}
