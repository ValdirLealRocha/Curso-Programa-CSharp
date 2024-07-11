namespace Aula062
{
    partial class frm_MaskedTextBox
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
            this.txt_Senha = new System.Windows.Forms.MaskedTextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_MudarMascaraEntrada = new System.Windows.Forms.MaskedTextBox();
            this.btn_MudarMascaraEntrada = new System.Windows.Forms.Button();
            this.chb_SomenteTexto = new System.Windows.Forms.CheckBox();
            this.ckb_VerSenha = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(12, 25);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '#';
            this.txt_Senha.Size = new System.Drawing.Size(143, 20);
            this.txt_Senha.TabIndex = 1;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(12, 9);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 0;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_MudarMascaraEntrada
            // 
            this.txt_MudarMascaraEntrada.Location = new System.Drawing.Point(12, 88);
            this.txt_MudarMascaraEntrada.Mask = "000.000.000-00";
            this.txt_MudarMascaraEntrada.Name = "txt_MudarMascaraEntrada";
            this.txt_MudarMascaraEntrada.Size = new System.Drawing.Size(143, 20);
            this.txt_MudarMascaraEntrada.TabIndex = 2;
            this.txt_MudarMascaraEntrada.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // btn_MudarMascaraEntrada
            // 
            this.btn_MudarMascaraEntrada.Location = new System.Drawing.Point(261, 90);
            this.btn_MudarMascaraEntrada.Name = "btn_MudarMascaraEntrada";
            this.btn_MudarMascaraEntrada.Size = new System.Drawing.Size(228, 23);
            this.btn_MudarMascaraEntrada.TabIndex = 4;
            this.btn_MudarMascaraEntrada.Text = "Mudar Mascara de Entrada";
            this.btn_MudarMascaraEntrada.UseVisualStyleBackColor = true;
            this.btn_MudarMascaraEntrada.Click += new System.EventHandler(this.btn_MudarMascaraEntrada_Click);
            // 
            // chb_SomenteTexto
            // 
            this.chb_SomenteTexto.AutoSize = true;
            this.chb_SomenteTexto.Location = new System.Drawing.Point(161, 94);
            this.chb_SomenteTexto.Name = "chb_SomenteTexto";
            this.chb_SomenteTexto.Size = new System.Drawing.Size(94, 17);
            this.chb_SomenteTexto.TabIndex = 3;
            this.chb_SomenteTexto.Text = "Somente texto";
            this.chb_SomenteTexto.UseVisualStyleBackColor = true;
            // 
            // ckb_VerSenha
            // 
            this.ckb_VerSenha.AutoSize = true;
            this.ckb_VerSenha.Location = new System.Drawing.Point(161, 28);
            this.ckb_VerSenha.Name = "ckb_VerSenha";
            this.ckb_VerSenha.Size = new System.Drawing.Size(76, 17);
            this.ckb_VerSenha.TabIndex = 5;
            this.ckb_VerSenha.Text = "Ver Senha";
            this.ckb_VerSenha.UseVisualStyleBackColor = true;
            this.ckb_VerSenha.CheckedChanged += new System.EventHandler(this.ckb_VerSenha_CheckedChanged);
            // 
            // frm_MaskedTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.ckb_VerSenha);
            this.Controls.Add(this.chb_SomenteTexto);
            this.Controls.Add(this.btn_MudarMascaraEntrada);
            this.Controls.Add(this.txt_MudarMascaraEntrada);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_Senha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_MaskedTextBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MaskedTextBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.MaskedTextBox txt_MudarMascaraEntrada;
        private System.Windows.Forms.Button btn_MudarMascaraEntrada;
        private System.Windows.Forms.CheckBox chb_SomenteTexto;
        private System.Windows.Forms.CheckBox ckb_VerSenha;
    }
}