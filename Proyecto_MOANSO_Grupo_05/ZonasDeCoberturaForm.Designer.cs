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
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxTipozon = new System.Windows.Forms.ComboBox();
            this.textBoxPostal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(315, 394);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 372);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Buscar";
            // 
            // buscarTxt
            // 
            this.buscarTxt.Location = new System.Drawing.Point(16, 394);
            this.buscarTxt.Margin = new System.Windows.Forms.Padding(4);
            this.buscarTxt.Name = "buscarTxt";
            this.buscarTxt.Size = new System.Drawing.Size(132, 22);
            this.buscarTxt.TabIndex = 49;
            this.buscarTxt.TextChanged += new System.EventHandler(this.buscarTxt_TextChanged);
            // 
            // btnInhabilitarZon
            // 
            this.btnInhabilitarZon.Location = new System.Drawing.Point(456, 391);
            this.btnInhabilitarZon.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitarZon.Name = "btnInhabilitarZon";
            this.btnInhabilitarZon.Size = new System.Drawing.Size(100, 28);
            this.btnInhabilitarZon.TabIndex = 48;
            this.btnInhabilitarZon.Text = "Inhabilitar";
            this.btnInhabilitarZon.UseVisualStyleBackColor = true;
            this.btnInhabilitarZon.Click += new System.EventHandler(this.btnInhabilitarZon_Click);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(16, 206);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(643, 146);
            this.txtObservaciones.TabIndex = 47;
            this.txtObservaciones.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(13, 177);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Descripción";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.comboBoxTipozon);
            this.groupBox3.Controls.Add(this.textBoxPostal);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(393, 32);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(267, 142);
            this.groupBox3.TabIndex = 45;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Disponibilidad de Servicio:\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 31);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 55;
            this.label7.Text = "Tipo de zona";
            // 
            // comboBoxTipozon
            // 
            this.comboBoxTipozon.FormattingEnabled = true;
            this.comboBoxTipozon.Items.AddRange(new object[] {
            "Total (Cubre toda la zona)",
            "Parcial (Especificar)"});
            this.comboBoxTipozon.Location = new System.Drawing.Point(21, 50);
            this.comboBoxTipozon.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxTipozon.Name = "comboBoxTipozon";
            this.comboBoxTipozon.Size = new System.Drawing.Size(160, 24);
            this.comboBoxTipozon.TabIndex = 54;
            // 
            // textBoxPostal
            // 
            this.textBoxPostal.Location = new System.Drawing.Point(117, 89);
            this.textBoxPostal.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostal.Name = "textBoxPostal";
            this.textBoxPostal.Size = new System.Drawing.Size(127, 22);
            this.textBoxPostal.TabIndex = 7;
            this.textBoxPostal.TextChanged += new System.EventHandler(this.textBoxPostal_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Postal";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 442);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(649, 303);
            this.dataGridView1.TabIndex = 44;
            // 
            // btnAñadirZon
            // 
            this.btnAñadirZon.Location = new System.Drawing.Point(565, 390);
            this.btnAñadirZon.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadirZon.Name = "btnAñadirZon";
            this.btnAñadirZon.Size = new System.Drawing.Size(100, 26);
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
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 23);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(345, 150);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Identificación de la Zona\n\n";
            // 
            // comboBoxVelocidad
            // 
            this.comboBoxVelocidad.FormattingEnabled = true;
            this.comboBoxVelocidad.Location = new System.Drawing.Point(203, 73);
            this.comboBoxVelocidad.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxVelocidad.Name = "comboBoxVelocidad";
            this.comboBoxVelocidad.Size = new System.Drawing.Size(128, 24);
            this.comboBoxVelocidad.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 16);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo";
            // 
            // cmbxTipoCobertura
            // 
            this.cmbxTipoCobertura.FormattingEnabled = true;
            this.cmbxTipoCobertura.Location = new System.Drawing.Point(204, 111);
            this.cmbxTipoCobertura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbxTipoCobertura.Name = "cmbxTipoCobertura";
            this.cmbxTipoCobertura.Size = new System.Drawing.Size(127, 24);
            this.cmbxTipoCobertura.TabIndex = 7;
            this.cmbxTipoCobertura.SelectedIndexChanged += new System.EventHandler(this.cmbxTipoCobertura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Distrito";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Velocidad de la cobertura";
            // 
            // textBoxDistritos
            // 
            this.textBoxDistritos.Location = new System.Drawing.Point(204, 27);
            this.textBoxDistritos.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDistritos.Name = "textBoxDistritos";
            this.textBoxDistritos.Size = new System.Drawing.Size(127, 22);
            this.textBoxDistritos.TabIndex = 5;
            // 
            // btnModificarZon
            // 
            this.btnModificarZon.Location = new System.Drawing.Point(165, 391);
            this.btnModificarZon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarZon.Name = "btnModificarZon";
            this.btnModificarZon.Size = new System.Drawing.Size(75, 28);
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
            this.ClientSize = new System.Drawing.Size(679, 793);
            this.Controls.Add(this.btnModificarZon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buscarTxt);
            this.Controls.Add(this.btnInhabilitarZon);
            this.Controls.Add(this.txtObservaciones);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAñadirZon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ZonasDeCoberturaForm";
            this.Text = "ZonasDeCoberturaForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
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
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAñadirZon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPostal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxDistritos;
        private System.Windows.Forms.Button btnModificarZon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbxTipoCobertura;
        private System.Windows.Forms.ComboBox comboBoxTipozon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxVelocidad;
    }
}