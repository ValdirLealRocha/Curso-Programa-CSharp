namespace Aula062
{
    partial class frm_CheckedListBox
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
            this.clb_Transportes = new System.Windows.Forms.CheckedListBox();
            this.btn_Selecionados = new System.Windows.Forms.Button();
            this.btn_LimparLista = new System.Windows.Forms.Button();
            this.btn_ResetarLista = new System.Windows.Forms.Button();
            this.btn_AdicionaNovoTransporte = new System.Windows.Forms.Button();
            this.txt_NovoTransporte = new System.Windows.Forms.TextBox();
            this.lbl_NovoTransporte = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clb_Transportes
            // 
            this.clb_Transportes.FormattingEnabled = true;
            this.clb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.clb_Transportes.Location = new System.Drawing.Point(12, 12);
            this.clb_Transportes.Name = "clb_Transportes";
            this.clb_Transportes.Size = new System.Drawing.Size(199, 244);
            this.clb_Transportes.TabIndex = 0;
            // 
            // btn_Selecionados
            // 
            this.btn_Selecionados.Location = new System.Drawing.Point(220, 12);
            this.btn_Selecionados.Name = "btn_Selecionados";
            this.btn_Selecionados.Size = new System.Drawing.Size(144, 23);
            this.btn_Selecionados.TabIndex = 1;
            this.btn_Selecionados.Text = "Mostrar Selecionados";
            this.btn_Selecionados.UseVisualStyleBackColor = true;
            this.btn_Selecionados.Click += new System.EventHandler(this.btn_Selecionados_Click);
            // 
            // btn_LimparLista
            // 
            this.btn_LimparLista.Location = new System.Drawing.Point(220, 41);
            this.btn_LimparLista.Name = "btn_LimparLista";
            this.btn_LimparLista.Size = new System.Drawing.Size(144, 23);
            this.btn_LimparLista.TabIndex = 2;
            this.btn_LimparLista.Text = "Limpar Lista";
            this.btn_LimparLista.UseVisualStyleBackColor = true;
            this.btn_LimparLista.Click += new System.EventHandler(this.btn_LimparLista_Click);
            // 
            // btn_ResetarLista
            // 
            this.btn_ResetarLista.Location = new System.Drawing.Point(220, 70);
            this.btn_ResetarLista.Name = "btn_ResetarLista";
            this.btn_ResetarLista.Size = new System.Drawing.Size(144, 23);
            this.btn_ResetarLista.TabIndex = 3;
            this.btn_ResetarLista.Text = "Resetar Lista";
            this.btn_ResetarLista.UseVisualStyleBackColor = true;
            this.btn_ResetarLista.Click += new System.EventHandler(this.btn_ResetarLista_Click);
            // 
            // btn_AdicionaNovoTransporte
            // 
            this.btn_AdicionaNovoTransporte.Location = new System.Drawing.Point(220, 236);
            this.btn_AdicionaNovoTransporte.Name = "btn_AdicionaNovoTransporte";
            this.btn_AdicionaNovoTransporte.Size = new System.Drawing.Size(144, 23);
            this.btn_AdicionaNovoTransporte.TabIndex = 4;
            this.btn_AdicionaNovoTransporte.Text = "Adiciona Novo Transporte";
            this.btn_AdicionaNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionaNovoTransporte.Click += new System.EventHandler(this.btn_AdicionaNovoTransporte_Click);
            // 
            // txt_NovoTransporte
            // 
            this.txt_NovoTransporte.Location = new System.Drawing.Point(220, 210);
            this.txt_NovoTransporte.Name = "txt_NovoTransporte";
            this.txt_NovoTransporte.Size = new System.Drawing.Size(144, 20);
            this.txt_NovoTransporte.TabIndex = 5;
            // 
            // lbl_NovoTransporte
            // 
            this.lbl_NovoTransporte.AutoSize = true;
            this.lbl_NovoTransporte.Location = new System.Drawing.Point(217, 194);
            this.lbl_NovoTransporte.Name = "lbl_NovoTransporte";
            this.lbl_NovoTransporte.Size = new System.Drawing.Size(117, 13);
            this.lbl_NovoTransporte.TabIndex = 6;
            this.lbl_NovoTransporte.Text = "Digite Novo Transporte";
            // 
            // frm_CheckedListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 273);
            this.Controls.Add(this.lbl_NovoTransporte);
            this.Controls.Add(this.txt_NovoTransporte);
            this.Controls.Add(this.btn_AdicionaNovoTransporte);
            this.Controls.Add(this.btn_ResetarLista);
            this.Controls.Add(this.btn_LimparLista);
            this.Controls.Add(this.btn_Selecionados);
            this.Controls.Add(this.clb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_CheckedListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckedListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clb_Transportes;
        private System.Windows.Forms.Button btn_Selecionados;
        private System.Windows.Forms.Button btn_LimparLista;
        private System.Windows.Forms.Button btn_ResetarLista;
        private System.Windows.Forms.Button btn_AdicionaNovoTransporte;
        private System.Windows.Forms.TextBox txt_NovoTransporte;
        private System.Windows.Forms.Label lbl_NovoTransporte;
    }
}