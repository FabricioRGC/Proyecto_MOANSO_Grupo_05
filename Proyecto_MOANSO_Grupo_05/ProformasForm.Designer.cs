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
            this.tablaProformas = new System.Windows.Forms.DataGridView();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.cbPlan = new System.Windows.Forms.ComboBox();
            this.txtBuscarPlan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.tablaProformas)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaProformas
            // 
            this.tablaProformas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaProformas.Location = new System.Drawing.Point(12, 12);
            this.tablaProformas.Name = "tablaProformas";
            this.tablaProformas.Size = new System.Drawing.Size(536, 313);
            this.tablaProformas.TabIndex = 20;
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(687, 273);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(101, 52);
            this.btnAñadir.TabIndex = 21;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            this.btnAñadir.Click += new System.EventHandler(this.btnAñadir_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(572, 273);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(109, 52);
            this.button3.TabIndex = 23;
            this.button3.Text = "Inhabilitar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cbPlan
            // 
            this.cbPlan.FormattingEnabled = true;
            this.cbPlan.Location = new System.Drawing.Point(667, 154);
            this.cbPlan.Name = "cbPlan";
            this.cbPlan.Size = new System.Drawing.Size(121, 21);
            this.cbPlan.TabIndex = 38;
            // 
            // txtBuscarPlan
            // 
            this.txtBuscarPlan.Location = new System.Drawing.Point(643, 20);
            this.txtBuscarPlan.Name = "txtBuscarPlan";
            this.txtBuscarPlan.Size = new System.Drawing.Size(145, 20);
            this.txtBuscarPlan.TabIndex = 37;
            this.txtBuscarPlan.TextChanged += new System.EventHandler(this.txtBuscarCliente_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(569, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 36;
            this.label6.Text = "BUSCAR:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(569, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "TIPO DE PLAN:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(645, 113);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(145, 20);
            this.txtCliente.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(569, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "CLIENTE:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(569, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "PRECIO:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(645, 229);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(143, 20);
            this.txtPrecio.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(569, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "FECHA REGISTRO";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(676, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(193, 20);
            this.dateTimePicker1.TabIndex = 42;
            // 
            // ProformasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.ClientSize = new System.Drawing.Size(911, 374);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbPlan);
            this.Controls.Add(this.txtBuscarPlan);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.tablaProformas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProformasForm";
            this.Text = "ProformasForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProformas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProformas;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox cbPlan;
        private System.Windows.Forms.TextBox txtBuscarPlan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}