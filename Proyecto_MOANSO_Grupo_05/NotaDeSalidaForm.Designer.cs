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
            this.lbProduct = new System.Windows.Forms.Label();
            this.labelProducto = new System.Windows.Forms.Label();
            this.labelEmple = new System.Windows.Forms.Label();
            this.labelEmpleado = new System.Windows.Forms.Label();
            this.gbEleccionPedido = new System.Windows.Forms.GroupBox();
            this.rbPedidoMateriales = new System.Windows.Forms.RadioButton();
            this.rbPedidoRepuestos = new System.Windows.Forms.RadioButton();
            this.cbMateriales = new System.Windows.Forms.ComboBox();
            this.cbRepuestos = new System.Windows.Forms.ComboBox();
            this.btAgregar = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TablaNotadeSalida = new System.Windows.Forms.DataGridView();
            this.Butonbuscar = new System.Windows.Forms.Button();
            this.gbEleccionPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotadeSalida)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(229, 234);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(63, 16);
            this.labelCantidad.TabIndex = 44;
            this.labelCantidad.Text = "--------------";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(37, 234);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 18);
            this.label10.TabIndex = 43;
            this.label10.Text = "Cantidad:";
            // 
            // lbProduct
            // 
            this.lbProduct.AutoSize = true;
            this.lbProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.lbProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProduct.Location = new System.Drawing.Point(37, 187);
            this.lbProduct.Name = "lbProduct";
            this.lbProduct.Size = new System.Drawing.Size(78, 18);
            this.lbProduct.TabIndex = 42;
            this.lbProduct.Text = "--------------";
            // 
            // labelProducto
            // 
            this.labelProducto.AutoSize = true;
            this.labelProducto.Location = new System.Drawing.Point(229, 187);
            this.labelProducto.Name = "labelProducto";
            this.labelProducto.Size = new System.Drawing.Size(63, 16);
            this.labelProducto.TabIndex = 40;
            this.labelProducto.Text = "--------------";
            // 
            // labelEmple
            // 
            this.labelEmple.AutoSize = true;
            this.labelEmple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.labelEmple.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmple.Location = new System.Drawing.Point(37, 144);
            this.labelEmple.Name = "labelEmple";
            this.labelEmple.Size = new System.Drawing.Size(141, 18);
            this.labelEmple.TabIndex = 32;
            this.labelEmple.Text = "SOLICITADO POR :";
            // 
            // labelEmpleado
            // 
            this.labelEmpleado.AutoSize = true;
            this.labelEmpleado.Location = new System.Drawing.Point(229, 144);
            this.labelEmpleado.Name = "labelEmpleado";
            this.labelEmpleado.Size = new System.Drawing.Size(63, 16);
            this.labelEmpleado.TabIndex = 41;
            this.labelEmpleado.Text = "--------------";
            // 
            // gbEleccionPedido
            // 
            this.gbEleccionPedido.Controls.Add(this.rbPedidoMateriales);
            this.gbEleccionPedido.Controls.Add(this.rbPedidoRepuestos);
            this.gbEleccionPedido.Controls.Add(this.cbMateriales);
            this.gbEleccionPedido.Controls.Add(this.cbRepuestos);
            this.gbEleccionPedido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbEleccionPedido.Location = new System.Drawing.Point(29, 28);
            this.gbEleccionPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEleccionPedido.Name = "gbEleccionPedido";
            this.gbEleccionPedido.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbEleccionPedido.Size = new System.Drawing.Size(685, 86);
            this.gbEleccionPedido.TabIndex = 39;
            this.gbEleccionPedido.TabStop = false;
            // 
            // rbPedidoMateriales
            // 
            this.rbPedidoMateriales.AutoSize = true;
            this.rbPedidoMateriales.Checked = true;
            this.rbPedidoMateriales.Location = new System.Drawing.Point(381, 36);
            this.rbPedidoMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPedidoMateriales.Name = "rbPedidoMateriales";
            this.rbPedidoMateriales.Size = new System.Drawing.Size(76, 20);
            this.rbPedidoMateriales.TabIndex = 31;
            this.rbPedidoMateriales.TabStop = true;
            this.rbPedidoMateriales.Text = "Material";
            this.rbPedidoMateriales.UseVisualStyleBackColor = true;
            this.rbPedidoMateriales.CheckedChanged += new System.EventHandler(this.rbPedidoMateriales_CheckedChanged);
            // 
            // rbPedidoRepuestos
            // 
            this.rbPedidoRepuestos.AutoSize = true;
            this.rbPedidoRepuestos.Location = new System.Drawing.Point(40, 38);
            this.rbPedidoRepuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rbPedidoRepuestos.Name = "rbPedidoRepuestos";
            this.rbPedidoRepuestos.Size = new System.Drawing.Size(94, 20);
            this.rbPedidoRepuestos.TabIndex = 30;
            this.rbPedidoRepuestos.Text = "Repuestos";
            this.rbPedidoRepuestos.UseVisualStyleBackColor = true;
            this.rbPedidoRepuestos.CheckedChanged += new System.EventHandler(this.rbPedidoRepuestos_CheckedChanged);
            // 
            // cbMateriales
            // 
            this.cbMateriales.FormattingEnabled = true;
            this.cbMateriales.Location = new System.Drawing.Point(497, 36);
            this.cbMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMateriales.Name = "cbMateriales";
            this.cbMateriales.Size = new System.Drawing.Size(169, 24);
            this.cbMateriales.TabIndex = 29;
            // 
            // cbRepuestos
            // 
            this.cbRepuestos.FormattingEnabled = true;
            this.cbRepuestos.Location = new System.Drawing.Point(140, 36);
            this.cbRepuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbRepuestos.Name = "cbRepuestos";
            this.cbRepuestos.Size = new System.Drawing.Size(169, 24);
            this.cbRepuestos.TabIndex = 28;
            // 
            // btAgregar
            // 
            this.btAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btAgregar.Location = new System.Drawing.Point(587, 265);
            this.btAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAgregar.Name = "btAgregar";
            this.btAgregar.Size = new System.Drawing.Size(109, 37);
            this.btAgregar.TabIndex = 38;
            this.btAgregar.Text = "Insertar";
            this.btAgregar.UseVisualStyleBackColor = false;
            this.btAgregar.Click += new System.EventHandler(this.btAgregar_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(232, 270);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
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
            // TablaNotadeSalida
            // 
            this.TablaNotadeSalida.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaNotadeSalida.Location = new System.Drawing.Point(12, 368);
            this.TablaNotadeSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TablaNotadeSalida.Name = "TablaNotadeSalida";
            this.TablaNotadeSalida.RowHeadersWidth = 51;
            this.TablaNotadeSalida.RowTemplate.Height = 24;
            this.TablaNotadeSalida.Size = new System.Drawing.Size(712, 251);
            this.TablaNotadeSalida.TabIndex = 45;
            // 
            // Butonbuscar
            // 
            this.Butonbuscar.Location = new System.Drawing.Point(459, 187);
            this.Butonbuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Butonbuscar.Name = "Butonbuscar";
            this.Butonbuscar.Size = new System.Drawing.Size(100, 28);
            this.Butonbuscar.TabIndex = 46;
            this.Butonbuscar.Text = "Buscar";
            this.Butonbuscar.UseVisualStyleBackColor = true;
            this.Butonbuscar.Click += new System.EventHandler(this.Butonbuscar_Click);
            // 
            // NotaDeSalidaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(246)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(749, 654);
            this.Controls.Add(this.Butonbuscar);
            this.Controls.Add(this.TablaNotadeSalida);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbProduct);
            this.Controls.Add(this.labelProducto);
            this.Controls.Add(this.labelEmple);
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
            ((System.ComponentModel.ISupportInitialize)(this.TablaNotadeSalida)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbProduct;
        private System.Windows.Forms.Label labelProducto;
        private System.Windows.Forms.Label labelEmple;
        private System.Windows.Forms.Label labelEmpleado;
        private System.Windows.Forms.GroupBox gbEleccionPedido;
        private System.Windows.Forms.ComboBox cbMateriales;
        private System.Windows.Forms.ComboBox cbRepuestos;
        private System.Windows.Forms.Button btAgregar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TablaNotadeSalida;
        private System.Windows.Forms.RadioButton rbPedidoMateriales;
        private System.Windows.Forms.RadioButton rbPedidoRepuestos;
        private System.Windows.Forms.Button Butonbuscar;
    }
}