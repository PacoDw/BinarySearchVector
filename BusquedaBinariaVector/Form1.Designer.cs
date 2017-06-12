namespace BusquedaBinariaVector
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
            this.bttonBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bttonCrearVector = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bttonBuscar
            // 
            this.bttonBuscar.Location = new System.Drawing.Point(42, 76);
            this.bttonBuscar.Name = "bttonBuscar";
            this.bttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.bttonBuscar.TabIndex = 0;
            this.bttonBuscar.Text = "Buscar";
            this.bttonBuscar.UseVisualStyleBackColor = true;
            this.bttonBuscar.Click += new System.EventHandler(this.bttonBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(151, 76);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(100, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(42, 138);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(314, 20);
            this.txtResultado.TabIndex = 1;
            // 
            // bttonCrearVector
            // 
            this.bttonCrearVector.Location = new System.Drawing.Point(42, 28);
            this.bttonCrearVector.Name = "bttonCrearVector";
            this.bttonCrearVector.Size = new System.Drawing.Size(75, 23);
            this.bttonCrearVector.TabIndex = 0;
            this.bttonCrearVector.Text = "Crear vector";
            this.bttonCrearVector.UseVisualStyleBackColor = true;
            this.bttonCrearVector.Click += new System.EventHandler(this.bttonCrearVector_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 383);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.bttonCrearVector);
            this.Controls.Add(this.bttonBuscar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttonBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bttonCrearVector;
    }
}

