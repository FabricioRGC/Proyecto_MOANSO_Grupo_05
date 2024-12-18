﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaLogica;

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }
        public void AbrirPrueba(object fromprue)
       {
           //if (this.panel1.Controls.Count > 0)
           //    this.panel1.Controls.RemoveAt(0);
           //Form fh = fromprue as Form;
           //fh.TopLevel = false;
           //fh.Dock = DockStyle.Fill;
           //this.panel1.Controls.Add(fh);
           //this.panel1.Tag = fh;
           //fh.Show();

       }
       
        public void AbrirPrueba2(object fromprues)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fhs = fromprues as Form;
            fhs.TopLevel = false;
            fhs.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fhs);
            this.panel2.Tag = fhs;
            fhs.Show();

        }

        // Boton para abrir el formulario de clientes
        private void button13_Click(object sender, EventArgs e)
        {
            //Form formulario = new ClientesForm();
            //formulario.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        //Boton para abrir el boton que lleva a la ventana materiales
        private void button11_Click(object sender, EventArgs e)
        {
            //Form formulario = new MaterialesForm();
            //formulario.Show();
            //AbrirPrueba(new MaterialesForm());
        }


        //Boton para abrir el boton que lleva a la ventana contratos
        private void button1_Click(object sender, EventArgs e)
        {
            Form formulario = new ContratosForm();
            formulario.Show();
        }

        //Boton para abrir el boton que lleva a la ventana proformas
        private void button10_Click(object sender, EventArgs e)
        {
            Form formulario = new ProformasForm();
            formulario.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form formulario = new RepuestosForm();
            formulario.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Form formulario = new PersonalForm();
            formulario.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Form formulario = new DiagnosticoForm();
            //formulario.Show();
            //AbrirPrueba(new DiagnosticoForm());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form formulario = new PedidoInstalacionForm();
            formulario.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formulario = new PagosForm();
            formulario.Show();
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            //AbrirPrueba2(new ClientesForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
           

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            AbrirPrueba2(new MaterialesForm());
        }

        private void button14_Click_1(object sender, EventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            AbrirPrueba2(new RepuestosForm());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            // Cierra la aplicación
            Application.Exit();
        }

        private void button16_Click(object sender, EventArgs e)
        {
        }

        private void proformasDeVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new ProformasForm());
        }

        private void vENTASToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //clientes 
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new ClientesForm());
        }

        private void contratosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new ContratosForm());
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PagosForm());
        }

        private void ordenesDeTrabajoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new OrdenDeTrabajocs());

        }

        private void ordenesDePedidoDeInstalaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenesDePedidoDeMaterialesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenesDePedidoDeRepuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sSSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new NotaDeSalidaForm());
        }

        private void materialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new MaterialesForm());

        }

        private void repuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new RepuestosForm());

        }

        private void personalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PlanificacionMantenimientoForm());

        }

        private void zonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void ordenesDePedidoDeInstalaciónToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PedidoInstalacionForm());

        }

        private void personalToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PersonalForm());
        }

        private void ordenesDePedidoDeMaterialesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PedidoMaterialesForm());

        }

        private void ordenesDePedidoDeRepuestosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PedidoRepuestoForm());

        }

        private void zonaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new ZonasDeCoberturaForm());

        }

        private void vOLVERALAPRIMERAINTERFAZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formulario = new PrincipalForm();
            formulario.Show();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirPrueba2(new PlanesForm());
        }

        private void pLANESYZONAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
        }
    }
}
