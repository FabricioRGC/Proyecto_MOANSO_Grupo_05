namespace Proyecto_MOANSO_Grupo_05
{
    partial class RepuestoHistorialForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtBuscarRepuesto = new System.Windows.Forms.TextBox();
            this.dataGridRepuestos2 = new System.Windows.Forms.DataGridView();
            this.btnAnular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(287, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Codigo de Repuesto:";
            // 
            // txtBuscarRepuesto
            // 
            this.txtBuscarRepuesto.Location = new System.Drawing.Point(440, 25);
            this.txtBuscarRepuesto.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscarRepuesto.Name = "txtBuscarRepuesto";
            this.txtBuscarRepuesto.Size = new System.Drawing.Size(132, 22);
            this.txtBuscarRepuesto.TabIndex = 12;
            this.txtBuscarRepuesto.TextChanged += new System.EventHandler(this.txtBuscarRepuesto_TextChanged);
            // 
            // dataGridRepuestos2
            // 
            this.dataGridRepuestos2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuestos2.Location = new System.Drawing.Point(21, 69);
            this.dataGridRepuestos2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridRepuestos2.Name = "dataGridRepuestos2";
            this.dataGridRepuestos2.RowHeadersWidth = 57;
            this.dataGridRepuestos2.Size = new System.Drawing.Size(699, 465);
            this.dataGridRepuestos2.TabIndex = 9;
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(580, 22);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(134, 28);
            this.btnAnular.TabIndex = 30;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // RepuestoHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 560);
            this.Controls.Add(this.btnAnular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscarRepuesto);
            this.Controls.Add(this.dataGridRepuestos2);
            this.Name = "RepuestoHistorialForm";
            this.Text = "RepuestoHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBuscarRepuesto;
        private System.Windows.Forms.DataGridView dataGridRepuestos2;
        private System.Windows.Forms.Button btnAnular;
    }
}