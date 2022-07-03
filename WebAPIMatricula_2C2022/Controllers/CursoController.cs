﻿using API.Bll.Curso;
using API.Bll.Curso.Interfaces;
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
    public class CursoController : Controller
    {
        private LnCurso oLnCurso;

        public CursoController(IAdCurso accesoAdCurso)
        {
            oLnCurso = new API.Bll.Curso.LnCurso(accesoAdCurso);
        }

        [HttpPost]
        [Route("AgregarCurso")]
        public IActionResult AgregarCurso([FromBody] API.Dto.Curso.Entrada.AgregarCurso pDatos)
        {
            API.Dto.Curso.Salida.AgregarCurso respuesta =
                new API.Dto.Curso.Salida.AgregarCurso();

            try
            {
                respuesta = oLnCurso.AgregarCurso(pDatos);
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
        [Route("VerTodosCursos")]
        public IActionResult VerTodosCursos(API.Dto.Curso.Entrada.VerTodosCursos pDatos)
        {
            API.Dto.Curso.Salida.VerTodosCursos respuesta = new API.Dto.Curso.Salida.VerTodosCursos();

            try
            {
                respuesta = oLnCurso.VerTodosCursos(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }


        [HttpPost]
        [Route("EliminarCurso")]
        public IActionResult EliminarCurso([FromBody] API.Dto.Curso.Entrada.EliminarCurso pDatos)
        {
            API.Dto.Curso.Salida.EliminarCurso respuesta = new API.Dto.Curso.Salida.EliminarCurso();

            try
            {
                respuesta = oLnCurso.EliminarCurso(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("VerDetalleCurso")]
        public IActionResult VerDetalleCurso([FromBody] API.Dto.Curso.Entrada.VerDetalleCurso pDatos)
        {
            API.Dto.Curso.Salida.VerDetalleCurso respuesta = new API.Dto.Curso.Salida.VerDetalleCurso();

            try
            {
                respuesta = oLnCurso.VerDetalleCurso(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("EditarCurso")]
        public IActionResult EditarCurso([FromBody] API.Dto.Curso.Entrada.EditarCurso pDatos)
        {
            API.Dto.Curso.Salida.EditarCurso respuesta = new API.Dto.Curso.Salida.EditarCurso();

            try
            {
                respuesta = oLnCurso.EditarCurso(pDatos);
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
