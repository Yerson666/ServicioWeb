using API.Bll.ModalidadCurso;
using API.Bll.ModalidadCurso.Interfaces;
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
    [Authorize]
    public class ModalidadCursoController : Controller
    {
        private LnModalidadCurso oLnModalidadCurso;

        public ModalidadCursoController(IAdModalidadCurso accesoAdModalidadCurso)
        {
            oLnModalidadCurso = new API.Bll.ModalidadCurso.LnModalidadCurso(accesoAdModalidadCurso);
        }

        [HttpPost]
        [Route("AgregarModalidadCurso")]
        public IActionResult AgregarModalidadCurso([FromBody] API.Dto.ModalidadCurso.Entrada.AgregarModalidadCurso pDatos)
        {
            API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso respuesta =
                new API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso();

            try
            {
                respuesta = oLnModalidadCurso.AgregarModalidadCurso(pDatos);
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
        [Route("VerTodosModalidadCursos")]
        public IActionResult VerTodosModalidadCursos(API.Dto.ModalidadCurso.Entrada.VerTodosModalidadCursos pDatos)
        {
            API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos respuesta = new API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos();

            try
            {
                respuesta = oLnModalidadCurso.VerTodosModalidadCursos(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("EliminarModalidadCurso")]
        public IActionResult EliminarModalidadCurso([FromBody] API.Dto.ModalidadCurso.Entrada.EliminarModalidadCurso pDatos)
        {
            API.Dto.ModalidadCurso.Salida.EliminarModalidadCurso respuesta = new API.Dto.ModalidadCurso.Salida.EliminarModalidadCurso();

            try
            {
                respuesta = oLnModalidadCurso.EliminarModalidadCurso(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("VerDetalleModalidadCurso")]
        public IActionResult VerDetalleModalidadCurso([FromBody] API.Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso pDatos)
        {
            API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso respuesta = new API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso();

            try
            {
                respuesta = oLnModalidadCurso.VerDetalleModalidadCurso(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }


        [HttpPost]
        [Route("EditarModalidadCurso")]
        public IActionResult EditarModalidadCurso([FromBody] API.Dto.ModalidadCurso.Entrada.EditarModalidadCurso pDatos)
        {
            API.Dto.ModalidadCurso.Salida.EditarModalidadCurso respuesta = new API.Dto.ModalidadCurso.Salida.EditarModalidadCurso();

            try
            {
                respuesta = oLnModalidadCurso.EditarModalidadCurso(pDatos);
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
