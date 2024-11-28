namespace Proyecto_MOANSO_Grupo_05
{
    partial class PedidoInstalacionForm
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
            this.btnTerminarPedido = new System.Windows.Forms.Button();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboTipoInstalacion = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPedidoInstalacion = new System.Windows.Forms.TextBox();
            this.dataGridOrPeInstalacion = new System.Windows.Forms.DataGridView();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.labelContratoID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dniClienteLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboCliente = new System.Windows.Forms.ComboBox();
            this.estadoClienteLabel = new System.Windows.Forms.Label();
            this.telefonoClienteLabel = new System.Windows.Forms.Label();
            this.direccionClienteLabel = new System.Windows.Forms.Label();
            this.codigoClienteLabel = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.dniLabel = new System.Windows.Forms.Label();
            this.cboTecnicos = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.estadoLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.areaTrabajoLabel = new System.Windows.Forms.Label();
            this.tipoCargoLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeInstalacion)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTerminarPedido
            // 
            this.btnTerminarPedido.BackColor = System.Drawing.Color.YellowGreen;
            this.btnTerminarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarPedido.Location = new System.Drawing.Point(794, 617);
            this.btnTerminarPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTerminarPedido.Name = "btnTerminarPedido";
            this.btnTerminarPedido.Size = new System.Drawing.Size(159, 32);
            this.btnTerminarPedido.TabIndex = 34;
            this.btnTerminarPedido.Text = "Terminar Pedido";
            this.btnTerminarPedido.UseVisualStyleBackColor = false;
            this.btnTerminarPedido.Click += new System.EventHandler(this.btnTerminarPedido_Click);
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(265, 66);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(198, 22);
            this.dtpFin.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.YellowGreen;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(154, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha de Fin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(148, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Fecha de Inicio:";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(265, 33);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 22);
            this.dtpInicio.TabIndex = 18;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpFin);
            this.groupBox2.Controls.Add(this.cboTipoInstalacion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpInicio);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(16, 324);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(937, 111);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalles de la Instalación:";
            // 
            // cboTipoInstalacion
            // 
            this.cboTipoInstalacion.FormattingEnabled = true;
            this.cboTipoInstalacion.Location = new System.Drawing.Point(634, 45);
            this.cboTipoInstalacion.Name = "cboTipoInstalacion";
            this.cboTipoInstalacion.Size = new System.Drawing.Size(198, 24);
            this.cboTipoInstalacion.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.YellowGreen;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(504, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tipo de Instalación:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 229);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 16);
            this.label11.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(19, 449);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 36;
            this.label7.Text = "Buscar:";
            // 
            // txtPedidoInstalacion
            // 
            this.txtPedidoInstalacion.Location = new System.Drawing.Point(79, 447);
            this.txtPedidoInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtPedidoInstalacion.Name = "txtPedidoInstalacion";
            this.txtPedidoInstalacion.Size = new System.Drawing.Size(224, 22);
            this.txtPedidoInstalacion.TabIndex = 35;
            this.txtPedidoInstalacion.TextChanged += new System.EventHandler(this.txtPedidoInstalacion_TextChanged);
            // 
            // dataGridOrPeInstalacion
            // 
            this.dataGridOrPeInstalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrPeInstalacion.Location = new System.Drawing.Point(22, 482);
            this.dataGridOrPeInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrPeInstalacion.Name = "dataGridOrPeInstalacion";
            this.dataGridOrPeInstalacion.RowHeadersWidth = 57;
            this.dataGridOrPeInstalacion.Size = new System.Drawing.Size(931, 129);
            this.dataGridOrPeInstalacion.TabIndex = 22;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.059701F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(312, 438);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(163, 38);
            this.btnRegistrar.TabIndex = 29;
            this.btnRegistrar.Text = "Agregar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.dniLabel);
            this.groupBox3.Controls.Add(this.cboTecnicos);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.estadoLabel);
            this.groupBox3.Controls.Add(this.telefonoLabel);
            this.groupBox3.Controls.Add(this.areaTrabajoLabel);
            this.groupBox3.Controls.Add(this.tipoCargoLabel);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(16, 2);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(937, 318);
            this.groupBox3.TabIndex = 46;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Tecnico";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Olive;
            this.groupBox4.Controls.Add(this.labelContratoID);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.dniClienteLabel);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.cboCliente);
            this.groupBox4.Controls.Add(this.estadoClienteLabel);
            this.groupBox4.Controls.Add(this.telefonoClienteLabel);
            this.groupBox4.Controls.Add(this.direccionClienteLabel);
            this.groupBox4.Controls.Add(this.codigoClienteLabel);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(425, 31);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(490, 265);
            this.groupBox4.TabIndex = 57;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Detalles del Cliente";
            // 
            // labelContratoID
            // 
            this.labelContratoID.AutoSize = true;
            this.labelContratoID.ForeColor = System.Drawing.Color.White;
            this.labelContratoID.Location = new System.Drawing.Point(376, 199);
            this.labelContratoID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContratoID.Name = "labelContratoID";
            this.labelContratoID.Size = new System.Drawing.Size(0, 16);
            this.labelContratoID.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(286, 199);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 53;
            this.label3.Text = "Contrato:";
            // 
            // dniClienteLabel
            // 
            this.dniClienteLabel.AutoSize = true;
            this.dniClienteLabel.ForeColor = System.Drawing.Color.White;
            this.dniClienteLabel.Location = new System.Drawing.Point(110, 113);
            this.dniClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dniClienteLabel.Name = "dniClienteLabel";
            this.dniClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.dniClienteLabel.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(20, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Dni:";
            // 
            // cboCliente
            // 
            this.cboCliente.FormattingEnabled = true;
            this.cboCliente.Location = new System.Drawing.Point(82, 54);
            this.cboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cboCliente.Name = "cboCliente";
            this.cboCliente.Size = new System.Drawing.Size(185, 24);
            this.cboCliente.TabIndex = 43;
            this.cboCliente.SelectedIndexChanged += new System.EventHandler(this.cbCliente_SelectedIndexChanged);
            // 
            // estadoClienteLabel
            // 
            this.estadoClienteLabel.AutoSize = true;
            this.estadoClienteLabel.ForeColor = System.Drawing.Color.White;
            this.estadoClienteLabel.Location = new System.Drawing.Point(376, 156);
            this.estadoClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoClienteLabel.Name = "estadoClienteLabel";
            this.estadoClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.estadoClienteLabel.TabIndex = 50;
            // 
            // telefonoClienteLabel
            // 
            this.telefonoClienteLabel.AutoSize = true;
            this.telefonoClienteLabel.ForeColor = System.Drawing.Color.White;
            this.telefonoClienteLabel.Location = new System.Drawing.Point(376, 113);
            this.telefonoClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonoClienteLabel.Name = "telefonoClienteLabel";
            this.telefonoClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.telefonoClienteLabel.TabIndex = 49;
            // 
            // direccionClienteLabel
            // 
            this.direccionClienteLabel.AutoSize = true;
            this.direccionClienteLabel.ForeColor = System.Drawing.Color.White;
            this.direccionClienteLabel.Location = new System.Drawing.Point(110, 199);
            this.direccionClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.direccionClienteLabel.Name = "direccionClienteLabel";
            this.direccionClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.direccionClienteLabel.TabIndex = 48;
            // 
            // codigoClienteLabel
            // 
            this.codigoClienteLabel.AutoSize = true;
            this.codigoClienteLabel.ForeColor = System.Drawing.Color.White;
            this.codigoClienteLabel.Location = new System.Drawing.Point(110, 156);
            this.codigoClienteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codigoClienteLabel.Name = "codigoClienteLabel";
            this.codigoClienteLabel.Size = new System.Drawing.Size(0, 16);
            this.codigoClienteLabel.TabIndex = 47;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.YellowGreen;
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(286, 156);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(53, 16);
            this.label17.TabIndex = 46;
            this.label17.Text = "Estado:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.YellowGreen;
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(286, 113);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 16);
            this.label18.TabIndex = 45;
            this.label18.Text = "Teléfono:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.YellowGreen;
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(20, 199);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(67, 16);
            this.label19.TabIndex = 44;
            this.label19.Text = "Dirección:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.YellowGreen;
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(20, 156);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 16);
            this.label20.TabIndex = 43;
            this.label20.Text = "Codigo:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.YellowGreen;
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(20, 57);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(51, 16);
            this.label21.TabIndex = 24;
            this.label21.Text = "Cliente:";
            // 
            // dniLabel
            // 
            this.dniLabel.AutoSize = true;
            this.dniLabel.ForeColor = System.Drawing.Color.White;
            this.dniLabel.Location = new System.Drawing.Point(168, 84);
            this.dniLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dniLabel.Name = "dniLabel";
            this.dniLabel.Size = new System.Drawing.Size(0, 16);
            this.dniLabel.TabIndex = 52;
            // 
            // cboTecnicos
            // 
            this.cboTecnicos.FormattingEnabled = true;
            this.cboTecnicos.Location = new System.Drawing.Point(205, 42);
            this.cboTecnicos.Name = "cboTecnicos";
            this.cboTecnicos.Size = new System.Drawing.Size(188, 24);
            this.cboTecnicos.TabIndex = 56;
            this.cboTecnicos.SelectedIndexChanged += new System.EventHandler(this.cboTecnico_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.YellowGreen;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(64, 84);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(30, 16);
            this.label15.TabIndex = 51;
            this.label15.Text = "Dni:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(64, 45);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 49;
            this.label4.Text = "Tecnico Asignado:";
            // 
            // estadoLabel
            // 
            this.estadoLabel.AutoSize = true;
            this.estadoLabel.ForeColor = System.Drawing.Color.White;
            this.estadoLabel.Location = new System.Drawing.Point(169, 172);
            this.estadoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.estadoLabel.Name = "estadoLabel";
            this.estadoLabel.Size = new System.Drawing.Size(0, 16);
            this.estadoLabel.TabIndex = 50;
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.ForeColor = System.Drawing.Color.White;
            this.telefonoLabel.Location = new System.Drawing.Point(169, 127);
            this.telefonoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(0, 16);
            this.telefonoLabel.TabIndex = 49;
            // 
            // areaTrabajoLabel
            // 
            this.areaTrabajoLabel.AutoSize = true;
            this.areaTrabajoLabel.ForeColor = System.Drawing.Color.White;
            this.areaTrabajoLabel.Location = new System.Drawing.Point(171, 264);
            this.areaTrabajoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.areaTrabajoLabel.Name = "areaTrabajoLabel";
            this.areaTrabajoLabel.Size = new System.Drawing.Size(0, 16);
            this.areaTrabajoLabel.TabIndex = 48;
            // 
            // tipoCargoLabel
            // 
            this.tipoCargoLabel.AutoSize = true;
            this.tipoCargoLabel.ForeColor = System.Drawing.Color.White;
            this.tipoCargoLabel.Location = new System.Drawing.Point(169, 218);
            this.tipoCargoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tipoCargoLabel.Name = "tipoCargoLabel";
            this.tipoCargoLabel.Size = new System.Drawing.Size(0, 16);
            this.tipoCargoLabel.TabIndex = 47;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.YellowGreen;
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(64, 172);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 16);
            this.label13.TabIndex = 46;
            this.label13.Text = "Estado:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.YellowGreen;
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(64, 127);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 16);
            this.label12.TabIndex = 45;
            this.label12.Text = "Teléfono:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.YellowGreen;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(66, 264);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 16);
            this.label14.TabIndex = 44;
            this.label14.Text = "Area Trabajo:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.YellowGreen;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(64, 218);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(78, 16);
            this.label16.TabIndex = 43;
            this.label16.Text = "Tipo Cargo:";
            // 
            // PedidoInstalacionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(966, 654);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtPedidoInstalacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridOrPeInstalacion);
            this.Controls.Add(this.btnTerminarPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PedidoInstalacionForm";
            this.Text = "OrdenesPedidoInstalacionForm";
            this.Load += new System.EventHandler(this.OrdenesPedidoInstalacionForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeInstalacion)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTerminarPedido;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboTipoInstalacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label dniLabel;
        private System.Windows.Forms.ComboBox cboTecnicos;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label estadoLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.Label areaTrabajoLabel;
        private System.Windows.Forms.Label tipoCargoLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label dniClienteLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboCliente;
        private System.Windows.Forms.Label estadoClienteLabel;
        private System.Windows.Forms.Label telefonoClienteLabel;
        private System.Windows.Forms.Label direccionClienteLabel;
        private System.Windows.Forms.Label codigoClienteLabel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DataGridView dataGridOrPeInstalacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPedidoInstalacion;
        private System.Windows.Forms.Label labelContratoID;
        private System.Windows.Forms.Label label3;
    }
}