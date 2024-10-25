namespace Proyecto_MOANSO_Grupo_05
{
    partial class MaterialesForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGriMateriales = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.txtBuscarMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoM = new System.Windows.Forms.TextBox();
            this.txtNombreM = new System.Windows.Forms.TextBox();
            this.txtDescripcionM = new System.Windows.Forms.TextBox();
            this.txtstockM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CBMateriales = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGriMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(690, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Añadir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(690, 159);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGriMateriales
            // 
            this.dataGriMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGriMateriales.Location = new System.Drawing.Point(32, 86);
            this.dataGriMateriales.Name = "dataGriMateriales";
            this.dataGriMateriales.Size = new System.Drawing.Size(426, 175);
            this.dataGriMateriales.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(690, 201);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txtBuscarMa
            // 
            this.txtBuscarMa.Location = new System.Drawing.Point(101, 34);
            this.txtBuscarMa.Name = "txtBuscarMa";
            this.txtBuscarMa.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarMa.TabIndex = 4;
            this.txtBuscarMa.TextChanged += new System.EventHandler(this.txtBuscarMa_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar";
            // 
            // txtCodigoM
            // 
            this.txtCodigoM.Location = new System.Drawing.Point(541, 98);
            this.txtCodigoM.Name = "txtCodigoM";
            this.txtCodigoM.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoM.TabIndex = 6;
            // 
            // txtNombreM
            // 
            this.txtNombreM.Location = new System.Drawing.Point(541, 133);
            this.txtNombreM.Name = "txtNombreM";
            this.txtNombreM.Size = new System.Drawing.Size(100, 20);
            this.txtNombreM.TabIndex = 7;
            // 
            // txtDescripcionM
            // 
            this.txtDescripcionM.Location = new System.Drawing.Point(541, 178);
            this.txtDescripcionM.Name = "txtDescripcionM";
            this.txtDescripcionM.Size = new System.Drawing.Size(100, 20);
            this.txtDescripcionM.TabIndex = 8;
            // 
            // txtstockM
            // 
            this.txtstockM.Location = new System.Drawing.Point(541, 223);
            this.txtstockM.Name = "txtstockM";
            this.txtstockM.Size = new System.Drawing.Size(100, 20);
            this.txtstockM.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Codigo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(468, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Descipcion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(468, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Stock";
            // 
            // CBMateriales
            // 
            this.CBMateriales.FormattingEnabled = true;
            this.CBMateriales.Items.AddRange(new object[] {
            "I",
            "A"});
            this.CBMateriales.Location = new System.Drawing.Point(539, 268);
            this.CBMateriales.Name = "CBMateriales";
            this.CBMateriales.Size = new System.Drawing.Size(121, 21);
            this.CBMateriales.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(480, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Estado";
            // 
            // MaterialesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBMateriales);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtstockM);
            this.Controls.Add(this.txtDescripcionM);
            this.Controls.Add(this.txtNombreM);
            this.Controls.Add(this.txtCodigoM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarMa);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGriMateriales);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MaterialesForm";
            this.Text = "MaterialesFrom";
            ((System.ComponentModel.ISupportInitialize)(this.dataGriMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGriMateriales;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtBuscarMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoM;
        private System.Windows.Forms.TextBox txtNombreM;
        private System.Windows.Forms.TextBox txtDescripcionM;
        private System.Windows.Forms.TextBox txtstockM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox CBMateriales;
        private System.Windows.Forms.Label label6;
    }
}