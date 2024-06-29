namespace Aula062
{
    partial class frm_ComboBox
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
            this.cmb_Transportes = new System.Windows.Forms.ComboBox();
            this.btn_MostrarSelecionados = new System.Windows.Forms.Button();
            this.btn_LimparElementos = new System.Windows.Forms.Button();
            this.btn_ResetarElementos = new System.Windows.Forms.Button();
            this.btn_AdicionarNovoTransporte = new System.Windows.Forms.Button();
            this.txt_Transporte = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmb_Transportes
            // 
            this.cmb_Transportes.FormattingEnabled = true;
            this.cmb_Transportes.Items.AddRange(new object[] {
            "Carro",
            "Avião",
            "Navio",
            "Ônibus",
            "Trem"});
            this.cmb_Transportes.Location = new System.Drawing.Point(12, 12);
            this.cmb_Transportes.Name = "cmb_Transportes";
            this.cmb_Transportes.Size = new System.Drawing.Size(227, 21);
            this.cmb_Transportes.TabIndex = 0;
            this.cmb_Transportes.SelectedIndexChanged += new System.EventHandler(this.cmb_Transportes_SelectedIndexChanged);
            // 
            // btn_MostrarSelecionados
            // 
            this.btn_MostrarSelecionados.Location = new System.Drawing.Point(245, 12);
            this.btn_MostrarSelecionados.Name = "btn_MostrarSelecionados";
            this.btn_MostrarSelecionados.Size = new System.Drawing.Size(174, 23);
            this.btn_MostrarSelecionados.TabIndex = 2;
            this.btn_MostrarSelecionados.Text = "Mostrar Selecionados";
            this.btn_MostrarSelecionados.UseVisualStyleBackColor = true;
            this.btn_MostrarSelecionados.Click += new System.EventHandler(this.btn_MostrarSelecionados_Click);
            // 
            // btn_LimparElementos
            // 
            this.btn_LimparElementos.Location = new System.Drawing.Point(245, 41);
            this.btn_LimparElementos.Name = "btn_LimparElementos";
            this.btn_LimparElementos.Size = new System.Drawing.Size(174, 23);
            this.btn_LimparElementos.TabIndex = 3;
            this.btn_LimparElementos.Text = "Limpar Elementos";
            this.btn_LimparElementos.UseVisualStyleBackColor = true;
            this.btn_LimparElementos.Click += new System.EventHandler(this.btn_LimparElementos_Click);
            // 
            // btn_ResetarElementos
            // 
            this.btn_ResetarElementos.Location = new System.Drawing.Point(245, 70);
            this.btn_ResetarElementos.Name = "btn_ResetarElementos";
            this.btn_ResetarElementos.Size = new System.Drawing.Size(174, 23);
            this.btn_ResetarElementos.TabIndex = 4;
            this.btn_ResetarElementos.Text = "Resetar Elementos";
            this.btn_ResetarElementos.UseVisualStyleBackColor = true;
            this.btn_ResetarElementos.Click += new System.EventHandler(this.btn_ResetarElementos_Click);
            // 
            // btn_AdicionarNovoTransporte
            // 
            this.btn_AdicionarNovoTransporte.Location = new System.Drawing.Point(245, 154);
            this.btn_AdicionarNovoTransporte.Name = "btn_AdicionarNovoTransporte";
            this.btn_AdicionarNovoTransporte.Size = new System.Drawing.Size(174, 23);
            this.btn_AdicionarNovoTransporte.TabIndex = 5;
            this.btn_AdicionarNovoTransporte.Text = "Adicionar Novo Transporte";
            this.btn_AdicionarNovoTransporte.UseVisualStyleBackColor = true;
            this.btn_AdicionarNovoTransporte.Click += new System.EventHandler(this.btn_AdicionarNovoTransporte_Click);
            // 
            // txt_Transporte
            // 
            this.txt_Transporte.Location = new System.Drawing.Point(245, 128);
            this.txt_Transporte.Name = "txt_Transporte";
            this.txt_Transporte.Size = new System.Drawing.Size(174, 20);
            this.txt_Transporte.TabIndex = 6;
            // 
            // frm_ComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 450);
            this.Controls.Add(this.txt_Transporte);
            this.Controls.Add(this.btn_AdicionarNovoTransporte);
            this.Controls.Add(this.btn_ResetarElementos);
            this.Controls.Add(this.btn_LimparElementos);
            this.Controls.Add(this.btn_MostrarSelecionados);
            this.Controls.Add(this.cmb_Transportes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ComboBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_Transportes;
        private System.Windows.Forms.Button btn_MostrarSelecionados;
        private System.Windows.Forms.Button btn_LimparElementos;
        private System.Windows.Forms.Button btn_ResetarElementos;
        private System.Windows.Forms.Button btn_AdicionarNovoTransporte;
        private System.Windows.Forms.TextBox txt_Transporte;
    }
}