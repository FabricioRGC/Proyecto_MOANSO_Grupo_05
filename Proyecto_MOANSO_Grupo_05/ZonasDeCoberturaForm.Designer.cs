namespace Proyecto_MOANSO_Grupo_05
{
    partial class ZonasDeCoberturaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.buscarTxt = new System.Windows.Forms.TextBox();
            this.btnInhabilitarZon = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAñadirZon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxVelocidad = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbxTipoCobertura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxDistritos = new System.Windows.Forms.TextBox();
            this.btnModificarZon = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(20, 263);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(144, 22);
            this.textBox5.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 196);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Buscar";
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(20, 222);
            this.buscarTxt.Margin = new System.Windows.Forms.Padding(4);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(144, 22);
            this.buscarTxt.TabIndex = 49;
            this.buscarTxt.TextChanged += new System.EventHandler(this.buscarTxt_TextChanged);
            // 
            // btnInhabilitarZon
            // 
            this.btnInhabilitarZon.Location = new System.Drawing.Point(269, 263);
            this.btnInhabilitarZon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitarZon.Name = "btnInhabilitarZon";
            this.btnInhabilitarZon.Size = new System.Drawing.Size(100, 35);
            this.btnInhabilitarZon.TabIndex = 48;
            this.btnInhabilitarZon.Text = "Inhabilitar";
            this.btnInhabilitarZon.UseVisualStyleBackColor = true;
            this.btnInhabilitarZon.Click += new System.EventHandler(this.btnInhabilitarZon_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 315);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(410, 311);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnAñadirZon
            // 
            this.btnAñadirZon.ForeColor = System.Drawing.Color.Black;
            this.btnAñadirZon.Location = new System.Drawing.Point(273, 133);
            this.btnAñadirZon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirZon.Name = "btnAñadirZon";
            this.btnAñadirZon.Size = new System.Drawing.Size(92, 29);
            this.btnAñadirZon.TabIndex = 43;
            this.btnAñadirZon.Text = "Añadir";
            this.btnAñadirZon.UseVisualStyleBackColor = true;
            this.btnAñadirZon.Click += new System.EventHandler(this.btnAñadirZon_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxVelocidad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbxTipoCobertura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxDistritos);
            this.groupBox1.Controls.Add(this.btnAñadirZon);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(4, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(419, 179);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Identificación de la Zona\n\n";
            // 
            // comboBoxVelocidad
            // 
            this.comboBoxVelocidad.FormattingEnabled = true;
            this.comboBoxVelocidad.Location = new System.Drawing.Point(138, 90);
            this.comboBoxVelocidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVelocidad.Name = "comboBoxVelocidad";
            this.comboBoxVelocidad.Size = new System.Drawing.Size(128, 24);
            this.comboBoxVelocidad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "TipoServicio";
            // 
            // cmbxTipoCobertura
            // 
            this.cmbxTipoCobertura.FormattingEnabled = true;
            this.cmbxTipoCobertura.Location = new System.Drawing.Point(139, 138);
            this.cmbxTipoCobertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxTipoCobertura.Name = "cmbxTipoCobertura";
            this.cmbxTipoCobertura.Size = new System.Drawing.Size(127, 24);
            this.cmbxTipoCobertura.TabIndex = 7;
            this.cmbxTipoCobertura.SelectedIndexChanged += new System.EventHandler(this.cmbxTipoCobertura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tipo conexión";
            // 
            // textBoxDistritos
            // 
            this.textBoxDistritos.Location = new System.Drawing.Point(138, 49);
            this.textBoxDistritos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDistritos.Name = "textBoxDistritos";
            this.textBoxDistritos.Size = new System.Drawing.Size(127, 22);
            this.textBoxDistritos.TabIndex = 5;
            // 
            // btnModificarZon
            // 
            this.btnModificarZon.Location = new System.Drawing.Point(277, 209);
            this.btnModificarZon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarZon.Name = "btnModificarZon";
            this.btnModificarZon.Size = new System.Drawing.Size(92, 35);
            this.btnModificarZon.TabIndex = 53;
            this.btnModificarZon.Text = "ModificarZon";
            this.btnModificarZon.UseVisualStyleBackColor = true;
            this.btnModificarZon.Click += new System.EventHandler(this.btnModificarZon_Click);
            // 
            // ZonasDeCoberturaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(472, 649);
            this.Controls.Add(this.btnModificarZon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.btnInhabilitarZon);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZonasDeCoberturaForm";
            this.Text = "ZonasDeCoberturaForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox buscarTxt;
        private System.Windows.Forms.Button btnInhabilitarZon;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAñadirZon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDistritos;
        private System.Windows.Forms.Button btnModificarZon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxTipoCobertura;
        private System.Windows.Forms.ComboBox comboBoxVelocidad;
    }
}