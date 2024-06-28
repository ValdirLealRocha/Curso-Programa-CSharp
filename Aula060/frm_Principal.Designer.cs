namespace Aula060
{
    partial class frm_Principal
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
            this.btn_Texto = new System.Windows.Forms.Button();
            this.lbl_Texto = new System.Windows.Forms.Label();
            this.txt_Texto = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Texto
            // 
            this.btn_Texto.BackColor = System.Drawing.Color.Black;
            this.btn_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Texto.ForeColor = System.Drawing.Color.Red;
            this.btn_Texto.Location = new System.Drawing.Point(12, 38);
            this.btn_Texto.Name = "btn_Texto";
            this.btn_Texto.Size = new System.Drawing.Size(173, 41);
            this.btn_Texto.TabIndex = 0;
            this.btn_Texto.Text = "OK";
            this.btn_Texto.UseVisualStyleBackColor = false;
            this.btn_Texto.Click += new System.EventHandler(this.btn_Texto_Click);
            // 
            // lbl_Texto
            // 
            this.lbl_Texto.AutoSize = true;
            this.lbl_Texto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Texto.Location = new System.Drawing.Point(8, 82);
            this.lbl_Texto.Name = "lbl_Texto";
            this.lbl_Texto.Size = new System.Drawing.Size(173, 20);
            this.lbl_Texto.TabIndex = 1;
            this.lbl_Texto.Text = "youtube.com/cfbcursos";
            // 
            // txt_Texto
            // 
            this.txt_Texto.Location = new System.Drawing.Point(12, 12);
            this.txt_Texto.Name = "txt_Texto";
            this.txt_Texto.Size = new System.Drawing.Size(169, 20);
            this.txt_Texto.TabIndex = 2;
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 518);
            this.Controls.Add(this.txt_Texto);
            this.Controls.Add(this.lbl_Texto);
            this.Controls.Add(this.btn_Texto);
            this.Name = "frm_Principal";
            this.Text = "Principal | Aulas 60 e 61 do Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Texto;
        private System.Windows.Forms.Label lbl_Texto;
        private System.Windows.Forms.TextBox txt_Texto;
    }
}

