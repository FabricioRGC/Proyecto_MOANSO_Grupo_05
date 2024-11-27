namespace Proyecto_MOANSO_Grupo_05
{
    partial class NotaDeSalidaForm
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
            this.labelCantidad = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.gbEleccionPedido = new System.Windows.Forms.GroupBox();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.cbRepuestos = new System.Windows.Forms.ComboBox();
            this.cbPedidoMateriales = new System.Windows.Forms.CheckBox();
            this.cbPedidoRepuestos = new System.Windows.Forms.CheckBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gbEleccionPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(231, 286);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(63, 16);
            this.labelCantidad.TabIndex = 44;
            this.labelCantidad.Text = "--------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.YellowGreen;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 16);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "--------------";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(231, 239);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(63, 16);
            this.labelProducto.TabIndex = 40;
            this.labelProducto.Text = "--------------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.YellowGreen;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 32;
            this.label7.Text = "SOLICITADO POR :";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new System.Drawing.Point(231, 196);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(63, 16);
            this.labelEmpleado.TabIndex = 41;
            this.labelEmpleado.Text = "--------------";
            // 
            // gbEleccionPedido
            // 
            this.gbEleccionPedido.Controls.Add(this.cbMateriales);
            this.gbEleccionPedido.Controls.Add(this.cbRepuestos);
            this.gbEleccionPedido.Controls.Add(this.cbPedidoMateriales);
            this.gbEleccionPedido.Controls.Add(this.cbPedidoRepuestos);
            this.gbEleccionPedido.Location = new System.Drawing.Point(30, 28);
            this.gbEleccionPedido.Name = "gbEleccionPedido";
            this.gbEleccionPedido.Size = new System.Drawing.Size(685, 86);
            this.gbEleccionPedido.TabIndex = 39;
            this.gbEleccionPedido.TabStop = false;
            // 
            // cbMateriales
            // 
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(497, 36);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(169, 24);
            this.cbMateriales.TabIndex = 29;
            // 
            // cbRepuestos
            // 
            this.cbRepuestos.FormattingEnabled = true;
            this.cbRepuestos.Location = new System.Drawing.Point(289, 36);
            this.cbRepuestos.Name = "cbRepuestos";
            this.cbRepuestos.Size = new System.Drawing.Size(169, 24);
            this.cbRepuestos.TabIndex = 28;
            // 
            // cbPedidoMateriales
            // 
            this.cbPedidoMateriales.AutoSize = true;
            this.cbPedidoMateriales.Location = new System.Drawing.Point(147, 38);
            this.cbPedidoMateriales.Name = "cbPedidoMateriales";
            this.cbPedidoMateriales.Size = new System.Drawing.Size(92, 20);
            this.cbPedidoMateriales.TabIndex = 27;
            this.cbPedidoMateriales.Text = "Materiales";
            this.cbPedidoMateriales.UseVisualStyleBackColor = true;
            // 
            // cbPedidoRepuestos
            // 
            this.cbPedidoRepuestos.AutoSize = true;
            this.cbPedidoRepuestos.Location = new System.Drawing.Point(29, 38);
            this.cbPedidoRepuestos.Name = "cbPedidoRepuestos";
            this.cbPedidoRepuestos.Size = new System.Drawing.Size(95, 20);
            this.cbPedidoRepuestos.TabIndex = 26;
            this.cbPedidoRepuestos.Text = "Repuestos";
            this.cbPedidoRepuestos.UseVisualStyleBackColor = true;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btAgregar.Location = new System.Drawing.Point(586, 265);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(110, 37);
            this.btAgregar.TabIndex = 38;
            this.btAgregar.Text = "Grabar";
            this.btAgregar.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 140);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "FECHA \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 34;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 368);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 251);
            this.dataGridView1.TabIndex = 45;
            // 
            // NotaDeSalidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(750, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelEmpleado);
            this.Controls.Add(this.gbEleccionPedido);
            this.Controls.Add(this.btAgregar);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NotaDeSalidaForm";
            this.Text = "NotaDeSalidaForm";
            this.gbEleccionPedido.ResumeLayout(false);
            this.gbEleccionPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.GroupBox gbEleccionPedido;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.ComboBox cbRepuestos;
        private System.Windows.Forms.CheckBox cbPedidoMateriales;
        private System.Windows.Forms.CheckBox cbPedidoRepuestos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}