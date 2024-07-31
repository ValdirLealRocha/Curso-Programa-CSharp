namespace CFB_Academia
{
    partial class frm_GestaoTurmas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Imprimir = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.dgv_Turmas = new System.Windows.Forms.DataGridView();
            this.cmb_Professor = new System.Windows.Forms.ComboBox();
            this.lbl_Professor = new System.Windows.Forms.Label();
            this.lbl_MaximoAlunos = new System.Windows.Forms.Label();
            this.txt_MaximoAlunos = new System.Windows.Forms.NumericUpDown();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.cmb_Status = new System.Windows.Forms.ComboBox();
            this.lbl_Horario = new System.Windows.Forms.Label();
            this.cmb_Horario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_DescricaoTurma = new System.Windows.Forms.TextBox();
            this.txt_Vagas = new System.Windows.Forms.TextBox();
            this.lbl_Vagas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaximoAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_Imprimir);
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 33);
            this.panel1.TabIndex = 13;
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Imprimir.Location = new System.Drawing.Point(387, 5);
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(119, 23);
            this.btn_Imprimir.TabIndex = 3;
            this.btn_Imprimir.Text = "Imprimir Turma";
            this.btn_Imprimir.UseVisualStyleBackColor = true;
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(512, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(119, 23);
            this.btn_Fechar.TabIndex = 4;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(262, 5);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(119, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Turma";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(137, 5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar Edições";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Location = new System.Drawing.Point(12, 5);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(119, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Nova Turma";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // dgv_Turmas
            // 
            this.dgv_Turmas.AllowUserToAddRows = false;
            this.dgv_Turmas.AllowUserToDeleteRows = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Turmas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dgv_Turmas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Turmas.EnableHeadersVisualStyles = false;
            this.dgv_Turmas.Location = new System.Drawing.Point(12, 12);
            this.dgv_Turmas.MultiSelect = false;
            this.dgv_Turmas.Name = "dgv_Turmas";
            this.dgv_Turmas.ReadOnly = true;
            this.dgv_Turmas.RowHeadersVisible = false;
            this.dgv_Turmas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Turmas.Size = new System.Drawing.Size(340, 399);
            this.dgv_Turmas.TabIndex = 0;
            this.dgv_Turmas.SelectionChanged += new System.EventHandler(this.dgv_GestaoTurmas_SelectionChanged);
            // 
            // cmb_Professor
            // 
            this.cmb_Professor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Professor.FormattingEnabled = true;
            this.cmb_Professor.Location = new System.Drawing.Point(358, 77);
            this.cmb_Professor.Name = "cmb_Professor";
            this.cmb_Professor.Size = new System.Drawing.Size(272, 21);
            this.cmb_Professor.TabIndex = 4;
            this.cmb_Professor.SelectedIndexChanged += new System.EventHandler(this.cmb_Professor_SelectedIndexChanged);
            // 
            // lbl_Professor
            // 
            this.lbl_Professor.AutoSize = true;
            this.lbl_Professor.Location = new System.Drawing.Point(358, 61);
            this.lbl_Professor.Name = "lbl_Professor";
            this.lbl_Professor.Size = new System.Drawing.Size(51, 13);
            this.lbl_Professor.TabIndex = 3;
            this.lbl_Professor.Text = "Professor";
            // 
            // lbl_MaximoAlunos
            // 
            this.lbl_MaximoAlunos.AutoSize = true;
            this.lbl_MaximoAlunos.Location = new System.Drawing.Point(358, 111);
            this.lbl_MaximoAlunos.Name = "lbl_MaximoAlunos";
            this.lbl_MaximoAlunos.Size = new System.Drawing.Size(78, 13);
            this.lbl_MaximoAlunos.TabIndex = 5;
            this.lbl_MaximoAlunos.Text = "Máximo Alunos";
            // 
            // txt_MaximoAlunos
            // 
            this.txt_MaximoAlunos.Location = new System.Drawing.Point(358, 127);
            this.txt_MaximoAlunos.Name = "txt_MaximoAlunos";
            this.txt_MaximoAlunos.Size = new System.Drawing.Size(78, 20);
            this.txt_MaximoAlunos.TabIndex = 6;
            this.txt_MaximoAlunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MaximoAlunos.ValueChanged += new System.EventHandler(this.txt_MaximoAlunos_ValueChanged);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Location = new System.Drawing.Point(442, 110);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(37, 13);
            this.lbl_Status.TabIndex = 7;
            this.lbl_Status.Text = "Status";
            // 
            // cmb_Status
            // 
            this.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Status.FormattingEnabled = true;
            this.cmb_Status.Location = new System.Drawing.Point(442, 126);
            this.cmb_Status.Name = "cmb_Status";
            this.cmb_Status.Size = new System.Drawing.Size(188, 21);
            this.cmb_Status.TabIndex = 8;
            this.cmb_Status.SelectedIndexChanged += new System.EventHandler(this.cmb_Status_SelectedIndexChanged);
            // 
            // lbl_Horario
            // 
            this.lbl_Horario.AutoSize = true;
            this.lbl_Horario.Location = new System.Drawing.Point(355, 160);
            this.lbl_Horario.Name = "lbl_Horario";
            this.lbl_Horario.Size = new System.Drawing.Size(41, 13);
            this.lbl_Horario.TabIndex = 9;
            this.lbl_Horario.Text = "Horário";
            // 
            // cmb_Horario
            // 
            this.cmb_Horario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Horario.FormattingEnabled = true;
            this.cmb_Horario.Location = new System.Drawing.Point(358, 176);
            this.cmb_Horario.Name = "cmb_Horario";
            this.cmb_Horario.Size = new System.Drawing.Size(272, 21);
            this.cmb_Horario.TabIndex = 10;
            this.cmb_Horario.SelectedIndexChanged += new System.EventHandler(this.cmb_Horario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(358, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Turma";
            // 
            // txt_DescricaoTurma
            // 
            this.txt_DescricaoTurma.Location = new System.Drawing.Point(361, 28);
            this.txt_DescricaoTurma.Name = "txt_DescricaoTurma";
            this.txt_DescricaoTurma.Size = new System.Drawing.Size(269, 20);
            this.txt_DescricaoTurma.TabIndex = 2;
            this.txt_DescricaoTurma.TextChanged += new System.EventHandler(this.txt_DescricaoTurma_TextChanged);
            // 
            // txt_Vagas
            // 
            this.txt_Vagas.Cursor = System.Windows.Forms.Cursors.No;
            this.txt_Vagas.Enabled = false;
            this.txt_Vagas.Location = new System.Drawing.Point(358, 226);
            this.txt_Vagas.Name = "txt_Vagas";
            this.txt_Vagas.ReadOnly = true;
            this.txt_Vagas.Size = new System.Drawing.Size(37, 20);
            this.txt_Vagas.TabIndex = 12;
            this.txt_Vagas.TabStop = false;
            this.txt_Vagas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_Vagas
            // 
            this.lbl_Vagas.AutoSize = true;
            this.lbl_Vagas.Location = new System.Drawing.Point(358, 210);
            this.lbl_Vagas.Name = "lbl_Vagas";
            this.lbl_Vagas.Size = new System.Drawing.Size(37, 13);
            this.lbl_Vagas.TabIndex = 11;
            this.lbl_Vagas.Text = "Vagas";
            // 
            // frm_GestaoTurmas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.txt_Vagas);
            this.Controls.Add(this.lbl_Vagas);
            this.Controls.Add(this.txt_DescricaoTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Horario);
            this.Controls.Add(this.cmb_Horario);
            this.Controls.Add(this.lbl_Status);
            this.Controls.Add(this.cmb_Status);
            this.Controls.Add(this.txt_MaximoAlunos);
            this.Controls.Add(this.lbl_MaximoAlunos);
            this.Controls.Add(this.lbl_Professor);
            this.Controls.Add(this.cmb_Professor);
            this.Controls.Add(this.dgv_Turmas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_GestaoTurmas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Turmas";
            this.Load += new System.EventHandler(this.frm_GestaoTurmas_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Turmas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaximoAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView dgv_Turmas;
        private System.Windows.Forms.Button btn_Imprimir;
        private System.Windows.Forms.ComboBox cmb_Professor;
        private System.Windows.Forms.Label lbl_Professor;
        private System.Windows.Forms.Label lbl_MaximoAlunos;
        private System.Windows.Forms.NumericUpDown txt_MaximoAlunos;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.ComboBox cmb_Status;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.ComboBox cmb_Horario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_DescricaoTurma;
        private System.Windows.Forms.TextBox txt_Vagas;
        private System.Windows.Forms.Label lbl_Vagas;
    }
}