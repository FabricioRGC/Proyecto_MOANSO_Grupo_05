namespace Proyecto_MOANSO_Grupo_05
{
    partial class OrdenPedidoMaterialForm
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
            this.txtCantidadSolicitada = new System.Windows.Forms.TextBox();
            this.txtIDMateriales = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCantidadEntregada = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonHistorialPeMat = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtObservaciones = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaRealizacion = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCantidadSolicitada
            // 
            this.txtCantidadSolicitada.Location = new System.Drawing.Point(190, 90);
            this.txtCantidadSolicitada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadSolicitada.Name = "txtCantidadSolicitada";
            this.txtCantidadSolicitada.Size = new System.Drawing.Size(200, 22);
            this.txtCantidadSolicitada.TabIndex = 17;
            // 
            // txtIDMateriales
            // 
            this.txtIDMateriales.Location = new System.Drawing.Point(190, 42);
            this.txtIDMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDMateriales.Name = "txtIDMateriales";
            this.txtIDMateriales.Size = new System.Drawing.Size(200, 22);
            this.txtIDMateriales.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Cantidad Solicitada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(69, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID Materiales:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIDCliente);
            this.groupBox1.Controls.Add(this.txtCantidadEntregada);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIDMateriales);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtCantidadSolicitada);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(22, 28);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(899, 172);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Pedido";
            // 
            // txtCantidadEntregada
            // 
            this.txtCantidadEntregada.Location = new System.Drawing.Point(588, 90);
            this.txtCantidadEntregada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCantidadEntregada.Name = "txtCantidadEntregada";
            this.txtCantidadEntregada.Size = new System.Drawing.Size(200, 22);
            this.txtCantidadEntregada.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(446, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 16);
            this.label5.TabIndex = 46;
            this.label5.Text = "Cantidad Entregada:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(472, 41);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 44;
            this.label4.Text = "ID Cliente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 229);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonHistorialPeMat);
            this.groupBox3.Controls.Add(this.btnRegistrar);
            this.groupBox3.Controls.Add(this.txtObservaciones);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.dtpFechaEntrega);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.dtpFechaRealizacion);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(22, 214);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(899, 356);
            this.groupBox3.TabIndex = 39;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalles del Pedido";
            // 
            // buttonHistorialPeMat
            // 
            this.buttonHistorialPeMat.ForeColor = System.Drawing.Color.Black;
            this.buttonHistorialPeMat.Location = new System.Drawing.Point(609, 304);
            this.buttonHistorialPeMat.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHistorialPeMat.Name = "buttonHistorialPeMat";
            this.buttonHistorialPeMat.Size = new System.Drawing.Size(127, 30);
            this.buttonHistorialPeMat.TabIndex = 39;
            this.buttonHistorialPeMat.Text = "Ver Historial";
            this.buttonHistorialPeMat.UseVisualStyleBackColor = true;
            this.buttonHistorialPeMat.Click += new System.EventHandler(this.buttonHistorialPeMat_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.ForeColor = System.Drawing.Color.Black;
            this.btnRegistrar.Location = new System.Drawing.Point(744, 304);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(127, 30);
            this.btnRegistrar.TabIndex = 38;
            this.btnRegistrar.Text = "Añadir";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(27, 122);
            this.txtObservaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(844, 162);
            this.txtObservaciones.TabIndex = 37;
            this.txtObservaciones.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(34, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Observaciones:";
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(627, 30);
            this.dtpFechaEntrega.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntrega.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(499, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 21;
            this.label6.Text = "Fecha Entrega:";
            // 
            // dtpFechaRealizacion
            // 
            this.dtpFechaRealizacion.Location = new System.Drawing.Point(152, 29);
            this.dtpFechaRealizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFechaRealizacion.Name = "dtpFechaRealizacion";
            this.dtpFechaRealizacion.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaRealizacion.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Fecha Realizacion:";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(588, 35);
            this.txtIDCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(200, 22);
            this.txtIDCliente.TabIndex = 48;
            // 
            // OrdenPedidoMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(942, 596);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OrdenPedidoMaterialForm";
            this.Text = "OrdenPedidoMaterialForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtCantidadSolicitada;
        private System.Windows.Forms.TextBox txtIDMateriales;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCantidadEntregada;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DateTimePicker dtpFechaRealizacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox txtObservaciones;
        private System.Windows.Forms.Button buttonHistorialPeMat;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtIDCliente;
    }
}