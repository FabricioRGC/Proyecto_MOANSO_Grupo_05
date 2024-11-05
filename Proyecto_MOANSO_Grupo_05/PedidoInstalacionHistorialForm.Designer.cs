namespace Proyecto_MOANSO_Grupo_05
{
    partial class PedidoInstalacionHistorialForm
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
            this.btnInhabilitar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSelecId = new System.Windows.Forms.TextBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridOrPeInstalacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeInstalacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(640, 19);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(100, 28);
            this.btnInhabilitar.TabIndex = 20;
            this.btnInhabilitar.Text = "Inhabilitar";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id de Instalacion:";
            // 
            // txtSelecId
            // 
            this.txtSelecId.Location = new System.Drawing.Point(472, 23);
            this.txtSelecId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecId.Name = "txtSelecId";
            this.txtSelecId.Size = new System.Drawing.Size(132, 22);
            this.txtSelecId.TabIndex = 18;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(114, 23);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(132, 22);
            this.txtBuscar.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Buscar";
            // 
            // dataGridOrPeInstalacion
            // 
            this.dataGridOrPeInstalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrPeInstalacion.Location = new System.Drawing.Point(53, 67);
            this.dataGridOrPeInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrPeInstalacion.Name = "dataGridOrPeInstalacion";
            this.dataGridOrPeInstalacion.RowHeadersWidth = 57;
            this.dataGridOrPeInstalacion.Size = new System.Drawing.Size(699, 465);
            this.dataGridOrPeInstalacion.TabIndex = 15;
            // 
            // PedidoInstalacionHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 557);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelecId);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridOrPeInstalacion);
            this.Name = "PedidoInstalacionHistorialForm";
            this.Text = "PedidoInstalacionHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeInstalacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInhabilitar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSelecId;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridOrPeInstalacion;
    }
}