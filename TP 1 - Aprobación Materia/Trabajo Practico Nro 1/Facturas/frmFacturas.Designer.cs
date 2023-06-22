namespace Facturas
{
    partial class frmFacturas
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
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtIngreso = new System.Windows.Forms.TextBox();
            this.lbxFacturas = new System.Windows.Forms.ListBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnTope = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargarAlternativo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Location = new System.Drawing.Point(152, 53);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(168, 13);
            this.lblIngreso.TabIndex = 0;
            this.lblIngreso.Text = "Ingrese el valor deseado a cargar:";
            // 
            // txtIngreso
            // 
            this.txtIngreso.Location = new System.Drawing.Point(337, 50);
            this.txtIngreso.Name = "txtIngreso";
            this.txtIngreso.Size = new System.Drawing.Size(100, 20);
            this.txtIngreso.TabIndex = 1;
            // 
            // lbxFacturas
            // 
            this.lbxFacturas.FormattingEnabled = true;
            this.lbxFacturas.Location = new System.Drawing.Point(92, 119);
            this.lbxFacturas.Name = "lbxFacturas";
            this.lbxFacturas.Size = new System.Drawing.Size(431, 121);
            this.lbxFacturas.TabIndex = 2;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(34, 283);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(75, 23);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(496, 283);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnTope
            // 
            this.btnTope.Location = new System.Drawing.Point(34, 342);
            this.btnTope.Name = "btnTope";
            this.btnTope.Size = new System.Drawing.Size(75, 23);
            this.btnTope.TabIndex = 5;
            this.btnTope.Text = "Tope";
            this.btnTope.UseVisualStyleBackColor = true;
            this.btnTope.Click += new System.EventHandler(this.btnTope_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(496, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargarAlternativo
            // 
            this.btnCargarAlternativo.Location = new System.Drawing.Point(239, 315);
            this.btnCargarAlternativo.Name = "btnCargarAlternativo";
            this.btnCargarAlternativo.Size = new System.Drawing.Size(105, 23);
            this.btnCargarAlternativo.TabIndex = 7;
            this.btnCargarAlternativo.Text = "Cargar Alternativo";
            this.btnCargarAlternativo.UseVisualStyleBackColor = true;
            // 
            // frmFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(616, 405);
            this.Controls.Add(this.btnCargarAlternativo);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnTope);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.lbxFacturas);
            this.Controls.Add(this.txtIngreso);
            this.Controls.Add(this.lblIngreso);
            this.MaximumSize = new System.Drawing.Size(632, 444);
            this.MinimumSize = new System.Drawing.Size(632, 444);
            this.Name = "frmFacturas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnTope;
        private System.Windows.Forms.Button btnSalir;
        public System.Windows.Forms.ListBox lbxFacturas;
        private System.Windows.Forms.Button btnCargarAlternativo;
        public System.Windows.Forms.TextBox txtIngreso;
        public System.Windows.Forms.Button btnCargar;
    }
}

