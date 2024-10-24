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
            // ProformasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.btnAñadir);
            this.Controls.Add(this.tablaProformas);
            this.Name = "ProformasForm";
            this.Text = "ProformasForm";
            ((System.ComponentModel.ISupportInitialize)(this.tablaProformas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tablaProformas;
        private System.Windows.Forms.Button btnAñadir;
    }
}