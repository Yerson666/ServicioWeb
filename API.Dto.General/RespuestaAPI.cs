﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dto.General

{
    //Maneja codigo de errores y si la transacción fue exitosa o no
   public class RespuestaAPI
   {
        protected const int CODIGO_ERROR = -1;
        protected const int CODIGO_EXITOSO = 0;



        protected const string TRANSACCION_EXITOSA = "Transacción exitosa";
        protected const string ERROR_APLICACION = "Ocurrió un error la aplicación";



        public int CodigoRespuesta { get; set; }
        public String DetalleRespuesta { get; set; }
        public String DetalleTecnico { get; set; }


        //Constructor
        public  RespuestaAPI()
        {
            this.CodigoRespuesta = CODIGO_EXITOSO;
            this.DetalleRespuesta = TRANSACCION_EXITOSA;
            this.DetalleTecnico = string.Empty;
        }



        public void SetErrorComunicacion(String error)
        {
            this.CodigoRespuesta = CODIGO_ERROR;
            this.DetalleRespuesta = ERROR_APLICACION;
            this.DetalleTecnico = error;
        }

    }



}