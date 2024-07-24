namespace CFB_Academia
{
    partial class frm_GestaoUsuarios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_Nivel = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.txt_Nivel = new System.Windows.Forms.NumericUpDown();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.txt_Senha = new System.Windows.Forms.TextBox();
            this.lbl_Senha = new System.Windows.Forms.Label();
            this.txt_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lbl_Nome = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nivel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 421);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 29);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "0 - Básico | 1 - Gerente | 2 - Master";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "A - Ativo | B - Bloqueado | D - Desligado";
            // 
            // lbl_Nivel
            // 
            this.lbl_Nivel.AutoSize = true;
            this.lbl_Nivel.Location = new System.Drawing.Point(320, 100);
            this.lbl_Nivel.Name = "lbl_Nivel";
            this.lbl_Nivel.Size = new System.Drawing.Size(45, 13);
            this.lbl_Nivel.TabIndex = 21;
            this.lbl_Nivel.Text = "Nível ->";
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(9, 100);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(49, 13);
            this.lbl_Status.TabIndex = 20;
            this.lbl_Status.Text = "Status ->";
            // 
            // txt_Nivel
            // 
            this.txt_Nivel.Location = new System.Drawing.Point(323, 116);
            this.txt_Nivel.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.txt_Nivel.Name = "txt_Nivel";
            this.txt_Nivel.Size = new System.Drawing.Size(209, 20);
            this.txt_Nivel.TabIndex = 5;
            this.txt_Nivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmb_Status
            // 
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Items.AddRange(new object[] {
            "A",
            "B",
            "D"});
            this.cmb_Status.Location = new System.Drawing.Point(12, 116);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(305, 21);
            this.cmb_Status.TabIndex = 4;
            this.cmb_Status.Text = "A";
            // 
            // txt_Senha
            // 
            this.txt_Senha.Location = new System.Drawing.Point(483, 70);
            this.txt_Senha.Name = "txt_Senha";
            this.txt_Senha.PasswordChar = '*';
            this.txt_Senha.Size = new System.Drawing.Size(151, 20);
            this.txt_Senha.TabIndex = 3;
            // 
            // lbl_Senha
            // 
            this.lbl_Senha.AutoSize = true;
            this.lbl_Senha.Location = new System.Drawing.Point(480, 54);
            this.lbl_Senha.Name = "lbl_Senha";
            this.lbl_Senha.Size = new System.Drawing.Size(38, 13);
            this.lbl_Senha.TabIndex = 16;
            this.lbl_Senha.Text = "Senha";
            // 
            // txt_UserName
            // 
            this.txt_UserName.Location = new System.Drawing.Point(326, 70);
            this.txt_UserName.Name = "txt_UserName";
            this.txt_UserName.Size = new System.Drawing.Size(151, 20);
            this.txt_UserName.TabIndex = 2;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(323, 54);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(60, 13);
            this.lbl_UserName.TabIndex = 14;
            this.lbl_UserName.Text = "User Name";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(12, 70);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(308, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lbl_Nome
            // 
            this.lbl_Nome.AutoSize = true;
            this.lbl_Nome.Location = new System.Drawing.Point(12, 54);
            this.lbl_Nome.Name = "lbl_Nome";
            this.lbl_Nome.Size = new System.Drawing.Size(35, 13);
            this.lbl_Nome.TabIndex = 12;
            this.lbl_Nome.Text = "Nome";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(15, 25);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(95, 20);
            this.txt_ID.TabIndex = 0;
            this.txt_ID.TabStop = false;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 24;
            this.lbl_ID.Text = "ID";
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AllowUserToAddRows = false;
            this.dgv_Usuarios.AllowUserToDeleteRows = false;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(12, 143);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            this.dgv_Usuarios.Size = new System.Drawing.Size(622, 272);
            this.dgv_Usuarios.TabIndex = 25;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Location = new System.Drawing.Point(3, 3);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(75, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(84, 3);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(75, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(165, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(75, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(568, 3);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(75, 23);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // frm_GestaoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 450);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Nivel);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.txt_Nivel);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.txt_Senha);
            this.Controls.Add(this.lbl_Senha);
            this.Controls.Add(this.txt_UserName);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_Nome);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_GestaoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestão Usuários";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txt_Nivel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_Nivel;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.NumericUpDown txt_Nivel;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.TextBox txt_Senha;
        private System.Windows.Forms.Label lbl_Senha;
        private System.Windows.Forms.TextBox txt_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label lbl_Nome;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
    }
}