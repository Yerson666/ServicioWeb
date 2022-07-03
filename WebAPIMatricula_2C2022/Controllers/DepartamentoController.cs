﻿using API.Bll.Departamento;
using API.Bll.Departamento.Interfaces;
using API.Bll.Estudiante.Interfaces;
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
    public class DepartamentoController : Controller
    {
        private LnDepartamento oLnDepartamento;

        public DepartamentoController(IAdDepartamento accesoAdDepartamento)
        {
            oLnDepartamento = new API.Bll.Departamento.LnDepartamento(accesoAdDepartamento);
        }

        [HttpPost]
        [Route("AgregarDepartamento")]
        public IActionResult AgregarDepartamento([FromBody] API.Dto.Departamento.Entrada.AgregarDepartamento pDatos)
        {
            API.Dto.Departamento.Salida.AgregarDepartamento respuesta =
                new API.Dto.Departamento.Salida.AgregarDepartamento();

            try
            {
                respuesta = oLnDepartamento.AgregarDepartamento(pDatos);
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
        [Route("VerTodosDepartamentos")]
        public IActionResult VerTodosDepartamentos(API.Dto.Departamento.Entrada.VerTodosDepartamentos pDatos)
        {
            API.Dto.Departamento.Salida.VerTodosDepartamentos respuesta = new API.Dto.Departamento.Salida.VerTodosDepartamentos();

            try
            {
                respuesta = oLnDepartamento.VerTodosDepartamentos(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }

        [HttpPost]
        [Route("EliminarDepartamento")]
        public IActionResult EliminarDepartamento([FromBody] API.Dto.Departamento.Entrada.EliminarDepartamento pDatos)
        {
            API.Dto.Departamento.Salida.EliminarDepartamento respuesta = new API.Dto.Departamento.Salida.EliminarDepartamento();

            try
            {
                respuesta = oLnDepartamento.EliminarDepartamento(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }


        [HttpPost]
        [Route("VerDetalleDepartamento")]
        public IActionResult VerDetalleDepartamento([FromBody] API.Dto.Departamento.Entrada.VerDetalleDepartamento pDatos)
        {
            API.Dto.Departamento.Salida.VerDetalleDepartamento respuesta = new API.Dto.Departamento.Salida.VerDetalleDepartamento();

            try
            {
                respuesta = oLnDepartamento.VerDetalleDepartamento(pDatos);
                return Ok(respuesta);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message);
                return Ok(respuesta);
            }
        }


        [HttpPost]
        [Route("EditarDepartamento")]
        public IActionResult EditarDepartamento([FromBody] API.Dto.Departamento.Entrada.EditarDepartamento pDatos)
        {
            API.Dto.Departamento.Salida.EditarDepartamento respuesta = new API.Dto.Departamento.Salida.EditarDepartamento();

            try
            {
                respuesta = oLnDepartamento.EditarDepartamento(pDatos);
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
