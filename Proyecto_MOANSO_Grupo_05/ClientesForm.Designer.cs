namespace Proyecto_MOANSO_Grupo_05
{
    partial class ClientesForm
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tablaClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Location = new System.Drawing.Point(31, 300);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(285, 58);
            this.btnAñadir.TabIndex = 0;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(31, 377);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(285, 58);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(31, 454);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(285, 58);
            this.button3.TabIndex = 2;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(123, 42);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(125, 105);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(192, 22);
            this.txtDireccion.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(27, 108);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Dirección:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(123, 166);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(195, 22);
            this.txtTelefono.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(27, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Teléfono:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDireccion);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(347, 546);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Cliente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(27, 235);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "DNI:";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(123, 231);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(192, 22);
            this.txtDni.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 8;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tablaClientes
            // 
            this.tablaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaClientes.Location = new System.Drawing.Point(391, 126);
            this.tablaClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaClientes.Name = "tablaClientes";
            this.tablaClientes.RowHeadersWidth = 51;
            this.tablaClientes.Size = new System.Drawing.Size(837, 422);
            this.tablaClientes.TabIndex = 17;
            this.tablaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaClientes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.OliveDrab;
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtBuscarNombre);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(391, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(837, 95);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(25, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 16);
            this.label6.TabIndex = 14;
            this.label6.Text = "Buscar por Nombre:";
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.Location = new System.Drawing.Point(168, 42);
            this.txtBuscarNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(153, 22);
            this.txtBuscarNombre.TabIndex = 15;
            this.txtBuscarNombre.TextChanged += new System.EventHandler(this.txtBuscarNombre_TextChanged_1);
            // 
            // ClientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1244, 576);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.tablaClientes);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ClientesForm";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.DataGridView tablaClientes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBuscarNombre;
    }
}