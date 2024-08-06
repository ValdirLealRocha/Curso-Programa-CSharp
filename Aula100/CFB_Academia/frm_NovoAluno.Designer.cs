namespace CFB_Academia
{
    partial class frm_NovoAluno
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbl_Telefone = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_NomeAluno = new System.Windows.Forms.TextBox();
            this.txt_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.txt_Turma = new System.Windows.Forms.TextBox();
            this.lbl_Turma = new System.Windows.Forms.Label();
            this.btn_Turma = new System.Windows.Forms.Button();
            this.btn_Plano = new System.Windows.Forms.Button();
            this.txt_Plano = new System.Windows.Forms.TextBox();
            this.lbl_Plano = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 183);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 33);
            this.panel1.TabIndex = 13;
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(345, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(105, 23);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.Enabled = false;
            this.btn_Cancelar.Location = new System.Drawing.Point(234, 5);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(105, 23);
            this.btn_Cancelar.TabIndex = 2;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Enabled = false;
            this.btn_Salvar.Location = new System.Drawing.Point(123, 5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(105, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Location = new System.Drawing.Point(12, 5);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(105, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbl_Telefone
            // 
            this.lbl_Telefone.AutoSize = true;
            this.lbl_Telefone.Location = new System.Drawing.Point(347, 9);
            this.lbl_Telefone.Name = "lbl_Telefone";
            this.lbl_Telefone.Size = new System.Drawing.Size(49, 13);
            this.lbl_Telefone.TabIndex = 2;
            this.lbl_Telefone.Text = "Telefone";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(12, 68);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 4;
            this.lbl_Status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.Enabled = false;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(12, 84);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(119, 21);
            this.cmb_Status.TabIndex = 5;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 9);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 0;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_NomeAluno
            // 
            this.txt_NomeAluno.Enabled = false;
            this.txt_NomeAluno.Location = new System.Drawing.Point(15, 25);
            this.txt_NomeAluno.Name = "txt_NomeAluno";
            this.txt_NomeAluno.Size = new System.Drawing.Size(329, 20);
            this.txt_NomeAluno.TabIndex = 1;
            // 
            // txt_Telefone
            // 
            this.txt_Telefone.Enabled = false;
            this.txt_Telefone.Location = new System.Drawing.Point(350, 25);
            this.txt_Telefone.Mask = "(00) 0 0000-0000";
            this.txt_Telefone.Name = "txt_Telefone";
            this.txt_Telefone.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefone.TabIndex = 3;
            this.txt_Telefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txt_Turma
            // 
            this.txt_Turma.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Turma.Enabled = false;
            this.txt_Turma.Location = new System.Drawing.Point(137, 84);
            this.txt_Turma.Name = "txt_Turma";
            this.txt_Turma.ReadOnly = true;
            this.txt_Turma.Size = new System.Drawing.Size(281, 20);
            this.txt_Turma.TabIndex = 7;
            this.txt_Turma.TabStop = false;
            this.txt_Turma.Tag = "4";
            // 
            // lbl_Turma
            // 
            this.lbl_Turma.AutoSize = true;
            this.lbl_Turma.Location = new System.Drawing.Point(134, 68);
            this.lbl_Turma.Name = "lbl_Turma";
            this.lbl_Turma.Size = new System.Drawing.Size(37, 13);
            this.lbl_Turma.TabIndex = 6;
            this.lbl_Turma.Text = "Turma";
            // 
            // btn_Turma
            // 
            this.btn_Turma.Enabled = false;
            this.btn_Turma.Location = new System.Drawing.Point(424, 82);
            this.btn_Turma.Name = "btn_Turma";
            this.btn_Turma.Size = new System.Drawing.Size(26, 23);
            this.btn_Turma.TabIndex = 8;
            this.btn_Turma.Text = "...";
            this.btn_Turma.UseVisualStyleBackColor = true;
            // 
            // btn_Plano
            // 
            this.btn_Plano.Enabled = false;
            this.btn_Plano.Location = new System.Drawing.Point(302, 141);
            this.btn_Plano.Name = "btn_Plano";
            this.btn_Plano.Size = new System.Drawing.Size(26, 23);
            this.btn_Plano.TabIndex = 11;
            this.btn_Plano.Text = "...";
            this.btn_Plano.UseVisualStyleBackColor = true;
            // 
            // txt_Plano
            // 
            this.txt_Plano.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Plano.Enabled = false;
            this.txt_Plano.Location = new System.Drawing.Point(15, 143);
            this.txt_Plano.Name = "txt_Plano";
            this.txt_Plano.ReadOnly = true;
            this.txt_Plano.Size = new System.Drawing.Size(281, 20);
            this.txt_Plano.TabIndex = 10;
            this.txt_Plano.TabStop = false;
            // 
            // lbl_Plano
            // 
            this.lbl_Plano.AutoSize = true;
            this.lbl_Plano.Location = new System.Drawing.Point(12, 127);
            this.lbl_Plano.Name = "lbl_Plano";
            this.lbl_Plano.Size = new System.Drawing.Size(34, 13);
            this.lbl_Plano.TabIndex = 9;
            this.lbl_Plano.Text = "Plano";
            // 
            // frm_NovoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 216);
            this.Controls.Add(this.btn_Plano);
            this.Controls.Add(this.txt_Plano);
            this.Controls.Add(this.lbl_Plano);
            this.Controls.Add(this.btn_Turma);
            this.Controls.Add(this.txt_Turma);
            this.Controls.Add(this.lbl_Turma);
            this.Controls.Add(this.txt_Telefone);
            this.Controls.Add(this.txt_NomeAluno);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.lbl_Telefone);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_NovoAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo Aluno";
            this.Load += new System.EventHandler(this.frm_NovoAluno_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Label lbl_Telefone;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_NomeAluno;
        private System.Windows.Forms.MaskedTextBox txt_Telefone;
        private System.Windows.Forms.TextBox txt_Turma;
        private System.Windows.Forms.Label lbl_Turma;
        private System.Windows.Forms.Button btn_Turma;
        private System.Windows.Forms.Button btn_Plano;
        private System.Windows.Forms.TextBox txt_Plano;
        private System.Windows.Forms.Label lbl_Plano;
    }
}