namespace CFB_Academia
{
    partial class frm_SQLite
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Acesso = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.pcb_LedLogado = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LedLogado)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.lbl_Usuario);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lbl_Acesso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pcb_LedLogado);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 424);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 26);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Acesso:";
            // 
            // lbl_Acesso
            // 
            this.lbl_Acesso.AutoSize = true;
            this.lbl_Acesso.Location = new System.Drawing.Point(70, 7);
            this.lbl_Acesso.Name = "lbl_Acesso";
            this.lbl_Acesso.Size = new System.Drawing.Size(13, 13);
            this.lbl_Acesso.TabIndex = 2;
            this.lbl_Acesso.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(134, 7);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(16, 13);
            this.lbl_Usuario.TabIndex = 4;
            this.lbl_Usuario.Text = "...";
            // 
            // pcb_LedLogado
            // 
            this.pcb_LedLogado.Image = global::CFB_Academia.Properties.Resources.led_vermelho;
            this.pcb_LedLogado.Location = new System.Drawing.Point(3, 3);
            this.pcb_LedLogado.Name = "pcb_LedLogado";
            this.pcb_LedLogado.Size = new System.Drawing.Size(20, 20);
            this.pcb_LedLogado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcb_LedLogado.TabIndex = 0;
            this.pcb_LedLogado.TabStop = false;
            // 
            // frm_SQLite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_SQLite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQLite | Academia v1.0";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_LedLogado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.PictureBox pcb_LedLogado;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_Acesso;
        private System.Windows.Forms.Label label1;
    }
}

