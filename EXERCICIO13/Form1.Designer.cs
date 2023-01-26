namespace EXERCICIO13
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Tex1 = new System.Windows.Forms.Label();
            this.Tex4 = new System.Windows.Forms.Label();
            this.Tex2 = new System.Windows.Forms.Label();
            this.Tex5 = new System.Windows.Forms.Label();
            this.Tex3 = new System.Windows.Forms.Label();
            this.Men1 = new System.Windows.Forms.TextBox();
            this.Men2 = new System.Windows.Forms.TextBox();
            this.Men3 = new System.Windows.Forms.TextBox();
            this.Men4 = new System.Windows.Forms.TextBox();
            this.Men5 = new System.Windows.Forms.TextBox();
            this.B1 = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Tex1
            // 
            this.Tex1.AutoSize = true;
            this.Tex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tex1.Location = new System.Drawing.Point(12, 24);
            this.Tex1.Name = "Tex1";
            this.Tex1.Size = new System.Drawing.Size(79, 25);
            this.Tex1.TabIndex = 4;
            this.Tex1.Text = "Nome:";
            // 
            // Tex4
            // 
            this.Tex4.AutoSize = true;
            this.Tex4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tex4.Location = new System.Drawing.Point(555, 24);
            this.Tex4.Name = "Tex4";
            this.Tex4.Size = new System.Drawing.Size(72, 25);
            this.Tex4.TabIndex = 5;
            this.Tex4.Text = "Nasc:";
            // 
            // Tex2
            // 
            this.Tex2.AutoSize = true;
            this.Tex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tex2.Location = new System.Drawing.Point(12, 114);
            this.Tex2.Name = "Tex2";
            this.Tex2.Size = new System.Drawing.Size(119, 25);
            this.Tex2.TabIndex = 6;
            this.Tex2.Text = "Endereço:";
            // 
            // Tex5
            // 
            this.Tex5.AutoSize = true;
            this.Tex5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tex5.Location = new System.Drawing.Point(555, 114);
            this.Tex5.Name = "Tex5";
            this.Tex5.Size = new System.Drawing.Size(65, 25);
            this.Tex5.TabIndex = 7;
            this.Tex5.Text = "CEP:";
            // 
            // Tex3
            // 
            this.Tex3.AutoSize = true;
            this.Tex3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tex3.Location = new System.Drawing.Point(12, 206);
            this.Tex3.Name = "Tex3";
            this.Tex3.Size = new System.Drawing.Size(94, 25);
            this.Tex3.TabIndex = 8;
            this.Tex3.Text = "Celular:";
            // 
            // Men1
            // 
            this.Men1.Location = new System.Drawing.Point(17, 52);
            this.Men1.Name = "Men1";
            this.Men1.Size = new System.Drawing.Size(328, 20);
            this.Men1.TabIndex = 9;
            this.Men1.TextChanged += new System.EventHandler(this.Men1_TextChanged);
            // 
            // Men2
            // 
            this.Men2.Location = new System.Drawing.Point(17, 142);
            this.Men2.Name = "Men2";
            this.Men2.Size = new System.Drawing.Size(328, 20);
            this.Men2.TabIndex = 10;
            // 
            // Men3
            // 
            this.Men3.Location = new System.Drawing.Point(12, 234);
            this.Men3.Name = "Men3";
            this.Men3.Size = new System.Drawing.Size(333, 20);
            this.Men3.TabIndex = 11;
            // 
            // Men4
            // 
            this.Men4.Location = new System.Drawing.Point(560, 52);
            this.Men4.Name = "Men4";
            this.Men4.Size = new System.Drawing.Size(135, 20);
            this.Men4.TabIndex = 12;
            // 
            // Men5
            // 
            this.Men5.Location = new System.Drawing.Point(560, 142);
            this.Men5.Name = "Men5";
            this.Men5.Size = new System.Drawing.Size(135, 20);
            this.Men5.TabIndex = 13;
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B1.Location = new System.Drawing.Point(560, 326);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(164, 67);
            this.B1.TabIndex = 14;
            this.B1.Text = "Continuar";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.B1_Click);
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(230, 24);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(0, 31);
            this.Resultado.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.Men5);
            this.Controls.Add(this.Men4);
            this.Controls.Add(this.Men3);
            this.Controls.Add(this.Men2);
            this.Controls.Add(this.Men1);
            this.Controls.Add(this.Tex3);
            this.Controls.Add(this.Tex5);
            this.Controls.Add(this.Tex2);
            this.Controls.Add(this.Tex4);
            this.Controls.Add(this.Tex1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Tex1;
        private System.Windows.Forms.Label Tex4;
        private System.Windows.Forms.Label Tex2;
        private System.Windows.Forms.Label Tex5;
        private System.Windows.Forms.Label Tex3;
        private System.Windows.Forms.TextBox Men1;
        private System.Windows.Forms.TextBox Men2;
        private System.Windows.Forms.TextBox Men3;
        private System.Windows.Forms.TextBox Men4;
        private System.Windows.Forms.TextBox Men5;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Label Resultado;
    }
}

