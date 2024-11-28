using CapaDatos;
using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CapaEntidad.NotaDeSalida;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class NotaDeSalidaForm : Form
    {
        public NotaDeSalidaForm()
        {
            InitializeComponent();
            listarNotaSalida();

            CargarPedidoRepuestos();
            CargarPedidoMateriales();

            //cbRepuestos.Visible = false;
            //cbMateriales.Visible = false;
        }

        public void listarNotaSalida()
        {
            TablaNotadeSalida.DataSource = LogNotaDeSalida.Instancia.ListarNotadeSalida();
        }

        private void CargarPedidoRepuestos()
        {
            string consulta = "SELECT * FROM PedidoDeRepuestos";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbRepuestos.Items.Add(int.Parse(reader["PedidoDeRepuestosID"].ToString()));
                }

                reader.Close();

            }
        }

        private void CargarPedidoMateriales()
        {
            string consulta = "SELECT PedidoMaterialesID FROM PedidoMateriales";

            using (SqlConnection cn = Conexion.Instancia.Conectar())
            {
                SqlCommand cmd = new SqlCommand(consulta, cn);
                cn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    cbMateriales.Items.Add(int.Parse(reader["PedidoMaterialesID"].ToString()));
                }

                reader.Close();

            }
        }



        private void rbPedidoMateriales_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (rbPedidoMateriales.Checked)
                {
                    cbRepuestos.Visible = false;
                    cbMateriales.Visible = true;
                    lbProduct.Text = "Material";
                }
            }
        }

        private void rbPedidoRepuestos_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPedidoRepuestos.Checked)
            {
                cbMateriales.Visible = false;
                cbRepuestos.Visible = true;
                lbProduct.Text = "Repuesto";

            }
        }

        private void btAgregar_Click(object sender, EventArgs e)
        {



            if (rbPedidoRepuestos.Checked)
            {
                try
                {
                    entNotadesalida entNotadesalida = new entNotadesalida();
                    entNotadesalida.PedidiRepuestosID = Convert.ToInt32(labelProducto.Text);
                    entNotadesalida.FechadeEmision = dateTimePicker1.Value.Date;
                    entNotadesalida.Estado = 1;
                    LogNotaDeSalida.Instancia.InsertarNotaSalidaRepuestos(entNotadesalida);

                    entNotadesalida entNotadesalida2 = new entNotadesalida();
                    entNotadesalida2.PedidiRepuestosID = Convert.ToInt32(labelProducto.Text);
                    LogNotaDeSalida.Instancia.ReducirStockRepuestos(entNotadesalida2);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else if (rbPedidoMateriales.Checked)
            {
                try
                {
                    entNotadesalida entNotadesalida = new entNotadesalida();
                    entNotadesalida.PedidiMaterialesID = Convert.ToInt32(labelProducto.Text);
                    entNotadesalida.FechadeEmision = dateTimePicker1.Value.Date;
                    entNotadesalida.Estado = 1;
                    LogNotaDeSalida.Instancia.InsertarNotaSalidaMateriales(entNotadesalida);

                    entNotadesalida entNotadesalida3 = new entNotadesalida();
                    entNotadesalida3.PedidiMaterialesID = Convert.ToInt32(labelProducto.Text);
                    LogNotaDeSalida.Instancia.ReducirStockMateriales(entNotadesalida3);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Acción cuando ninguno está seleccionado
                MessageBox.Show("Por favor, selecciona una opción.");
            }


        }

        private void Butonbuscar_Click(object sender, EventArgs e)
        {
            int valorSeleccionado;
            int valorSeleccionado2;
            if (rbPedidoMateriales.Checked)
            {
                cbRepuestos.Visible = false;
                cbMateriales.Visible = true;
                lbProduct.Text = "Material";
                valorSeleccionado = int.Parse(cbMateriales.SelectedItem.ToString());


                try
                {
                    using (SqlConnection cn = Conexion.Instancia.Conectar())
                    {
                        string consulta = "Select MaterialID, Stock, PersonalID from PedidoMateriales where PedidoMaterialesID = @ID";
                        SqlCommand cmd = new SqlCommand(consulta, cn);
                        cmd.Parameters.AddWithValue("@ID", valorSeleccionado);
                        cn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();

                        while (reader.Read())
                        {
                            labelCantidad.Text = reader["PersonalID"].ToString();
                            labelProducto.Text = reader["MaterialID"].ToString();
                            labelCantidad.Text = reader["Stock"].ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


            else if (rbPedidoRepuestos.Checked)
                {

                    valorSeleccionado2 = int.Parse(cbRepuestos.SelectedItem.ToString());

                    try
                    {
                        using (SqlConnection cn = Conexion.Instancia.Conectar())
                        {
                            string consulta = "Select RepuestosID, Stock, PersonalID from PedidoDeRepuestos where PedidoDeRepuestosID = @ID";
                            SqlCommand cmd = new SqlCommand(consulta, cn);
                            cmd.Parameters.AddWithValue("@ID", valorSeleccionado2);
                            cn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();

                            while (reader.Read())
                            {
                                labelCantidad.Text = reader["PersonalID"].ToString();
                                labelProducto.Text = reader["MaterialID"].ToString();
                                labelCantidad.Text = reader["Stock"].ToString();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
}


