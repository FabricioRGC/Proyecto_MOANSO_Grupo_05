namespace Proyecto_MOANSO_Grupo_05
{
    partial class ProformasForm
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
            this.labelAT = new System.Windows.Forms.Label();
            this.labelAD = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbAsesor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tablaProformas = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.txtCodigoCliente = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelcodigocliente = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.direccionLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelCodigoServicio = new System.Windows.Forms.Label();
            this.caracteristicasLabel = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.precioLabel = new System.Windows.Forms.Label();
            this.velocidadLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.fechaInicioPicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.fechaFinPicker = new System.Windows.Forms.DateTimePicker();
            this.labelAsesorID = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProformas)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAT);
            this.groupBox1.Controls.Add(this.labelAD);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbAsesor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 225);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(661, 70);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalle del Asesor";
            // 
            // labelAT
            // 
            this.labelAT.AutoSize = true;
            this.labelAT.ForeColor = System.Drawing.Color.Black;
            this.labelAT.Location = new System.Drawing.Point(496, 30);
            this.labelAT.Name = "labelAT";
            this.labelAT.Size = new System.Drawing.Size(0, 13);
            this.labelAT.TabIndex = 56;
            // 
            // labelAD
            // 
            this.labelAD.AutoSize = true;
            this.labelAD.ForeColor = System.Drawing.Color.Black;
            this.labelAD.Location = new System.Drawing.Point(343, 30);
            this.labelAD.Name = "labelAD";
            this.labelAD.Size = new System.Drawing.Size(0, 13);
            this.labelAD.TabIndex = 55;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(438, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 54;
            this.label14.Text = "Teléfono:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(311, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "Dni:";
            // 
            // cbAsesor
            // 
            this.cbAsesor.ForeColor = System.Drawing.Color.Black;
            this.cbAsesor.FormattingEnabled = true;
            this.cbAsesor.Location = new System.Drawing.Point(139, 27);
            this.cbAsesor.Name = "cbAsesor";
            this.cbAsesor.Size = new System.Drawing.Size(121, 21);
            this.cbAsesor.TabIndex = 53;
            this.cbAsesor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Asesor de Venta:";
            // 
            // tablaProformas
            // 
            this.tablaProformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProformas.Location = new System.Drawing.Point(17, 450);
            this.tablaProformas.Name = "tablaProformas";
            this.tablaProformas.Size = new System.Drawing.Size(656, 290);
            this.tablaProformas.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(14, 405);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 13);
            this.label16.TabIndex = 56;
            this.label16.Text = "Buscar:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // txtCodigoCliente
            // 
            this.txtCodigoCliente.ForeColor = System.Drawing.Color.Black;
            this.txtCodigoCliente.Location = new System.Drawing.Point(63, 402);
            this.txtCodigoCliente.Name = "txtCodigoCliente";
            this.txtCodigoCliente.Size = new System.Drawing.Size(105, 20);
            this.txtCodigoCliente.TabIndex = 55;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.groupBox2.Controls.Add(this.labelcodigocliente);
            this.groupBox2.Controls.Add(this.dniLabel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbCliente);
            this.groupBox2.Controls.Add(this.estadoLabel);
            this.groupBox2.Controls.Add(this.telefonoLabel);
            this.groupBox2.Controls.Add(this.direccionLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(308, 207);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Cliente";
            // 
            // labelcodigocliente
            // 
            this.labelcodigocliente.AutoSize = true;
            this.labelcodigocliente.BackColor = System.Drawing.Color.Transparent;
            this.labelcodigocliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.labelcodigocliente.Location = new System.Drawing.Point(241, 33);
            this.labelcodigocliente.Name = "labelcodigocliente";
            this.labelcodigocliente.Size = new System.Drawing.Size(0, 13);
            this.labelcodigocliente.TabIndex = 53;
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.ForeColor = System.Drawing.Color.Black;
            this.dniLabel.Location = new System.Drawing.Point(86, 80);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(0, 13);
            this.dniLabel.TabIndex = 52;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(19, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(26, 13);
            this.label15.TabIndex = 51;
            this.label15.Text = "Dni:";
            // 
            // cbCliente
            // 
            this.cbCliente.ForeColor = System.Drawing.Color.Black;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(97, 30);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(121, 21);
            this.cbCliente.TabIndex = 43;
            this.cbCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged_1);
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.ForeColor = System.Drawing.Color.Black;
            this.estadoLabel.Location = new System.Drawing.Point(86, 179);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(0, 13);
            this.estadoLabel.TabIndex = 50;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.ForeColor = System.Drawing.Color.Black;
            this.telefonoLabel.Location = new System.Drawing.Point(86, 147);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(0, 13);
            this.telefonoLabel.TabIndex = 49;
            // 
            // direccionLabel
            // 
            this.direccionLabel.AutoSize = true;
            this.direccionLabel.ForeColor = System.Drawing.Color.Black;
            this.direccionLabel.Location = new System.Drawing.Point(86, 114);
            this.direccionLabel.Name = "direccionLabel";
            this.direccionLabel.Size = new System.Drawing.Size(0, 13);
            this.direccionLabel.TabIndex = 48;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(19, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(19, 147);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 13);
            this.label12.TabIndex = 45;
            this.label12.Text = "Teléfono:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(19, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Dirección:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(20, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cliente:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.groupBox3.Controls.Add(this.labelCodigoServicio);
            this.groupBox3.Controls.Add(this.caracteristicasLabel);
            this.groupBox3.Controls.Add(this.tipoLabel);
            this.groupBox3.Controls.Add(this.precioLabel);
            this.groupBox3.Controls.Add(this.velocidadLabel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.cbPlan);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(326, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 211);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Servicio:";
            // 
            // labelCodigoServicio
            // 
            this.labelCodigoServicio.AutoSize = true;
            this.labelCodigoServicio.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigoServicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.labelCodigoServicio.Location = new System.Drawing.Point(298, 33);
            this.labelCodigoServicio.Name = "labelCodigoServicio";
            this.labelCodigoServicio.Size = new System.Drawing.Size(0, 13);
            this.labelCodigoServicio.TabIndex = 54;
            // 
            // caracteristicasLabel
            // 
            this.caracteristicasLabel.AutoSize = true;
            this.caracteristicasLabel.ForeColor = System.Drawing.Color.Black;
            this.caracteristicasLabel.Location = new System.Drawing.Point(143, 179);
            this.caracteristicasLabel.Name = "caracteristicasLabel";
            this.caracteristicasLabel.Size = new System.Drawing.Size(0, 13);
            this.caracteristicasLabel.TabIndex = 42;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.ForeColor = System.Drawing.Color.Black;
            this.tipoLabel.Location = new System.Drawing.Point(143, 147);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(0, 13);
            this.tipoLabel.TabIndex = 41;
            // 
            // precioLabel
            // 
            this.precioLabel.AutoSize = true;
            this.precioLabel.ForeColor = System.Drawing.Color.Black;
            this.precioLabel.Location = new System.Drawing.Point(143, 114);
            this.precioLabel.Name = "precioLabel";
            this.precioLabel.Size = new System.Drawing.Size(0, 13);
            this.precioLabel.TabIndex = 40;
            // 
            // velocidadLabel
            // 
            this.velocidadLabel.AutoSize = true;
            this.velocidadLabel.ForeColor = System.Drawing.Color.Black;
            this.velocidadLabel.Location = new System.Drawing.Point(143, 80);
            this.velocidadLabel.Name = "velocidadLabel";
            this.velocidadLabel.Size = new System.Drawing.Size(0, 13);
            this.velocidadLabel.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(21, 179);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Características:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(21, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(87, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Tipo de Servicio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(21, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Precio (Mensual):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(21, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Velocidad (Mpbs):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(21, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Plan:";
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(146, 30);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 32;
            this.cbPlan.SelectedIndexChanged += new System.EventHandler(this.cbPlan_SelectedIndexChanged_1);
            // 
            // fechaInicioPicker
            // 
            this.fechaInicioPicker.Location = new System.Drawing.Point(108, 30);
            this.fechaInicioPicker.Name = "fechaInicioPicker";
            this.fechaInicioPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaInicioPicker.TabIndex = 60;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(19, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 59;
            this.label6.Text = "Fecha de Inicio:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.fechaFinPicker);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.fechaInicioPicker);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(12, 301);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(661, 70);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalle del Asesor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(322, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(116, 13);
            this.label10.TabIndex = 61;
            this.label10.Text = "Fecha de Vencimiento:";
            // 
            // fechaFinPicker
            // 
            this.fechaFinPicker.Location = new System.Drawing.Point(441, 30);
            this.fechaFinPicker.Name = "fechaFinPicker";
            this.fechaFinPicker.Size = new System.Drawing.Size(200, 20);
            this.fechaFinPicker.TabIndex = 62;
            // 
            // labelAsesorID
            // 
            this.labelAsesorID.AutoSize = true;
            this.labelAsesorID.BackColor = System.Drawing.Color.Transparent;
            this.labelAsesorID.ForeColor = System.Drawing.Color.Transparent;
            this.labelAsesorID.Location = new System.Drawing.Point(262, 402);
            this.labelAsesorID.Name = "labelAsesorID";
            this.labelAsesorID.Size = new System.Drawing.Size(0, 13);
            this.labelAsesorID.TabIndex = 63;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(96)))), ((int)(((byte)(175)))));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(317, 389);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(200, 44);
            this.btnImprimir.TabIndex = 64;
            this.btnImprimir.Text = "Generar Comprobante";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnAñadir.Location = new System.Drawing.Point(523, 388);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(150, 47);
            this.btnAñadir.TabIndex = 21;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // ProformasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1317, 751);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.labelAsesorID);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtCodigoCliente);
            this.Controls.Add(this.tablaProformas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAñadir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProformasForm";
            this.Text = "ProformasForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProformas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbAsesor;
        private System.Windows.Forms.Label labelAT;
        private System.Windows.Forms.Label labelAD;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tablaProformas;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtCodigoCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelcodigocliente;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label direccionLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelCodigoServicio;
        private System.Windows.Forms.Label caracteristicasLabel;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label precioLabel;
        private System.Windows.Forms.Label velocidadLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.DateTimePicker fechaInicioPicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker fechaFinPicker;
        private System.Windows.Forms.Label labelAsesorID;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAñadir;
    }
}