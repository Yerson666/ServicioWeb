using API.Bll.ModalidadCurso.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Bll.ModalidadCurso
{
    public class LnModalidadCurso
    {
        private IAdModalidadCurso adModalidadCurso;


        //Creamos el constructor, que recibe la insterfaz
        public LnModalidadCurso(IAdModalidadCurso accesoDatosModalidadCurso)
        {
            this.adModalidadCurso = accesoDatosModalidadCurso;
        }

        public API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos VerTodosModalidadCursos(Dto.ModalidadCurso.Entrada.VerTodosModalidadCursos pInformacion)
        {
            //Tenemosla recupuesta de ver ModalidadCurso
            API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos respuesta = new API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos();

            try
            {
                respuesta = adModalidadCurso.VerTodosModalidadCursos();
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message.ToString());
            }



            return respuesta;
        }

        public Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso VerDetalleModalidadCurso(Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso pInformacion)
        {
            API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso respuesta = new Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso();



            try
            {
                respuesta = adModalidadCurso.VerDetalleModalidadCurso(pInformacion);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message.ToString());
            }



            return respuesta;
        }

        public API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso AgregarModalidadCurso(Dto.ModalidadCurso.Entrada.AgregarModalidadCurso pInformacion)
        {
            API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso respuesta = new API.Dto.ModalidadCurso.Salida.AgregarModalidadCurso();



            try
            {
                respuesta = adModalidadCurso.AgregarModalidadCurso(pInformacion);
            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message.ToString());
            }



            return respuesta;
        }



        public Dto.ModalidadCurso.Salida.EditarModalidadCurso EditarModalidadCurso(Dto.ModalidadCurso.Entrada.EditarModalidadCurso pInformacion)
        {
            API.Dto.ModalidadCurso.Salida.EditarModalidadCurso respuesta = new API.Dto.ModalidadCurso.Salida.EditarModalidadCurso();



            try
            {
                API.Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso entradaVerDetalleModalidadCurso = new API.Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso();
                entradaVerDetalleModalidadCurso.Codigo = pInformacion.Codigo;
                API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso detalleTrader = adModalidadCurso.VerDetalleModalidadCurso(entradaVerDetalleModalidadCurso);



                respuesta = adModalidadCurso.EditarModalidadCurso(pInformacion);



            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message.ToString());
            }



            return respuesta;
        }


        public Dto.ModalidadCurso.Salida.EliminarModalidadCurso EliminarModalidadCurso(Dto.ModalidadCurso.Entrada.EliminarModalidadCurso pInformacion)
        {
            API.Dto.ModalidadCurso.Salida.EliminarModalidadCurso respuesta = new Dto.ModalidadCurso.Salida.EliminarModalidadCurso();



            try
            {
                respuesta = adModalidadCurso.EliminarModalidadCurso(pInformacion);



            }
            catch (Exception ex)
            {
                respuesta.SetErrorComunicacion(ex.Message.ToString());
            }



            return respuesta;
        }









    }
}
