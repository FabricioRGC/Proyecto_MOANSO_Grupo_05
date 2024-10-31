namespace Proyecto_MOANSO_Grupo_05
{
    partial class OrPeMaterialHistorialForm
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
            this.txtIdMateriales = new System.Windows.Forms.TextBox();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dataGridOrPeMateriales = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeMateriales)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(579, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Buscar Por Codigo de Material";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtIdMateriales
            // 
            this.txtIdMateriales.Location = new System.Drawing.Point(777, 18);
            this.txtIdMateriales.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdMateriales.Name = "txtIdMateriales";
            this.txtIdMateriales.Size = new System.Drawing.Size(208, 22);
            this.txtIdMateriales.TabIndex = 30;
            this.txtIdMateriales.TextChanged += new System.EventHandler(this.txtIdMateriales_TextChanged);
            // 
            // btnAnular
            // 
            this.btnAnular.Location = new System.Drawing.Point(1003, 15);
            this.btnAnular.Margin = new System.Windows.Forms.Padding(4);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(134, 28);
            this.btnAnular.TabIndex = 29;
            this.btnAnular.Text = "Anular";
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dataGridOrPeMateriales
            // 
            this.dataGridOrPeMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrPeMateriales.Location = new System.Drawing.Point(20, 55);
            this.dataGridOrPeMateriales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridOrPeMateriales.Name = "dataGridOrPeMateriales";
            this.dataGridOrPeMateriales.RowHeadersWidth = 57;
            this.dataGridOrPeMateriales.RowTemplate.Height = 24;
            this.dataGridOrPeMateriales.Size = new System.Drawing.Size(1145, 475);
            this.dataGridOrPeMateriales.TabIndex = 32;
            this.dataGridOrPeMateriales.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrPeMateriales_CellContentClick);
            // 
            // OrPeMaterialHistorialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 557);
            this.Controls.Add(this.dataGridOrPeMateriales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdMateriales);
            this.Controls.Add(this.btnAnular);
            this.Name = "OrPeMaterialHistorialForm";
            this.Text = "OrPeMaterialHistorialForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrPeMateriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdMateriales;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dataGridOrPeMateriales;
    }
}