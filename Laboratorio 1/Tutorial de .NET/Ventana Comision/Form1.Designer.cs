
namespace Ventana_Comision
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.totalVentas = new System.Windows.Forms.TextBox();
            this.numeroVentas = new System.Windows.Forms.TextBox();
            this.ComisionTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Ventas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num Ventas:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(68, 204);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Calcular Comision";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(212, 91);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(0, 13);
            this.linkLabel1.TabIndex = 3;
            // 
            // totalVentas
            // 
            this.totalVentas.Location = new System.Drawing.Point(118, 83);
            this.totalVentas.Name = "totalVentas";
            this.totalVentas.Size = new System.Drawing.Size(100, 20);
            this.totalVentas.TabIndex = 4;
            // 
            // numeroVentas
            // 
            this.numeroVentas.Location = new System.Drawing.Point(118, 109);
            this.numeroVentas.Name = "numeroVentas";
            this.numeroVentas.Size = new System.Drawing.Size(100, 20);
            this.numeroVentas.TabIndex = 5;
            // 
            // ComisionTotal
            // 
            this.ComisionTotal.Enabled = false;
            this.ComisionTotal.Location = new System.Drawing.Point(68, 233);
            this.ComisionTotal.Name = "ComisionTotal";
            this.ComisionTotal.Size = new System.Drawing.Size(100, 20);
            this.ComisionTotal.TabIndex = 6;
            this.ComisionTotal.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 336);
            this.Controls.Add(this.ComisionTotal);
            this.Controls.Add(this.numeroVentas);
            this.Controls.Add(this.totalVentas);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox totalVentas;
        private System.Windows.Forms.TextBox numeroVentas;
        private System.Windows.Forms.TextBox ComisionTotal;
    }
}

