﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using static CapaEntidad.Contrato;

namespace CapaDatos
{
    public class datContrato
    {
        private static readonly datContrato _instancia = new datContrato();

        public static datContrato Instancia
        {
            get { return datContrato._instancia; }
        }

        // Método para listar los contratos
        public List<entContrato> ListarContrato()
        {
            List<entContrato> lista = new List<entContrato>();
            SqlCommand cmd = null;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_CONTRATOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entContrato con = new entContrato();
                    con.id_cliente = Convert.ToInt32(dr["ClienteID"]);
                    con.fechaInicio = Convert.ToDateTime(dr["fechainicio"]);
                    con.estado = dr["estado"].ToString();
                    con.id_servicio = Convert.ToInt32(dr["PlanDeServicioID"]);
                    con.duracion = Convert.ToInt32(dr["duración"]);
                    lista.Add(con);
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return lista;
        }

        // Método para añadir un contrato
        public Boolean InsertarContrato(entContrato contrato)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_AÑADIR_CONTRATO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCliente", contrato.id_cliente);
                cmd.Parameters.AddWithValue("@fechaInicio", contrato.fechaInicio);
                cmd.Parameters.AddWithValue("@Estado", contrato.estado);
                cmd.Parameters.AddWithValue("@tipoPlan", contrato.id_servicio);
                cmd.Parameters.AddWithValue("@duracion", contrato.duracion);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    inserto = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return inserto;
        }

        // Método para modificar un contrato
        //public Boolean ModificarContrato(entContrato contrato)
        //{
        //    SqlCommand cmd = null;
        //    Boolean modifico = false;

        //    try
        //    {
        //        SqlConnection cn = Conexion.Instancia.Conectar();
        //        cmd = new SqlCommand("SP_EDITAR_CONTRATO", cn);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.Parameters.AddWithValue("@clienteid", contrato.nombre_cliente);
        //        cmd.Parameters.AddWithValue("@estado", contrato.estado);
        //        cmd.Parameters.AddWithValue("@tipoPlan", contrato.tipo_plan);
        //        cmd.Parameters.AddWithValue("@duracion", contrato.duracion);
        //        cn.Open();
        //        int i = cmd.ExecuteNonQuery();
        //        if (i > 0)
        //        {
        //            modifico = true;
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        cmd.Connection.Close();
        //    }
        //    return modifico;
        //}

        // Método para anular un contrato
        public Boolean AnularContrato(entContrato contrato)
        {
            SqlCommand cmd = null;
            Boolean anulo = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_ANULAR_CONTRATO", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombreCliente", contrato.id_cliente);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    anulo = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection.Close();
            }
            return anulo;
        }
    }
}
