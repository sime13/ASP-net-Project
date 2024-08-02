namespace Dicionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Palavra = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dicionario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(271, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pesqusar uma palavra";
            // 
            // Palavra
            // 
            this.Palavra.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Palavra.Font = new System.Drawing.Font("Microsoft Yi Baiti", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Palavra.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Palavra.Location = new System.Drawing.Point(273, 102);
            this.Palavra.MinimumSize = new System.Drawing.Size(259, 30);
            this.Palavra.Name = "Palavra";
            this.Palavra.Size = new System.Drawing.Size(259, 29);
            this.Palavra.TabIndex = 2;
            this.Palavra.TabStop = false;
            this.Palavra.Text = "Digite aqui !";
            this.Palavra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(273, 138);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Resultado
            // 
            this.Resultado.AutoSize = true;
            this.Resultado.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resultado.Location = new System.Drawing.Point(183, 184);
            this.Resultado.MinimumSize = new System.Drawing.Size(400, 200);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(400, 200);
            this.Resultado.TabIndex = 4;
            this.Resultado.UseWaitCursor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 525);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Palavra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(813, 564);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Palavra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Resultado;
    }
}

