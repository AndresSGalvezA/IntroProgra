namespace Cruzando_la_calle_Andres_Gálvez_1024718
{
    partial class RegistroDatos
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
            this.BtnDificil = new System.Windows.Forms.Button();
            this.BtnMedio = new System.Windows.Forms.Button();
            this.BtnFacil = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LabelCarne = new System.Windows.Forms.Label();
            this.LabelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnDificil
            // 
            this.BtnDificil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnDificil.Location = new System.Drawing.Point(338, 162);
            this.BtnDificil.Name = "BtnDificil";
            this.BtnDificil.Size = new System.Drawing.Size(120, 37);
            this.BtnDificil.TabIndex = 13;
            this.BtnDificil.Text = "Nivel difícil";
            this.BtnDificil.UseVisualStyleBackColor = false;
            this.BtnDificil.Click += new System.EventHandler(this.BtnDificil_Click);
            // 
            // BtnMedio
            // 
            this.BtnMedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnMedio.Location = new System.Drawing.Point(176, 162);
            this.BtnMedio.Name = "BtnMedio";
            this.BtnMedio.Size = new System.Drawing.Size(120, 37);
            this.BtnMedio.TabIndex = 12;
            this.BtnMedio.Text = "Nivel medio";
            this.BtnMedio.UseVisualStyleBackColor = false;
            this.BtnMedio.Click += new System.EventHandler(this.BtnMedio_Click);
            // 
            // BtnFacil
            // 
            this.BtnFacil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BtnFacil.Location = new System.Drawing.Point(15, 162);
            this.BtnFacil.Name = "BtnFacil";
            this.BtnFacil.Size = new System.Drawing.Size(120, 37);
            this.BtnFacil.TabIndex = 11;
            this.BtnFacil.Text = "Nivel Fácil";
            this.BtnFacil.UseVisualStyleBackColor = false;
            this.BtnFacil.Click += new System.EventHandler(this.BtnFacil_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(15, 98);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(271, 22);
            this.textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(15, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(443, 22);
            this.textBox1.TabIndex = 9;
            // 
            // LabelCarne
            // 
            this.LabelCarne.AutoSize = true;
            this.LabelCarne.Location = new System.Drawing.Point(12, 77);
            this.LabelCarne.Name = "LabelCarne";
            this.LabelCarne.Size = new System.Drawing.Size(274, 17);
            this.LabelCarne.TabIndex = 8;
            this.LabelCarne.Text = "Ingresa el número de tu carné univesitario";
            // 
            // LabelNombre
            // 
            this.LabelNombre.AutoSize = true;
            this.LabelNombre.Location = new System.Drawing.Point(12, 9);
            this.LabelNombre.Name = "LabelNombre";
            this.LabelNombre.Size = new System.Drawing.Size(123, 17);
            this.LabelNombre.TabIndex = 7;
            this.LabelNombre.Text = "Ingresa tu nombre";
            // 
            // RegistroDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 213);
            this.Controls.Add(this.BtnDificil);
            this.Controls.Add(this.BtnMedio);
            this.Controls.Add(this.BtnFacil);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LabelCarne);
            this.Controls.Add(this.LabelNombre);
            this.Name = "RegistroDatos";
            this.Text = "RegistroDatos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDificil;
        private System.Windows.Forms.Button BtnMedio;
        private System.Windows.Forms.Button BtnFacil;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LabelCarne;
        private System.Windows.Forms.Label LabelNombre;
    }
}