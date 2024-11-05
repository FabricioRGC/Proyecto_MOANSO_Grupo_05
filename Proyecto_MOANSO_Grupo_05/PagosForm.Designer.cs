namespace Proyecto_MOANSO_Grupo_05
{
    partial class PagosForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.fechaPicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelDireccion = new System.Windows.Forms.Label();
            this.labelEstado = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelFechaContrato = new System.Windows.Forms.Label();
            this.labelPlan = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(19, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Fecha de Contrato:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelTelefono);
            this.groupBox2.Controls.Add(this.labelCodigo);
            this.groupBox2.Controls.Add(this.labelEstado);
            this.groupBox2.Controls.Add(this.labelDireccion);
            this.groupBox2.Controls.Add(this.labelDni);
            this.groupBox2.Controls.Add(this.dniLabel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Controls.Add(this.estadoLabel);
            this.groupBox2.Controls.Add(this.telefonoLabel);
            this.groupBox2.Controls.Add(this.direccionLabel);
            this.groupBox2.Controls.Add(this.codigoLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(461, 161);
            this.groupBox2.TabIndex = 38;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Cliente";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.ForeColor = System.Drawing.Color.White;
            this.dniLabel.Location = new System.Drawing.Point(84, 68);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(0, 16);
            this.dniLabel.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(234, 33);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Dni:";
            // 
            // cbCliente
            // 
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(82, 30);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 24);
            this.cbCliente.TabIndex = 43;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.ForeColor = System.Drawing.Color.White;
            this.estadoLabel.Location = new System.Drawing.Point(86, 206);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(0, 16);
            this.estadoLabel.TabIndex = 50;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.ForeColor = System.Drawing.Color.White;
            this.telefonoLabel.Location = new System.Drawing.Point(86, 170);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(0, 16);
            this.telefonoLabel.TabIndex = 49;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.ForeColor = System.Drawing.Color.White;
            this.direccionLabel.Location = new System.Drawing.Point(86, 138);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(0, 16);
            this.direccionLabel.TabIndex = 48;
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.ForeColor = System.Drawing.Color.White;
            this.codigoLabel.Location = new System.Drawing.Point(86, 103);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(0, 16);
            this.codigoLabel.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(216, 122);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(21, 122);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(188, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Dirección:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(21, 78);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Cliente:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPago);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnHistorial);
            this.groupBox1.Controls.Add(this.fechaPicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMonto);
            this.groupBox1.Controls.Add(this.btnAñadir);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 199);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles del Pago";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta"});
            this.cbPago.Location = new System.Drawing.Point(146, 30);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(121, 24);
            this.cbPago.TabIndex = 58;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 16);
            this.label6.TabIndex = 55;
            this.label6.Text = "Método de Pago:";
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(211, 161);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(149, 24);
            this.btnImprimir.TabIndex = 54;
            this.btnImprimir.Text = "Generar Comprobante";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnHistorial
            // 
            this.btnHistorial.ForeColor = System.Drawing.Color.Black;
            this.btnHistorial.Location = new System.Drawing.Point(100, 161);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(105, 24);
            this.btnHistorial.TabIndex = 51;
            this.btnHistorial.Text = "Ver Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click);
            // 
            // fechaPicker
            // 
            this.fechaPicker.Location = new System.Drawing.Point(85, 122);
            this.fechaPicker.Name = "fechaPicker";
            this.fechaPicker.Size = new System.Drawing.Size(255, 22);
            this.fechaPicker.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(19, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "Fecha:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(21, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 49;
            this.label1.Text = "Monto:";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(89, 78);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(83, 22);
            this.txtMonto.TabIndex = 50;
            // 
            // btnAñadir
            // 
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Location = new System.Drawing.Point(366, 161);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(84, 24);
            this.btnAñadir.TabIndex = 48;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelPlan);
            this.groupBox3.Controls.Add(this.labelFechaContrato);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(12, 182);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(461, 63);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Contrato:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(237, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Tipo de Plan:";
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDni.ForeColor = System.Drawing.Color.White;
            this.labelDni.Location = new System.Drawing.Point(270, 33);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(0, 16);
            this.labelDni.TabIndex = 53;
            // 
            // labelDireccion
            // 
            this.labelDireccion.AutoSize = true;
            this.labelDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDireccion.ForeColor = System.Drawing.Color.White;
            this.labelDireccion.Location = new System.Drawing.Point(259, 78);
            this.labelDireccion.Name = "labelDireccion";
            this.labelDireccion.Size = new System.Drawing.Size(0, 16);
            this.labelDireccion.TabIndex = 54;
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.ForeColor = System.Drawing.Color.White;
            this.labelEstado.Location = new System.Drawing.Point(275, 122);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(0, 16);
            this.labelEstado.TabIndex = 55;
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.ForeColor = System.Drawing.Color.White;
            this.labelCodigo.Location = new System.Drawing.Point(79, 78);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(0, 16);
            this.labelCodigo.TabIndex = 56;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefono.ForeColor = System.Drawing.Color.White;
            this.labelTelefono.Location = new System.Drawing.Point(92, 122);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(0, 16);
            this.labelTelefono.TabIndex = 57;
            // 
            // labelFechaContrato
            // 
            this.labelFechaContrato.AutoSize = true;
            this.labelFechaContrato.ForeColor = System.Drawing.Color.White;
            this.labelFechaContrato.Location = new System.Drawing.Point(145, 28);
            this.labelFechaContrato.Name = "labelFechaContrato";
            this.labelFechaContrato.Size = new System.Drawing.Size(0, 16);
            this.labelFechaContrato.TabIndex = 28;
            // 
            // labelPlan
            // 
            this.labelPlan.AutoSize = true;
            this.labelPlan.ForeColor = System.Drawing.Color.White;
            this.labelPlan.Location = new System.Drawing.Point(330, 28);
            this.labelPlan.Name = "labelPlan";
            this.labelPlan.Size = new System.Drawing.Size(0, 16);
            this.labelPlan.TabIndex = 29;
            // 
            // PagosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(112)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(485, 463);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PagosForm";
            this.Text = "PagosForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnHistorial;
        private System.Windows.Forms.DateTimePicker fechaPicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.Label labelDireccion;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelPlan;
        private System.Windows.Forms.Label labelFechaContrato;
    }
}