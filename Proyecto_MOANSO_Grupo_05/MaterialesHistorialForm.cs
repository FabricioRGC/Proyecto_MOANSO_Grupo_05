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

namespace Proyecto_MOANSO_Grupo_05
{
    public partial class MaterialesHistorialForm : Form
    {
        public MaterialesHistorialForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string codigo = textBox1.Text;

            var MaterialesFiltrados = logMateriales.Instancia.ListarMateriales().Where(Mate => Mate.nombre.Contains(codigo)).ToList();

            dataGriMateriales.DataSource = MaterialesFiltrados;
        }
    }
}