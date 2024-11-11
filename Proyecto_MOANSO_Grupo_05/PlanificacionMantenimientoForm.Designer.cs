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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvMante = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbPersonal = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.datePickerFecha = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMante)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvMante);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(37, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 459);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dgvMante
            // 
            this.dgvMante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMante.Location = new System.Drawing.Point(11, 261);
            this.dgvMante.Name = "dgvMante";
            this.dgvMante.RowHeadersWidth = 51;
            this.dgvMante.RowTemplate.Height = 24;
            this.dgvMante.Size = new System.Drawing.Size(870, 182);
            this.dgvMante.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cbPersonal);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.btnInhabilitar);
            this.groupBox2.Controls.Add(this.btnAñadir);
            this.groupBox2.Controls.Add(this.datePickerFecha);
            this.groupBox2.Location = new System.Drawing.Point(9, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(872, 211);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente";
            // 
            // cbPersonal
            // 
            this.cbPersonal.FormattingEnabled = true;
            this.cbPersonal.Location = new System.Drawing.Point(92, 58);
            this.cbPersonal.Name = "cbPersonal";
            this.cbPersonal.Size = new System.Drawing.Size(121, 24);
            this.cbPersonal.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(693, 164);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "btn";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(693, 91);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(75, 23);
            this.btnInhabilitar.TabIndex = 2;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(693, 23);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 1;
            this.btnAñadir.Text = "Guardar";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // datePickerFecha
            // 
            this.datePickerFecha.Location = new System.Drawing.Point(280, 60);
            this.datePickerFecha.Name = "datePickerFecha";
            this.datePickerFecha.Size = new System.Drawing.Size(200, 22);
            this.datePickerFecha.TabIndex = 0;
            // 
            // PlanificacionMantenimientoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 506);
            this.Controls.Add(this.groupBox1);
            this.Name = "PlanificacionMantenimientoForm";
            this.Text = "PlanificacionMantenimientoForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMante)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvMante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.DateTimePicker datePickerFecha;
        private System.Windows.Forms.ComboBox cbPersonal;
        private System.Windows.Forms.Label label3;
    }
}