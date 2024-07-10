namespace Aula062
{
    partial class frm_ListBox
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
            this.ltb_Carros = new System.Windows.Forms.ListBox();
            this.txt_Carro = new System.Windows.Forms.TextBox();
            this.lbl_carro = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltb_Carros
            // 
            this.ltb_Carros.FormattingEnabled = true;
            this.ltb_Carros.Location = new System.Drawing.Point(12, 12);
            this.ltb_Carros.Name = "ltb_Carros";
            this.ltb_Carros.Size = new System.Drawing.Size(231, 238);
            this.ltb_Carros.TabIndex = 0;
            // 
            // txt_Carro
            // 
            this.txt_Carro.Location = new System.Drawing.Point(249, 28);
            this.txt_Carro.Name = "txt_Carro";
            this.txt_Carro.Size = new System.Drawing.Size(161, 20);
            this.txt_Carro.TabIndex = 1;
            // 
            // lbl_carro
            // 
            this.lbl_carro.AutoSize = true;
            this.lbl_carro.Location = new System.Drawing.Point(249, 12);
            this.lbl_carro.Name = "lbl_carro";
            this.lbl_carro.Size = new System.Drawing.Size(32, 13);
            this.lbl_carro.TabIndex = 2;
            this.lbl_carro.Text = "Carro";
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(252, 54);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(158, 23);
            this.btn_Add.TabIndex = 3;
            this.btn_Add.Text = "Adicionar";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(252, 83);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(158, 23);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(252, 112);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(158, 23);
            this.btn_Obter.TabIndex = 5;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(252, 141);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(158, 23);
            this.btn_Limpar.TabIndex = 6;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // frm_ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 450);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.lbl_carro);
            this.Controls.Add(this.txt_Carro);
            this.Controls.Add(this.ltb_Carros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ListBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ltb_Carros;
        private System.Windows.Forms.TextBox txt_Carro;
        private System.Windows.Forms.Label lbl_carro;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button btn_Limpar;
    }
}