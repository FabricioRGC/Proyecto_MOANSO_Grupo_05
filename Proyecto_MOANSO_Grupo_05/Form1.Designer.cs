﻿namespace Proyecto_MOANSO_Grupo_05
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonOrdenes = new System.Windows.Forms.Button();
            this.buttonAlmyTra = new System.Windows.Forms.Button();
            this.buttonMantFr = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(120)))), ((int)(((byte)(29)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.24999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1118, 76);
            this.label1.TabIndex = 15;
            this.label1.Text = "        Lunnys Peru R2d E.I.R.L.        ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 27);
            this.button1.TabIndex = 21;
            this.button1.Text = "Ventas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(230, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(243, 507);
            this.panel2.TabIndex = 22;
            // 
            // buttonOrdenes
            // 
            this.buttonOrdenes.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonOrdenes.Location = new System.Drawing.Point(12, 255);
            this.buttonOrdenes.Name = "buttonOrdenes";
            this.buttonOrdenes.Size = new System.Drawing.Size(101, 35);
            this.buttonOrdenes.TabIndex = 23;
            this.buttonOrdenes.Text = "Ordenes";
            this.buttonOrdenes.UseVisualStyleBackColor = true;
            this.buttonOrdenes.Click += new System.EventHandler(this.buttonOrdenes_Click);
            // 
            // buttonAlmyTra
            // 
            this.buttonAlmyTra.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonAlmyTra.Location = new System.Drawing.Point(12, 355);
            this.buttonAlmyTra.Name = "buttonAlmyTra";
            this.buttonAlmyTra.Size = new System.Drawing.Size(141, 62);
            this.buttonAlmyTra.TabIndex = 24;
            this.buttonAlmyTra.Text = "Almacen y trabajadores";
            this.buttonAlmyTra.UseVisualStyleBackColor = true;
            this.buttonAlmyTra.Click += new System.EventHandler(this.buttonAlmyTra_Click);
            // 
            // buttonMantFr
            // 
            this.buttonMantFr.Font = new System.Drawing.Font("Rockwell", 14.25F, System.Drawing.FontStyle.Bold);
            this.buttonMantFr.Location = new System.Drawing.Point(12, 482);
            this.buttonMantFr.Name = "buttonMantFr";
            this.buttonMantFr.Size = new System.Drawing.Size(166, 30);
            this.buttonMantFr.TabIndex = 25;
            this.buttonMantFr.Text = "Mantenimiento";
            this.buttonMantFr.UseVisualStyleBackColor = true;
            this.buttonMantFr.Click += new System.EventHandler(this.buttonMantFr_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(555, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(444, 507);
            this.panel1.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(496, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1076, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonMantFr);
            this.Controls.Add(this.buttonAlmyTra);
            this.Controls.Add(this.buttonOrdenes);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonOrdenes;
        private System.Windows.Forms.Button buttonAlmyTra;
        private System.Windows.Forms.Button buttonMantFr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}

