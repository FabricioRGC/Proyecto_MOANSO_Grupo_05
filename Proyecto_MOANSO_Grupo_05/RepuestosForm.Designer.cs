namespace Proyecto_MOANSO_Grupo_05
{
    partial class RepuestosForm
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
            this.btnRegistrarRepuesto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStockR = new System.Windows.Forms.TextBox();
            this.txtDescripción = new System.Windows.Forms.RichTextBox();
            this.dtpRepuestos = new System.Windows.Forms.DateTimePicker();
            this.txtCodigoRepuesto = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHistorial = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrarRepuesto
            // 
            this.btnRegistrarRepuesto.Location = new System.Drawing.Point(441, 468);
            this.btnRegistrarRepuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarRepuesto.Name = "btnRegistrarRepuesto";
            this.btnRegistrarRepuesto.Size = new System.Drawing.Size(148, 31);
            this.btnRegistrarRepuesto.TabIndex = 28;
            this.btnRegistrarRepuesto.Text = "Añadir";
            this.btnRegistrarRepuesto.UseVisualStyleBackColor = true;
            this.btnRegistrarRepuesto.Click += new System.EventHandler(this.btnRegistrarRepuesto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nombre del Repuesto: ";
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.Location = new System.Drawing.Point(192, 90);
            this.txtNombreRepuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(197, 22);
            this.txtNombreRepuesto.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(39, 135);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Fecha de registro";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(33, 48);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 16);
            this.label13.TabIndex = 2;
            this.label13.Text = "Codigo del repuesto:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 231);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 16);
            this.label12.TabIndex = 3;
            this.label12.Text = "Descripcion";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 181);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 16);
            this.label11.TabIndex = 4;
            this.label11.Text = "Cantidad en Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 229);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 16);
            this.label10.TabIndex = 6;
            // 
            // txtStockR
            // 
            this.txtStockR.Location = new System.Drawing.Point(192, 178);
            this.txtStockR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockR.Name = "txtStockR";
            this.txtStockR.Size = new System.Drawing.Size(197, 22);
            this.txtStockR.TabIndex = 27;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(29, 268);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(687, 138);
            this.txtDescripción.TabIndex = 12;
            this.txtDescripción.Text = "";
            // 
            // dtpRepuestos
            // 
            this.dtpRepuestos.Location = new System.Drawing.Point(192, 135);
            this.dtpRepuestos.Margin = new System.Windows.Forms.Padding(4);
            this.dtpRepuestos.Name = "dtpRepuestos";
            this.dtpRepuestos.Size = new System.Drawing.Size(255, 22);
            this.dtpRepuestos.TabIndex = 14;
            // 
            // txtCodigoRepuesto
            // 
            this.txtCodigoRepuesto.Location = new System.Drawing.Point(192, 48);
            this.txtCodigoRepuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoRepuesto.Name = "txtCodigoRepuesto";
            this.txtCodigoRepuesto.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoRepuesto.TabIndex = 36;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCodigoRepuesto);
            this.groupBox1.Controls.Add(this.dtpRepuestos);
            this.groupBox1.Controls.Add(this.txtDescripción);
            this.groupBox1.Controls.Add(this.txtStockR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtNombreRepuesto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(741, 435);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los materiales";
            // 
            // btnHistorial
            // 
            this.btnHistorial.Location = new System.Drawing.Point(606, 468);
            this.btnHistorial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHistorial.Name = "btnHistorial";
            this.btnHistorial.Size = new System.Drawing.Size(148, 31);
            this.btnHistorial.TabIndex = 39;
            this.btnHistorial.Text = "Ver Historial";
            this.btnHistorial.UseVisualStyleBackColor = true;
            this.btnHistorial.Click += new System.EventHandler(this.btnHistorial_Click_1);
            // 
            // RepuestosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(770, 522);
            this.Controls.Add(this.btnHistorial);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRegistrarRepuesto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RepuestosForm";
            this.Text = "RepuestosForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnRegistrarRepuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStockR;
        private System.Windows.Forms.RichTextBox txtDescripción;
        private System.Windows.Forms.DateTimePicker dtpRepuestos;
        private System.Windows.Forms.TextBox txtCodigoRepuesto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHistorial;
    }
}