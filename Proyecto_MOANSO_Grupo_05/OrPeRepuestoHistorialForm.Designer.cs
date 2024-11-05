namespace Proyecto_MOANSO_Grupo_05
{
    partial class OrPeRepuestoHistorialForm
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
            this.dataGridRepuestos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdRepuestos = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridRepuestos
            // 
            this.dataGridRepuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRepuestos.Location = new System.Drawing.Point(17, 52);
            this.dataGridRepuestos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridRepuestos.Name = "dataGridRepuestos";
            this.dataGridRepuestos.RowHeadersWidth = 57;
            this.dataGridRepuestos.RowTemplate.Height = 24;
            this.dataGridRepuestos.Size = new System.Drawing.Size(1145, 475);
            this.dataGridRepuestos.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(566, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(204, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Buscar Por Codigo de Repuesto:\r\n";
            // 
            // txtIdRepuestos
            // 
            this.txtIdRepuestos.Location = new System.Drawing.Point(778, 15);
            this.txtIdRepuestos.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdRepuestos.Name = "txtIdRepuestos";
            this.txtIdRepuestos.Size = new System.Drawing.Size(208, 22);
            this.txtIdRepuestos.TabIndex = 34;
            this.txtIdRepuestos.TextChanged += new System.EventHandler(this.txtIdRepuestos_TextChanged);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(1004, 12);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(134, 28);
            this.btnAnular.TabIndex = 33;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // OrPeRepuestoHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1179, 554);
            this.Controls.Add(this.dataGridRepuestos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdRepuestos);
            this.Controls.Add(this.btnAnular);
            this.Name = "OrPeRepuestoHistorialForm";
            this.Text = "OrPeRepuestoHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRepuestos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRepuestos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdRepuestos;
        private System.Windows.Forms.Button btnAnular;
    }
}