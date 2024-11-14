namespace Proyecto_MOANSO_Grupo_05
{
    partial class OrdenPedidoRepuestoForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cboRepuestos = new System.Windows.Forms.ComboBox();
            this.btnTerminarPedido = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CodigoRepuesto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.stockRepuesto = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tipoCargoLabel = new System.Windows.Forms.Label();
            this.areaTrabajoLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTecnico = new System.Windows.Forms.ComboBox();
            this.dniLabel = new System.Windows.Forms.Label();
            this.dataGridRepuestos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRepuestos = new System.Windows.Forms.TextBox();
            this.dtpFechaRegistroRepuesto = new System.Windows.Forms.DateTimePicker();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(55, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Nombre Repuesto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtRepuestos);
            this.groupBox3.Controls.Add(this.dataGridRepuestos);
            this.groupBox3.Controls.Add(this.btnTerminarPedido);
            this.groupBox3.Controls.Add(this.btnAñadir);
            this.groupBox3.Controls.Add(this.dtpFechaEntrega);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.dtpFechaRealizacion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(27, 323);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(905, 427);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Pedido";
            // 
            // btnAñadir
            // 
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Location = new System.Drawing.Point(381, 47);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(166, 30);
            this.btnAñadir.TabIndex = 40;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(161, 71);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntrega.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(43, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Entrega:";
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(161, 34);
            this.dtpFechaRealizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRealizacion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Realizacion:";
            // 
            // cboRepuestos
            // 
            this.cboRepuestos.FormattingEnabled = true;
            this.cboRepuestos.Location = new System.Drawing.Point(180, 61);
            this.cboRepuestos.Name = "cboRepuestos";
            this.cboRepuestos.Size = new System.Drawing.Size(196, 24);
            this.cboRepuestos.TabIndex = 55;
            this.cboRepuestos.SelectedIndexChanged += new System.EventHandler(this.cboRepuestos_SelectedIndexChanged);
            // 
            // btnTerminarPedido
            // 
            this.btnTerminarPedido.ForeColor = System.Drawing.Color.Black;
            this.btnTerminarPedido.Location = new System.Drawing.Point(736, 386);
            this.btnTerminarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnTerminarPedido.Name = "btnTerminarPedido";
            this.btnTerminarPedido.Size = new System.Drawing.Size(142, 30);
            this.btnTerminarPedido.TabIndex = 42;
            this.btnTerminarPedido.Text = "Terminar Pedido";
            this.btnTerminarPedido.UseVisualStyleBackColor = true;
            this.btnTerminarPedido.Click += new System.EventHandler(this.btnTerminarPedido_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtpFechaRegistroRepuesto);
            this.groupBox4.Controls.Add(this.CodigoRepuesto);
            this.groupBox4.Controls.Add(this.cboRepuestos);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.stockRepuesto);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.label22);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(422, 29);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(443, 255);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles del Repuesto";
            // 
            // CodigoRepuesto
            // 
            this.CodigoRepuesto.AutoSize = true;
            this.CodigoRepuesto.ForeColor = System.Drawing.Color.White;
            this.CodigoRepuesto.Location = new System.Drawing.Point(187, 108);
            this.CodigoRepuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CodigoRepuesto.Name = "CodigoRepuesto";
            this.CodigoRepuesto.Size = new System.Drawing.Size(0, 16);
            this.CodigoRepuesto.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(55, 108);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 51;
            this.label9.Text = "Codigo:";
            // 
            // stockRepuesto
            // 
            this.stockRepuesto.AutoSize = true;
            this.stockRepuesto.ForeColor = System.Drawing.Color.White;
            this.stockRepuesto.Location = new System.Drawing.Point(189, 194);
            this.stockRepuesto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stockRepuesto.Name = "stockRepuesto";
            this.stockRepuesto.Size = new System.Drawing.Size(0, 16);
            this.stockRepuesto.TabIndex = 48;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(55, 194);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(44, 16);
            this.label21.TabIndex = 44;
            this.label21.Text = "Stock:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(55, 151);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(102, 16);
            this.label22.TabIndex = 43;
            this.label22.Text = "Fecha Registro:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dniLabel);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.cboTecnico);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.estadoLabel);
            this.groupBox2.Controls.Add(this.telefonoLabel);
            this.groupBox2.Controls.Add(this.areaTrabajoLabel);
            this.groupBox2.Controls.Add(this.tipoCargoLabel);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(27, 13);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(901, 302);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles del Tecnico";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 218);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Tipo Cargo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(27, 264);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 16);
            this.label11.TabIndex = 44;
            this.label11.Text = "Area Trabajo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(25, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Teléfono:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(25, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Estado:";
            // 
            // tipoCargoLabel
            // 
            this.tipoCargoLabel.AutoSize = true;
            this.tipoCargoLabel.ForeColor = System.Drawing.Color.White;
            this.tipoCargoLabel.Location = new System.Drawing.Point(130, 218);
            this.tipoCargoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoCargoLabel.Name = "tipoCargoLabel";
            this.tipoCargoLabel.Size = new System.Drawing.Size(0, 16);
            this.tipoCargoLabel.TabIndex = 47;
            // 
            // areaTrabajoLabel
            // 
            this.areaTrabajoLabel.AutoSize = true;
            this.areaTrabajoLabel.ForeColor = System.Drawing.Color.White;
            this.areaTrabajoLabel.Location = new System.Drawing.Point(132, 264);
            this.areaTrabajoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaTrabajoLabel.Name = "areaTrabajoLabel";
            this.areaTrabajoLabel.Size = new System.Drawing.Size(0, 16);
            this.areaTrabajoLabel.TabIndex = 48;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.ForeColor = System.Drawing.Color.White;
            this.telefonoLabel.Location = new System.Drawing.Point(130, 127);
            this.telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(0, 16);
            this.telefonoLabel.TabIndex = 49;
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.ForeColor = System.Drawing.Color.White;
            this.estadoLabel.Location = new System.Drawing.Point(130, 172);
            this.estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(0, 16);
            this.estadoLabel.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 45);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 16);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tecnico Asignado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(25, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Dni:";
            // 
            // cboTecnico
            // 
            this.cboTecnico.FormattingEnabled = true;
            this.cboTecnico.Location = new System.Drawing.Point(152, 42);
            this.cboTecnico.Name = "cboTecnico";
            this.cboTecnico.Size = new System.Drawing.Size(188, 24);
            this.cboTecnico.TabIndex = 56;
            this.cboTecnico.SelectedIndexChanged += new System.EventHandler(this.cboTecnico_SelectedIndexChanged);
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.ForeColor = System.Drawing.Color.White;
            this.dniLabel.Location = new System.Drawing.Point(129, 84);
            this.dniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(0, 16);
            this.dniLabel.TabIndex = 52;
            // 
            // dataGridRepuestos
            // 
            this.dataGridRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuestos.Location = new System.Drawing.Point(27, 145);
            this.dataGridRepuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRepuestos.Name = "dataGridRepuestos";
            this.dataGridRepuestos.RowHeadersWidth = 57;
            this.dataGridRepuestos.RowTemplate.Height = 24;
            this.dataGridRepuestos.Size = new System.Drawing.Size(851, 235);
            this.dataGridRepuestos.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(446, 117);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(204, 16);
            this.label4.TabIndex = 46;
            this.label4.Text = "Buscar Por Codigo de Repuesto:\r\n";
            // 
            // txtRepuestos
            // 
            this.txtRepuestos.Location = new System.Drawing.Point(658, 114);
            this.txtRepuestos.Margin = new System.Windows.Forms.Padding(4);
            this.txtRepuestos.Name = "txtRepuestos";
            this.txtRepuestos.Size = new System.Drawing.Size(208, 22);
            this.txtRepuestos.TabIndex = 45;
            this.txtRepuestos.TextChanged += new System.EventHandler(this.txtIdRepuestos_TextChanged);
            // 
            // dtpFechaRegistroRepuesto
            // 
            this.dtpFechaRegistroRepuesto.Location = new System.Drawing.Point(178, 152);
            this.dtpFechaRegistroRepuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaRegistroRepuesto.Name = "dtpFechaRegistroRepuesto";
            this.dtpFechaRegistroRepuesto.Size = new System.Drawing.Size(198, 22);
            this.dtpFechaRegistroRepuesto.TabIndex = 47;
            // 
            // OrdenPedidoRepuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(961, 763);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdenPedidoRepuestoForm";
            this.Text = "OrdenPedidoRepuestoForm";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaRealizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.ComboBox cboRepuestos;
        private System.Windows.Forms.Button btnTerminarPedido;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label CodigoRepuesto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label stockRepuesto;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.ComboBox cboTecnico;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label areaTrabajoLabel;
        private System.Windows.Forms.Label tipoCargoLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataGridRepuestos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRepuestos;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistroRepuesto;
    }
}