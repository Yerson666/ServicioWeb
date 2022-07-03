using API.Bll.ModalidadCurso.Interfaces;
using API.Dal.General;
using API.Dto.General;
using API.Dto.ModalidadCurso.Salida;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dal.ModalidadCurso
{
    public class AdModalidadCurso : IAdModalidadCurso
    {
        private ConexionManager manager;

        public AdModalidadCurso(IOptions<AppSettings> oConfiguraciones)
        {

            manager = new ConexionManager(oConfiguraciones);
        }


        public Dto.ModalidadCurso.Salida.VerTodosModalidadCursos VerTodosModalidadCursos()
        {
            IDbConnection oConexion = null;
            API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos resultado = new API.Dto.ModalidadCurso.Salida.VerTodosModalidadCursos();

            oConexion = manager.GetConexion();
            oConexion.Open();
            IDbCommand oComando = manager.GetComando();

            try
            {
                IDataReader objDr = manager.GetDataReader(oComando, oConexion, "dbo.Ver_Todos_ModalidadCursos");

                DatosModalidadCurso dato;

                while (objDr.Read())
                {
                    dato = new DatosModalidadCurso();
                    dato.Codigo = Convert.ToInt32(objDr["Codigo"].ToString());
                    dato.TipoModal = objDr["TipoModal"].ToString();
                    dato.Duracion = objDr["Duracion"].ToString();
                    dato.Grado = objDr["Grado"].ToString();
                    dato.NumModal = objDr["NumModal"].ToString();

                    resultado.ListaModalidadCursos.Add(dato);
                }
            }
            catch (Exception)
            {
                manager.CerrarConexion(oConexion);
            }
            finally
            {
                manager.CerrarConexion(oConexion);
            }

            return resultado;
        }

        public Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso VerDetalleModalidadCurso(Dto.ModalidadCurso.Entrada.VerDetalleModalidadCurso pInformacion)
        {
            IDbConnection oConexion = null;
            API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso resultado = new API.Dto.ModalidadCurso.Salida.VerDetalleModalidadCurso();

            oConexion = manager.GetConexion();
            oConexion.Open();
            IDbCommand oComando = manager.GetComando();

            try
            {
                oComando.Parameters.Add(manager.GetParametro("@Codigo", pInformacion.Codigo));
                IDataReader objDr = manager.GetDataReader(oComando, oConexion, "dbo.Ver_Detalle_ModalidadCurso");

                if (objDr.Read())
                {
                    resultado.Codigo = Convert.ToInt32(objDr["Codigo"].ToString());
                    resultado.TipoModal = objDr["TipoModal"].ToString();
                    resultado.Duracion = objDr["Duracion"].ToString();
                    resultado.Grado = objDr["Grado"].ToString();
                    resultado.NumModal = objDr["NumModal"].ToString();
                }
            }
            catch (Exception)
            {
                manager.CerrarConexion(oConexion);
            }
            finally
            {
                manager.CerrarConexion(oConexion);
            }

            return resultado;
        }


        public Dto.ModalidadCurso.Salida.EditarModalidadCurso EditarModalidadCurso(Dto.ModalidadCurso.Entrada.EditarModalidadCurso pInformacion)
        {
            IDbConnection oConexion = null;
            IDbCommand oComando = manager.GetComando();
            Dto.ModalidadCurso.Salida.EditarModalidadCurso resultado = new Dto.ModalidadCurso.Salida.EditarModalidadCurso();

            try
            {
                oConexion = manager.GetConexion();
                oConexion.Open();

                oComando.Parameters.Add(manager.GetParametro("@Codigo", pInformacion.Codigo));
                oComando.Parameters.Add(manager.GetParametro("@TipoModal", pInformacion.TipoModal));
                oComando.Parameters.Add(manager.GetParametro("@Duracion", pInformacion.Duracion));
                oComando.Parameters.Add(manager.GetParametro("@Grado", pInformacion.Grado));
                oComando.Parameters.Add(manager.GetParametro("@NumModal", pInformacion.NumModal));

                IDataReader objDr = manager.GetDataReader(oComando, oConexion, "dbo.Editar_ModalidadCurso");

                if (objDr.Read())
                {
                    resultado.Codigo = Convert.ToInt32(objDr["Codigo"].ToString());
                    resultado.TipoModal = objDr["TipoModal"].ToString();
                    resultado.Duracion = objDr["Duracion"].ToString();
                    resultado.Grado = objDr["Grado"].ToString();
                    resultado.NumModal = objDr["NumModal"].ToString();
                }

            }
            catch (Exception ex)
            {
                resultado.DetalleRespuesta = ex.Message;
                manager.CerrarConexion(oConexion);
            }
            finally
            {
                manager.CerrarConexion(oConexion);
            }

            return resultado;
        }


        public Dto.ModalidadCurso.Salida.AgregarModalidadCurso AgregarModalidadCurso(Dto.ModalidadCurso.Entrada.AgregarModalidadCurso pInformacion)
        {
            IDbConnection oConexion = null;
            IDbCommand oComando = manager.GetComando();
            Dto.ModalidadCurso.Salida.AgregarModalidadCurso resultado = new Dto.ModalidadCurso.Salida.AgregarModalidadCurso();

            try
            {
                oConexion = manager.GetConexion();
                oConexion.Open();

                oComando.Parameters.Add(manager.GetParametro("@TipoModal", pInformacion.TipoModal));
                oComando.Parameters.Add(manager.GetParametro("@Duracion", pInformacion.Duracion));
                oComando.Parameters.Add(manager.GetParametro("@Grado", pInformacion.Grado));
                oComando.Parameters.Add(manager.GetParametro("@NumModal", pInformacion.NumModal));

                IDataReader objDr = manager.GetDataReader(oComando, oConexion, "dbo.Agregar_ModalidadCurso");

                if (objDr.Read())
                    resultado.Codigo = Convert.ToInt32(objDr["Codigo"].ToString());

            }
            catch (Exception ex)
            {
                resultado.DetalleRespuesta = ex.Message;
                manager.CerrarConexion(oConexion);
            }
            finally
            {
                manager.CerrarConexion(oConexion);
            }

            return resultado;
        }


        public Dto.ModalidadCurso.Salida.EliminarModalidadCurso EliminarModalidadCurso(Dto.ModalidadCurso.Entrada.EliminarModalidadCurso pInformacion)
        {
            IDbConnection oConexion = null;
            IDbCommand oComando = manager.GetComando();
            Dto.ModalidadCurso.Salida.EliminarModalidadCurso resultado = new Dto.ModalidadCurso.Salida.EliminarModalidadCurso();

            try
            {
                oConexion = manager.GetConexion();
                oConexion.Open();

                oComando.Parameters.Add(manager.GetParametro("@Codigo", pInformacion.Codigo));

                IDataReader objDr = manager.GetDataReader(oComando, oConexion, "dbo.Eliminar_ModalidadCurso");
            }
            catch (Exception ex)
            {
                resultado.DetalleRespuesta = ex.Message;
                manager.CerrarConexion(oConexion);
            }
            finally
            {
                manager.CerrarConexion(oConexion);
            }

            return resultado;
        }

    }
}
