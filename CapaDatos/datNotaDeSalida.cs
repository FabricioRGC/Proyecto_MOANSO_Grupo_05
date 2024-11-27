﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;
using static CapaEntidad.NotaDeSalida;

namespace CapaDatos
{
    public class datNotaDeSalida
    {
        public static readonly datNotaDeSalida _instancia = new datNotaDeSalida();

        public static datNotaDeSalida Instancia
        {
            get { return datNotaDeSalida._instancia; }
        }
        public List<entNotadesalida> ListarNotadeSalida()
        {

            SqlCommand cmd = null;
            List<entNotadesalida> lista = new List<entNotadesalida>();
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_MOSTRAR_NOTADESALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    entNotadesalida mat = new entNotadesalida();
                    mat.NotadeSalidaID = int.Parse(dr["NotaDeSalidaID"].ToString());
                    mat.PedidiMaterialesID = int.Parse(dr["PedidoMaterialesID"].ToString());
                    mat.PedidiRepuestosID = int.Parse(dr["PedidoDeRepuestosID"].ToString());
                    mat.FechadeEmision = Convert.ToDateTime(dr["FechaEmisión"]);
                    mat.Estado = int.Parse(dr["Estado"].ToString());
                    mat.MaterialID = int.Parse(dr["RepuestosID"].ToString());
                    mat.RepuestoID = int.Parse(dr["MaterialID"].ToString());

                    lista.Add(mat);
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
            return lista;


        }
        //Metodo para añadir un mateial
        public Boolean InsertarNotaSalidaMateriales(entNotadesalida nota)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_NOTADESALIDAMATERIALES", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechadeEmision", nota.FechadeEmision);
                cmd.Parameters.AddWithValue("@PedidiMaterialesID", nota.PedidiMaterialesID);
                cmd.Parameters.AddWithValue("@Estado", nota.Estado);
                cmd.Parameters.AddWithValue("@MaterialID", nota.MaterialID);
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

        public Boolean InsertarNotaSalidaRepuestos(entNotadesalida nota)
        {
            SqlCommand cmd = null;
            Boolean inserto = false;

            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_REGISTRAR_NOTADESALIDAREPUESTOS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@FechadeEmision", nota.FechadeEmision);
                cmd.Parameters.AddWithValue("@PedidiRepuestosID", nota.PedidiRepuestosID);
                cmd.Parameters.AddWithValue("@Estado", nota.Estado);
                cmd.Parameters.AddWithValue("@RepuestosID", nota.RepuestoID);
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


        // Metodo para inhabilitar
        public Boolean DeshabilitarNotadeSalida(entNotadesalida mat)
        {
            SqlCommand cmd = null;
            Boolean deshabilito = false;
            try
            {
                SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("SP_DESHABILITAR_NOTADESALIDA", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NotadeSalidaID", mat.NotadeSalidaID);

                cn.Open();
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    deshabilito = true;
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
            return deshabilito;
        }
    }
}
