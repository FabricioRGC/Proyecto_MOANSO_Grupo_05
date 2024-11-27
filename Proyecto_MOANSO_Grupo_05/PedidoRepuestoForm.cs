﻿using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using static CapaEntidad.PedidoRepuestos;
using static CapaEntidad.PedidoMateriales;
using CapaDatos;
using System.Data.SqlClient;
using static CapaEntidad.Repuesto;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PedidoRepuestoForm : Form
    { 
        public PedidoRepuestoForm()
        {
            InitializeComponent();
            ListarPedidosRepuesto();
            cargarRepuestos();
            cargarPersonalTecnico();
        }

        public void ListarPedidosRepuesto()
        {
            dataGridRepuestos.DataSource = logPedidoRepuestos.Instancia.ListarPedidosRepuestos();
        }

        private bool cargandoRepuestos = false;

        private void cargarRepuestos()
        {
            string consulta = "SELECT RepuestosID, NombreRepuesto FROM Repuestos";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                try
                {
                    cn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cboNomRepuestos.DataSource = dt;
                    cboNomRepuestos.DisplayMember = "NombreRepuesto"; // Lo que se mostrará al usuario
                    cboNomRepuestos.ValueMember = "RepuestosID";      // El valor real (ID)
                    cboNomRepuestos.SelectedIndex = -1;              // Sin selección inicial
                    cargandoRepuestos = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar repuestos: " + ex.Message);
                }
            }
        }


        private bool cargandoDatos = false;

        private void cargarPersonalTecnico()
        {
            string consulta = "SELECT PersonalID, Nombre FROM Personal WHERE Cargo = @Cargo";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cmd.Parameters.AddWithValue("@Cargo", "Jefe de soporte tecnico");
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                cargandoDatos = true; // Bandera activada
                cn.Open();
                adapter.Fill(dt);

                cboTecnicoAsignado.DataSource = dt;
                cboTecnicoAsignado.DisplayMember = "Nombre";
                cboTecnicoAsignado.ValueMember = "PersonalID";
                cboTecnicoAsignado.SelectedIndex = -1; // Ningún elemento seleccionado inicialmente
                cargandoDatos = false; // Bandera desactivada
            }
        }



        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar si los campos están vacíos
                if (string.IsNullOrWhiteSpace(txtStockPedidoRep.Text))
                {
                    MessageBox.Show("Por favor, ingrese el stock del repuesto.");
                    return;
                }


                if (dtpFechaRealizacion.Value == null || dtpFechaRealizacion.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de realización.");
                    return;
                }

                if (dtpFechaEntrega.Value == null || dtpFechaEntrega.Value == DateTime.MinValue)
                {
                    MessageBox.Show("Por favor, seleccione la fecha de entrega.");
                    return;
                }

                // Crear el objeto PedidoRepuesto y asignar los valores
                entPedidoRepuestos PedidoRepuesto = new entPedidoRepuestos
                {
               
                    Estado = "Pendiente", // Estado fijo como "Pendiente"
                    FechaRealizacion = dtpFechaRealizacion.Value,
                    FechaEntrega = dtpFechaEntrega.Value,
                    RepuestosID = Convert.ToInt32(cboNomRepuestos.SelectedValue),
                    PersonalID = Convert.ToInt32(cboTecnicoAsignado.SelectedValue)
                };

                // Insertar el Pedido de Repuesto
                logPedidoRepuestos.Instancia.InsertarPedidoRepuesto(PedidoRepuesto);
                MessageBox.Show("Pedido Repuesto insertado correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar el Pedido Repuesto: " + ex.Message);
            }
            finally
            {
                ListarPedidosRepuesto();
            }
        }


        private void cboRepuestos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Evitar lógica si estamos cargando datos o no hay selección válida
            if (cargandoRepuestos || cboNomRepuestos.SelectedIndex == -1)
                return;

            if (cboNomRepuestos.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un repuesto válido.");
                return;
            }

            int repuestoID;

            string repuestoSeleccionado = cboNomRepuestos.SelectedItem.ToString();

            try
            {
                if (int.TryParse(cboNomRepuestos.SelectedValue.ToString(), out repuestoID))
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = @"
                    SELECT 
                        r.CódigoRepuesto, 
                        r.Stock, 
                        c.CategoriaRepuesto
                    FROM 
                        Repuestos r
                    INNER JOIN 
                        CategoriaRepuesto c ON r.CategoriaRepuestoID = c.CategoriaRepuestoID
                    WHERE 
                        r.NombreRepuesto = @NombreRepuesto";

                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@NombreRepuesto", repuestoSeleccionado);

                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            CodigoRepuesto.Text = reader["CódigoRepuesto"].ToString();
                            stockRepuesto.Text = reader["Stock"].ToString();
                            labelCategoriaID.Text = reader["CategoriaRepuesto"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró información para el repuesto seleccionado.");
                        }
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void cboTecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No hacer nada si estamos cargando datos
            if (cargandoDatos || cboTecnicoAsignado.SelectedIndex == -1)
                return;

            // Asegúrate de que hay un valor seleccionado
            if (cboTecnicoAsignado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un técnico válido.");
                return;
            }

            int personalID;
            try
            {
                // Verifica y convierte correctamente el valor seleccionado
                if (int.TryParse(cboTecnicoAsignado.SelectedValue.ToString(), out personalID))
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = "SELECT DNI, Télefono, Estado, Cargo, AreaTrabajo FROM Personal WHERE PersonalID = @PersonalID";
                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@PersonalID", personalID);
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            dniLabel.Text = reader["DNI"].ToString();
                            telefonoLabel.Text = reader["Télefono"].ToString();
                            estadoLabel.Text = reader["Estado"].ToString();
                            tipoCargoLabel.Text = reader["Cargo"].ToString();
                            areaTrabajoLabel.Text = reader["AreaTrabajo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró información para el técnico seleccionado.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("El valor seleccionado no es válido.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtIdRepuestos_TextChanged(object sender, EventArgs e)
        {
         
        }


        private void btnTerminarPedido_Click_1(object sender, EventArgs e)
        {
            try
            {
                // Verificar que se haya seleccionado un pedido
                if (dataGridRepuestos.CurrentRow != null)
                {
                    var ordenSeleccionada = (entPedidoRepuestos)dataGridRepuestos.CurrentRow.DataBoundItem;
                    int idPedido = ordenSeleccionada.PedidoDeRepuestosID;

                    var confirmResult = MessageBox.Show("¿Está seguro de que desea terminar este pedido?",
                                                         "Confirmar finalizacion",
                                                         MessageBoxButtons.YesNo);
                    if (confirmResult == DialogResult.Yes)
                    {
                        logPedidoRepuestos.Instancia.TerminarPedidoRepuesto(idPedido);
                        MessageBox.Show("Pedido terminado exitosamente.");
                        ListarPedidosRepuesto();
                    }
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione un pedido para terminar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}
