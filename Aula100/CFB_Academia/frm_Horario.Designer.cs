namespace CFB_Academia
{
    partial class frm_Horario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_IDHorario = new System.Windows.Forms.TextBox();
            this.lbl_Horario = new System.Windows.Forms.Label();
            this.txt_DescricaoHorario = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Salvar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Fechar = new System.Windows.Forms.Button();
            this.dgv_Horarios = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 9);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 0;
            this.lbl_ID.Text = "ID";
            // 
            // txt_IDHorario
            // 
            this.txt_IDHorario.Enabled = false;
            this.txt_IDHorario.Location = new System.Drawing.Point(12, 25);
            this.txt_IDHorario.Name = "txt_IDHorario";
            this.txt_IDHorario.ReadOnly = true;
            this.txt_IDHorario.Size = new System.Drawing.Size(63, 20);
            this.txt_IDHorario.TabIndex = 1;
            this.txt_IDHorario.TabStop = false;
            // 
            // lbl_Horario
            // 
            this.lbl_Horario.AutoSize = true;
            this.lbl_Horario.Location = new System.Drawing.Point(81, 9);
            this.lbl_Horario.Name = "lbl_Horario";
            this.lbl_Horario.Size = new System.Drawing.Size(41, 13);
            this.lbl_Horario.TabIndex = 2;
            this.lbl_Horario.Text = "Horário";
            // 
            // txt_DescricaoHorario
            // 
            this.txt_DescricaoHorario.Location = new System.Drawing.Point(84, 25);
            this.txt_DescricaoHorario.Mask = "00:00 \\até 00:00";
            this.txt_DescricaoHorario.Name = "txt_DescricaoHorario";
            this.txt_DescricaoHorario.Size = new System.Drawing.Size(100, 20);
            this.txt_DescricaoHorario.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.btn_Fechar);
            this.panel1.Controls.Add(this.btn_Excluir);
            this.panel1.Controls.Add(this.btn_Salvar);
            this.panel1.Controls.Add(this.btn_Novo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 33);
            this.panel1.TabIndex = 4;
            // 
            // btn_Novo
            // 
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.Location = new System.Drawing.Point(12, 5);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(119, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo Horário";
            this.btn_Novo.UseVisualStyleBackColor = true;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salvar.Location = new System.Drawing.Point(137, 5);
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(119, 23);
            this.btn_Salvar.TabIndex = 1;
            this.btn_Salvar.Text = "Salvar Horário";
            this.btn_Salvar.UseVisualStyleBackColor = true;
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.Location = new System.Drawing.Point(262, 5);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(119, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir Horário";
            this.btn_Excluir.UseVisualStyleBackColor = true;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Fechar
            // 
            this.btn_Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Fechar.Location = new System.Drawing.Point(388, 5);
            this.btn_Fechar.Name = "btn_Fechar";
            this.btn_Fechar.Size = new System.Drawing.Size(119, 23);
            this.btn_Fechar.TabIndex = 3;
            this.btn_Fechar.Text = "Fechar";
            this.btn_Fechar.UseVisualStyleBackColor = true;
            this.btn_Fechar.Click += new System.EventHandler(this.btn_Fechar_Click);
            // 
            // dgv_Horarios
            // 
            this.dgv_Horarios.AllowUserToAddRows = false;
            this.dgv_Horarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Horarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Horarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Horarios.EnableHeadersVisualStyles = false;
            this.dgv_Horarios.Location = new System.Drawing.Point(12, 51);
            this.dgv_Horarios.MultiSelect = false;
            this.dgv_Horarios.Name = "dgv_Horarios";
            this.dgv_Horarios.ReadOnly = true;
            this.dgv_Horarios.RowHeadersVisible = false;
            this.dgv_Horarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Horarios.Size = new System.Drawing.Size(495, 360);
            this.dgv_Horarios.TabIndex = 5;
            this.dgv_Horarios.SelectionChanged += new System.EventHandler(this.dgv_Horarios_SelectionChanged);
            // 
            // frm_Horario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.dgv_Horarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_DescricaoHorario);
            this.Controls.Add(this.lbl_Horario);
            this.Controls.Add(this.txt_IDHorario);
            this.Controls.Add(this.lbl_ID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Horario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tabela de Horário";
            this.Load += new System.EventHandler(this.frm_Horario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Horarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_IDHorario;
        private System.Windows.Forms.Label lbl_Horario;
        private System.Windows.Forms.MaskedTextBox txt_DescricaoHorario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Fechar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Salvar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.DataGridView dgv_Horarios;
    }
}