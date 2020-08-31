namespace Cruzando_la_calle_Andres_Gálvez_1024718
{
    partial class Login
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
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.BtnTop10 = new System.Windows.Forms.Button();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.LabelTitulo.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitulo.ForeColor = System.Drawing.Color.Black;
            this.LabelTitulo.Location = new System.Drawing.Point(88, 2);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Size = new System.Drawing.Size(488, 75);
            this.LabelTitulo.TabIndex = 13;
            this.LabelTitulo.Text = "Cruzando la calle";
            this.LabelTitulo.Click += new System.EventHandler(this.LabelTitulo_Click);
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.AutoSize = true;
            this.BtnIniciar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnIniciar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIniciar.ForeColor = System.Drawing.Color.Black;
            this.BtnIniciar.Location = new System.Drawing.Point(263, 98);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(152, 55);
            this.BtnIniciar.TabIndex = 12;
            this.BtnIniciar.Text = "INICIAR JUEGO";
            this.BtnIniciar.UseVisualStyleBackColor = false;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // BtnTop10
            // 
            this.BtnTop10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BtnTop10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnTop10.Location = new System.Drawing.Point(263, 159);
            this.BtnTop10.Name = "BtnTop10";
            this.BtnTop10.Size = new System.Drawing.Size(152, 54);
            this.BtnTop10.TabIndex = 11;
            this.BtnTop10.Text = "TOP 10";
            this.BtnTop10.UseVisualStyleBackColor = false;
            this.BtnTop10.Click += new System.EventHandler(this.BtnTop10_Click);
            // 
            // BtnSalir
            // 
            this.BtnSalir.BackColor = System.Drawing.Color.Transparent;
            this.BtnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSalir.ForeColor = System.Drawing.Color.Red;
            this.BtnSalir.Location = new System.Drawing.Point(263, 279);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(152, 55);
            this.BtnSalir.TabIndex = 10;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = false;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cruzando_la_calle_Andres_Gálvez_1024718.Properties.Resources.FondoLogin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(682, 366);
            this.Controls.Add(this.LabelTitulo);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.BtnTop10);
            this.Controls.Add(this.BtnSalir);
            this.Name = "Login";
            this.Text = "Cruzando la calle - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button BtnTop10;
        private System.Windows.Forms.Button BtnSalir;
    }
}

