namespace Proyecto_MOANSO_Grupo_05
{
    partial class PlanificacionMantenimientoForm
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
            this.dgvMante = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPersonal = new System.Windows.Forms.ComboBox();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.datePickerFecha = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMante)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMante
            // 
            this.dgvMante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMante.Location = new System.Drawing.Point(56, 250);
            this.dgvMante.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMante.Name = "dgvMante";
            this.dgvMante.RowHeadersWidth = 51;
            this.dgvMante.RowTemplate.Height = 24;
            this.dgvMante.Size = new System.Drawing.Size(460, 127);
            this.dgvMante.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.btnAñadir);
            this.groupBox2.Controls.Add(this.comboBox1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPersonal);
            this.groupBox2.Controls.Add(this.btnInhabilitar);
            this.groupBox2.Controls.Add(this.datePickerFecha);
            this.groupBox2.Location = new System.Drawing.Point(56, 34);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(591, 199);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos Del Mantenimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Fecha Programacion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(225, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Terminar (ID Mnatenimiento)";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(370, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 20);
            this.textBox2.TabIndex = 17;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(333, 134);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(53, 19);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Insertar";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click_1);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(99, 74);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contrato";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 108);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Frecuencia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Repuesto";
            // 
            // cbPersonal
            // 
            this.cbPersonal.FormattingEnabled = true;
            this.cbPersonal.Location = new System.Drawing.Point(99, 42);
            this.cbPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(92, 21);
            this.cbPersonal.TabIndex = 11;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(491, 44);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(71, 19);
            this.btnInhabilitar.TabIndex = 2;
            this.btnInhabilitar.Text = "Terminado";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click_1);
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Location = new System.Drawing.Point(136, 134);
            this.datePickerFecha.Margin = new System.Windows.Forms.Padding(2);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Size = new System.Drawing.Size(151, 20);
            this.datePickerFecha.TabIndex = 0;
            // 
            // PlanificacionMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 411);
            this.Controls.Add(this.dgvMante);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlanificacionMantenimientoForm";
            this.Text = "PlanificacionMantenimientoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMante)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbPersonal;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.DateTimePicker datePickerFecha;
    }
}