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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.txtRepuesto = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataGridRepuestos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(130, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha del Pedido:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cantidad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Repuesto ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(151, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estado:";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(264, 62);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 4;
            // 
            // cboEstado
            // 
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Location = new System.Drawing.Point(264, 203);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(200, 24);
            this.cboEstado.TabIndex = 5;
            // 
            // txtRepuesto
            // 
            this.txtRepuesto.Location = new System.Drawing.Point(264, 108);
            this.txtRepuesto.Name = "txtRepuesto";
            this.txtRepuesto.Size = new System.Drawing.Size(200, 22);
            this.txtRepuesto.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(264, 152);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(200, 22);
            this.txtCantidad.TabIndex = 7;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(516, 77);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(169, 48);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar Pedido";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(516, 152);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(169, 48);
            this.btnAnular.TabIndex = 9;
            this.btnAnular.Text = "Anular Pedido";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dataGridRepuestos
            // 
            this.dataGridRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuestos.Location = new System.Drawing.Point(45, 263);
            this.dataGridRepuestos.Name = "dataGridRepuestos";
            this.dataGridRepuestos.RowHeadersWidth = 57;
            this.dataGridRepuestos.RowTemplate.Height = 24;
            this.dataGridRepuestos.Size = new System.Drawing.Size(740, 251);
            this.dataGridRepuestos.TabIndex = 10;
            // 
            // OrdenPedidoRepuestoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 544);
            this.Controls.Add(this.dataGridRepuestos);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtRepuesto);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "OrdenPedidoRepuestoForm";
            this.Text = "OrdenPedidoRepuestoForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.TextBox txtRepuesto;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dataGridRepuestos;
    }
}