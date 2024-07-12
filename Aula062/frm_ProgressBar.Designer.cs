namespace Aula062
{
    partial class frm_ProgressBar
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
            this.prb_Barra = new System.Windows.Forms.ProgressBar();
            this.btn_DefinirValor = new System.Windows.Forms.Button();
            this.txt_DefinirValor = new System.Windows.Forms.TextBox();
            this.btn_Preencher = new System.Windows.Forms.Button();
            this.lbl_Porcentagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // prb_Barra
            // 
            this.prb_Barra.Location = new System.Drawing.Point(12, 116);
            this.prb_Barra.Name = "prb_Barra";
            this.prb_Barra.Size = new System.Drawing.Size(573, 23);
            this.prb_Barra.Step = 1;
            this.prb_Barra.TabIndex = 2;
            this.prb_Barra.Value = 50;
            // 
            // btn_DefinirValor
            // 
            this.btn_DefinirValor.Location = new System.Drawing.Point(12, 38);
            this.btn_DefinirValor.Name = "btn_DefinirValor";
            this.btn_DefinirValor.Size = new System.Drawing.Size(100, 23);
            this.btn_DefinirValor.TabIndex = 1;
            this.btn_DefinirValor.Text = "Definir Valor";
            this.btn_DefinirValor.UseVisualStyleBackColor = true;
            this.btn_DefinirValor.Click += new System.EventHandler(this.btn_DefinirValor_Click);
            // 
            // txt_DefinirValor
            // 
            this.txt_DefinirValor.Location = new System.Drawing.Point(12, 12);
            this.txt_DefinirValor.Name = "txt_DefinirValor";
            this.txt_DefinirValor.Size = new System.Drawing.Size(100, 20);
            this.txt_DefinirValor.TabIndex = 0;
            this.txt_DefinirValor.Text = "0";
            // 
            // btn_Preencher
            // 
            this.btn_Preencher.Location = new System.Drawing.Point(12, 87);
            this.btn_Preencher.Name = "btn_Preencher";
            this.btn_Preencher.Size = new System.Drawing.Size(100, 23);
            this.btn_Preencher.TabIndex = 3;
            this.btn_Preencher.Text = "Preencher";
            this.btn_Preencher.UseVisualStyleBackColor = true;
            this.btn_Preencher.Click += new System.EventHandler(this.btn_Preencher_Click);
            // 
            // lbl_Porcentagem
            // 
            this.lbl_Porcentagem.AutoSize = true;
            this.lbl_Porcentagem.Location = new System.Drawing.Point(281, 142);
            this.lbl_Porcentagem.Name = "lbl_Porcentagem";
            this.lbl_Porcentagem.Size = new System.Drawing.Size(74, 13);
            this.lbl_Porcentagem.TabIndex = 4;
            this.lbl_Porcentagem.Text = "Aguardando...";
            this.lbl_Porcentagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 450);
            this.Controls.Add(this.lbl_Porcentagem);
            this.Controls.Add(this.btn_Preencher);
            this.Controls.Add(this.txt_DefinirValor);
            this.Controls.Add(this.btn_DefinirValor);
            this.Controls.Add(this.prb_Barra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ProgressBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProgressBar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar prb_Barra;
        private System.Windows.Forms.Button btn_DefinirValor;
        private System.Windows.Forms.TextBox txt_DefinirValor;
        private System.Windows.Forms.Button btn_Preencher;
        private System.Windows.Forms.Label lbl_Porcentagem;
    }
}