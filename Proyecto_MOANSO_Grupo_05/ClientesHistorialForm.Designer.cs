namespace Proyecto_MOANSO_Grupo_05
{
    partial class ClientesHistorialForm
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
            this.tablaContratos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tablaContratos)).BeginInit();
            this.SuspendLayout();
            // 
            // tablaContratos
            // 
            this.tablaContratos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaContratos.Location = new System.Drawing.Point(12, 89);
            this.tablaContratos.Name = "tablaContratos";
            this.tablaContratos.Size = new System.Drawing.Size(536, 349);
            this.tablaContratos.TabIndex = 20;
            // 
            // ClientesHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.tablaContratos);
            this.Name = "ClientesHistorialForm";
            this.Text = "ClientesHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablaContratos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaContratos;
    }
}