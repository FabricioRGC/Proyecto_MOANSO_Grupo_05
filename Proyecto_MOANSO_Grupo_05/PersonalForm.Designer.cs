namespace Proyecto_MOANSO_Grupo_05
{
    partial class PersonalForm
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
            this.btnAñadir = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaPersonal = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.cbTipoEncargado = new System.Windows.Forms.ComboBox();
            this.cbAreaTrabajo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtInhabilitar = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAñadir.Location = new System.Drawing.Point(356, 95);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(2);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(79, 34);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.Location = new System.Drawing.Point(20, 64);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(95, 30);
            this.btnInhabilitar.TabIndex = 1;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click_1);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(127, 26);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(76, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(112, 20);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(76, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(37, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre";
            // 
            // tablaPersonal
            // 
            this.tablaPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaPersonal.Location = new System.Drawing.Point(9, 29);
            this.tablaPersonal.Margin = new System.Windows.Forms.Padding(2);
            this.tablaPersonal.Name = "tablaPersonal";
            this.tablaPersonal.RowHeadersWidth = 51;
            this.tablaPersonal.RowTemplate.Height = 24;
            this.tablaPersonal.Size = new System.Drawing.Size(830, 241);
            this.tablaPersonal.TabIndex = 6;
            this.tablaPersonal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaPersonal_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(39, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(112, 111);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(2);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(76, 20);
            this.txtTelefono.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(54, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "DNI:";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(112, 76);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(2);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(76, 20);
            this.txtDNI.TabIndex = 39;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(37, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 44;
            this.label5.Text = "Apellidos";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(112, 42);
            this.txtApellidos.Margin = new System.Windows.Forms.Padding(2);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(76, 20);
            this.txtApellidos.TabIndex = 43;
            // 
            // cbTipoEncargado
            // 
            this.cbTipoEncargado.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.cbTipoEncargado.FormattingEnabled = true;
            this.cbTipoEncargado.Items.AddRange(new object[] {
            "Jefe de Servicio",
            "Jefe de almacén",
            "Jefe de soporte tecnico",
            "Asesor de Ventas"});
            this.cbTipoEncargado.Location = new System.Drawing.Point(283, 37);
            this.cbTipoEncargado.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipoEncargado.Name = "cbTipoEncargado";
            this.cbTipoEncargado.Size = new System.Drawing.Size(92, 21);
            this.cbTipoEncargado.TabIndex = 45;
            // 
            // cbAreaTrabajo
            // 
            this.cbAreaTrabajo.FormattingEnabled = true;
            this.cbAreaTrabajo.Items.AddRange(new object[] {
            "Área de servicios",
            "Área de soporte técnico",
            "Área de almacén",
            "Area de Ventas"});
            this.cbAreaTrabajo.Location = new System.Drawing.Point(410, 37);
            this.cbAreaTrabajo.Margin = new System.Windows.Forms.Padding(2);
            this.cbAreaTrabajo.Name = "cbAreaTrabajo";
            this.cbAreaTrabajo.Size = new System.Drawing.Size(76, 21);
            this.cbAreaTrabajo.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(410, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Área de trabajo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(281, 11);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Tipo de encargado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(32, 26);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Buscar por DNI:";
            // 
            // txtInhabilitar
            // 
            this.txtInhabilitar.Location = new System.Drawing.Point(137, 70);
            this.txtInhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.txtInhabilitar.Name = "txtInhabilitar";
            this.txtInhabilitar.Size = new System.Drawing.Size(76, 20);
            this.txtInhabilitar.TabIndex = 50;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtInhabilitar);
            this.groupBox1.Controls.Add(this.btnInhabilitar);
            this.groupBox1.Controls.Add(this.txtBuscar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(583, 281);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(230, 150);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(28, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 25);
            this.button1.TabIndex = 51;
            this.button1.Text = "Editar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbAreaTrabajo);
            this.groupBox2.Controls.Add(this.cbTipoEncargado);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtApellidos);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTelefono);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDNI);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.btnAñadir);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox2.Location = new System.Drawing.Point(24, 281);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(540, 150);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir Datos Personal";
            // 
            // PersonalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(978, 479);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tablaPersonal);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersonalForm";
            this.Text = "PersonalForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablaPersonal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tablaPersonal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.ComboBox cbTipoEncargado;
        private System.Windows.Forms.ComboBox cbAreaTrabajo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtInhabilitar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}