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
            this.txtBuscarRepuesto = new System.Windows.Forms.TextBox();
            this.dataGridRepuestos2 = new System.Windows.Forms.DataGridView();
            this.txtNombreRepuesto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtStockR = new System.Windows.Forms.TextBox();
            this.txtDescripción = new System.Windows.Forms.RichTextBox();
            this.txtCodigoRepuesto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCategoriaRep = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodRepInhabilitar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBuscarRepuesto
            // 
            this.txtBuscarRepuesto.Location = new System.Drawing.Point(252, 441);
            this.txtBuscarRepuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRepuesto.Name = "txtBuscarRepuesto";
            this.txtBuscarRepuesto.Size = new System.Drawing.Size(164, 22);
            this.txtBuscarRepuesto.TabIndex = 40;
            this.txtBuscarRepuesto.TextChanged += new System.EventHandler(this.txtBuscarRepuesto_TextChanged);
            // 
            // dataGridRepuestos2
            // 
            this.dataGridRepuestos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuestos2.Location = new System.Drawing.Point(172, 538);
            this.dataGridRepuestos2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridRepuestos2.Name = "dataGridRepuestos2";
            this.dataGridRepuestos2.RowHeadersWidth = 57;
            this.dataGridRepuestos2.Size = new System.Drawing.Size(742, 187);
            this.dataGridRepuestos2.TabIndex = 37;
            // 
            // txtNombreRepuesto
            // 
            this.txtNombreRepuesto.Location = new System.Drawing.Point(194, 92);
            this.txtNombreRepuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreRepuesto.Name = "txtNombreRepuesto";
            this.txtNombreRepuesto.Size = new System.Drawing.Size(197, 22);
            this.txtNombreRepuesto.TabIndex = 7;
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
            this.txtStockR.Location = new System.Drawing.Point(194, 188);
            this.txtStockR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStockR.Name = "txtStockR";
            this.txtStockR.Size = new System.Drawing.Size(197, 22);
            this.txtStockR.TabIndex = 27;
            // 
            // txtDescripción
            // 
            this.txtDescripción.Location = new System.Drawing.Point(29, 261);
            this.txtDescripción.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDescripción.Name = "txtDescripción";
            this.txtDescripción.Size = new System.Drawing.Size(687, 125);
            this.txtDescripción.TabIndex = 12;
            this.txtDescripción.Text = "";
            // 
            // txtCodigoRepuesto
            // 
            this.txtCodigoRepuesto.Location = new System.Drawing.Point(194, 50);
            this.txtCodigoRepuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodigoRepuesto.Name = "txtCodigoRepuesto";
            this.txtCodigoRepuesto.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoRepuesto.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.YellowGreen;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(41, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 16);
            this.label1.TabIndex = 37;
            this.label1.Text = "Codigo del Repuesto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.YellowGreen;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(36, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Nombre del Repuesto: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBoxCategoriaRep);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtCodigoRepuesto);
            this.groupBox1.Controls.Add(this.txtDescripción);
            this.groupBox1.Controls.Add(this.txtStockR);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtNombreRepuesto);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(173, 3);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(741, 408);
            this.groupBox1.TabIndex = 38;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de los Repuestos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.YellowGreen;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(55, 145);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 39;
            this.label3.Text = "Tipo de Repuesto:";
            // 
            // comboBoxCategoriaRep
            // 
            this.comboBoxCategoriaRep.FormattingEnabled = true;
            this.comboBoxCategoriaRep.Location = new System.Drawing.Point(194, 137);
            this.comboBoxCategoriaRep.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxCategoriaRep.Name = "comboBoxCategoriaRep";
            this.comboBoxCategoriaRep.Size = new System.Drawing.Size(197, 24);
            this.comboBoxCategoriaRep.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.YellowGreen;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(76, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 41;
            this.label9.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.YellowGreen;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(34, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Descripcion";
            // 
            // btnAñadir
            // 
            this.btnAñadir.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAñadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAñadir.ForeColor = System.Drawing.Color.Black;
            this.btnAñadir.Location = new System.Drawing.Point(768, 421);
            this.btnAñadir.Margin = new System.Windows.Forms.Padding(4);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(146, 44);
            this.btnAñadir.TabIndex = 44;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.YellowGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(169, 443);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Buscar:";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(435, 429);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 44);
            this.btnModificar.TabIndex = 46;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.BackColor = System.Drawing.Color.YellowGreen;
            this.btnInhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInhabilitar.ForeColor = System.Drawing.Color.Black;
            this.btnInhabilitar.Location = new System.Drawing.Point(510, 481);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(116, 49);
            this.btnInhabilitar.TabIndex = 49;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.YellowGreen;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(168, 496);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 20);
            this.label2.TabIndex = 48;
            this.label2.Text = "Codigo de Repuesto:";
            // 
            // txtCodRepInhabilitar
            // 
            this.txtCodRepInhabilitar.Location = new System.Drawing.Point(354, 496);
            this.txtCodRepInhabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodRepInhabilitar.Name = "txtCodRepInhabilitar";
            this.txtCodRepInhabilitar.Size = new System.Drawing.Size(132, 22);
            this.txtCodRepInhabilitar.TabIndex = 47;
            // 
            // RepuestosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(1030, 747);
            this.Controls.Add(this.dataGridRepuestos2);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodRepInhabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBuscarRepuesto);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RepuestosForm";
            this.Text = "RepuestosForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarRepuesto;
        private System.Windows.Forms.DataGridView dataGridRepuestos2;
        private System.Windows.Forms.TextBox txtNombreRepuesto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtStockR;
        private System.Windows.Forms.RichTextBox txtDescripción;
        private System.Windows.Forms.TextBox txtCodigoRepuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCategoriaRep;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodRepInhabilitar;
    }
}