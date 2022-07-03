﻿using API.Dto.General;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API.Dal.General
{
    public class ConexionManager
    {
        protected int Timeout = 60;
        protected string BaseDatos = string.Empty;



        public ConexionManager(IOptions<AppSettings> config)
        {
            //string connectionStringEncriptado = Encriptador.Encriptar("Server=L019010;Database=MatriculaULACIT_1C2022;Trusted_Connection=True;");
            //string connectionStringEncriptado = Encriptador.Encriptar("Server=tcp:server.database.windows.net,1433;Database=NombreBD;User ID=usuario@dominio.com@server;Password=Hola123*;Trusted_Connection=False;Encrypt=True;");


            //Constructor de String de base de datos.
            BaseDatos = Encriptador.Desencriptar(config.Value.BaseDatos);
        }


        //Crea una conexion llamando el string de la BD
        public IDbConnection GetConexion()
        {
            return new SqlConnection(BaseDatos);
        }


        //Llamar a un metodo almacenado y devolverlo, lo usamos en DAL
        public IDbCommand GetComando(bool RequiereProcedimientoAlmacenado = true)
        {
            SqlCommand sqlcm = new SqlCommand();



            if (RequiereProcedimientoAlmacenado)
                sqlcm.CommandType = CommandType.StoredProcedure;



            sqlcm.CommandTimeout = Timeout;
            return sqlcm;
        }


        //Llama procedimiento almacenado como todos los estudiantes y detalle estudiantes
        public IDataReader GetDataReader(IDbCommand comando, IDbConnection conexion, string nombreProcedimientoAlmacenado)
        {
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandText = nombreProcedimientoAlmacenado;
            comando.Connection = conexion;



            try
            {
                return comando.ExecuteReader();
            }
            catch (SqlException)
            {
                CerrarConexion(conexion);
                throw;
            }
            
        }



        public void CerrarConexion(IDbConnection oConexion)
        {
            if (oConexion != null)
                if (oConexion.State == ConnectionState.Open)
                    oConexion.Close();
        }


        //Obetiene parametros
        public IDataParameter GetParametro(string oParametro, object oValor)
        {
            return new SqlParameter(oParametro, oValor);
        }



        public IDataParameter GetParametroOutPutApi(string parametro, DbType tipo, int tamano)
        {
            var oParametro = new SqlParameter(parametro, tipo) { Direction = ParameterDirection.Input, DbType = tipo };



            if (tamano != 0)
                oParametro.Size = tamano;



            return oParametro;
        }

    }
}
