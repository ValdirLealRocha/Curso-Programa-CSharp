namespace Aula062
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
            this.txt_Veiculo = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lbl_Veiculo = new System.Windows.Forms.Label();
            this.txt_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Veiculo
            // 
            this.txt_Veiculo.Location = new System.Drawing.Point(12, 25);
            this.txt_Veiculo.Name = "txt_Veiculo";
            this.txt_Veiculo.Size = new System.Drawing.Size(170, 20);
            this.txt_Veiculo.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(188, 25);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lbl_Veiculo
            // 
            this.lbl_Veiculo.AutoSize = true;
            this.lbl_Veiculo.Location = new System.Drawing.Point(12, 9);
            this.lbl_Veiculo.Name = "lbl_Veiculo";
            this.lbl_Veiculo.Size = new System.Drawing.Size(91, 13);
            this.lbl_Veiculo.TabIndex = 2;
            this.lbl_Veiculo.Text = "Digite um Veículo";
            // 
            // txt_ListaVeiculos
            // 
            this.txt_ListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ListaVeiculos.Location = new System.Drawing.Point(15, 54);
            this.txt_ListaVeiculos.Multiline = true;
            this.txt_ListaVeiculos.Name = "txt_ListaVeiculos";
            this.txt_ListaVeiculos.Size = new System.Drawing.Size(248, 248);
            this.txt_ListaVeiculos.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(15, 308);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(248, 23);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 338);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_ListaVeiculos);
            this.Controls.Add(this.lbl_Veiculo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_Veiculo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal | Aulas 62 do Curso de C# - CFB Cursos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Veiculo;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label lbl_Veiculo;
        private System.Windows.Forms.TextBox txt_ListaVeiculos;
        private System.Windows.Forms.Button btn_Limpar;
    }
}

