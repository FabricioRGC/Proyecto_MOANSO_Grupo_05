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
            this.dataGridOrPeInstalacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeInstalacion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInhabilitar
            // 
            this.btnInhabilitar.Location = new System.Drawing.Point(899, 27);
            this.btnInhabilitar.Margin = new System.Windows.Forms.Padding(4);
            this.btnInhabilitar.Name = "btnInhabilitar";
            this.btnInhabilitar.Size = new System.Drawing.Size(227, 30);
            this.btnInhabilitar.TabIndex = 20;
            this.btnInhabilitar.Text = "Anular";
            this.btnInhabilitar.UseVisualStyleBackColor = true;
            this.btnInhabilitar.Click += new System.EventHandler(this.btnInhabilitar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(596, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Id de Instalacion:";
            // 
            // txtSelecId
            // 
            this.txtSelecId.Location = new System.Drawing.Point(711, 31);
            this.txtSelecId.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelecId.Name = "txtSelecId";
            this.txtSelecId.Size = new System.Drawing.Size(180, 22);
            this.txtSelecId.TabIndex = 18;
            this.txtSelecId.TextChanged += new System.EventHandler(this.txtSelecId_TextChanged);
            // 
            // dataGridOrPeInstalacion
            // 
            this.dataGridOrPeInstalacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrPeInstalacion.Location = new System.Drawing.Point(20, 67);
            this.dataGridOrPeInstalacion.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridOrPeInstalacion.Name = "dataGridOrPeInstalacion";
            this.dataGridOrPeInstalacion.RowHeadersWidth = 57;
            this.dataGridOrPeInstalacion.Size = new System.Drawing.Size(1160, 398);
            this.dataGridOrPeInstalacion.TabIndex = 15;
            // 
            // PedidoInstalacionHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1201, 485);
            this.Controls.Add(this.btnInhabilitar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSelecId);
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
        private System.Windows.Forms.DataGridView dataGridOrPeInstalacion;
    }
}