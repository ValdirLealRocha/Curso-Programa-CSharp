namespace Aula062
{
    partial class frm_CheckBox
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
            this.cbo_Carro = new System.Windows.Forms.CheckBox();
            this.cbo_Aviao = new System.Windows.Forms.CheckBox();
            this.cbo_Navio = new System.Windows.Forms.CheckBox();
            this.cbo_Onibus = new System.Windows.Forms.CheckBox();
            this.btn_TransportesMarcados = new System.Windows.Forms.Button();
            this.chb_Patinete = new System.Windows.Forms.CheckBox();
            this.btn_AbrirFormularioFilho = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_Carro
            // 
            this.cbo_Carro.AutoSize = true;
            this.cbo_Carro.Location = new System.Drawing.Point(12, 12);
            this.cbo_Carro.Name = "cbo_Carro";
            this.cbo_Carro.Size = new System.Drawing.Size(51, 17);
            this.cbo_Carro.TabIndex = 0;
            this.cbo_Carro.Text = "Carro";
            this.cbo_Carro.UseVisualStyleBackColor = true;
            // 
            // cbo_Aviao
            // 
            this.cbo_Aviao.AutoSize = true;
            this.cbo_Aviao.Location = new System.Drawing.Point(12, 35);
            this.cbo_Aviao.Name = "cbo_Aviao";
            this.cbo_Aviao.Size = new System.Drawing.Size(53, 17);
            this.cbo_Aviao.TabIndex = 1;
            this.cbo_Aviao.Text = "Avião";
            this.cbo_Aviao.UseVisualStyleBackColor = true;
            // 
            // cbo_Navio
            // 
            this.cbo_Navio.AutoSize = true;
            this.cbo_Navio.Location = new System.Drawing.Point(12, 58);
            this.cbo_Navio.Name = "cbo_Navio";
            this.cbo_Navio.Size = new System.Drawing.Size(54, 17);
            this.cbo_Navio.TabIndex = 2;
            this.cbo_Navio.Text = "Navio";
            this.cbo_Navio.UseVisualStyleBackColor = true;
            // 
            // cbo_Onibus
            // 
            this.cbo_Onibus.AutoSize = true;
            this.cbo_Onibus.Location = new System.Drawing.Point(12, 81);
            this.cbo_Onibus.Name = "cbo_Onibus";
            this.cbo_Onibus.Size = new System.Drawing.Size(59, 17);
            this.cbo_Onibus.TabIndex = 3;
            this.cbo_Onibus.Text = "Ônibus";
            this.cbo_Onibus.UseVisualStyleBackColor = true;
            // 
            // btn_TransportesMarcados
            // 
            this.btn_TransportesMarcados.Location = new System.Drawing.Point(115, 12);
            this.btn_TransportesMarcados.Name = "btn_TransportesMarcados";
            this.btn_TransportesMarcados.Size = new System.Drawing.Size(181, 23);
            this.btn_TransportesMarcados.TabIndex = 4;
            this.btn_TransportesMarcados.Text = "Transportes Marcados";
            this.btn_TransportesMarcados.UseVisualStyleBackColor = true;
            this.btn_TransportesMarcados.Click += new System.EventHandler(this.btn_TransportesMarcados_Click);
            // 
            // chb_Patinete
            // 
            this.chb_Patinete.AutoSize = true;
            this.chb_Patinete.Location = new System.Drawing.Point(12, 137);
            this.chb_Patinete.Name = "chb_Patinete";
            this.chb_Patinete.Size = new System.Drawing.Size(65, 17);
            this.chb_Patinete.TabIndex = 5;
            this.chb_Patinete.Text = "Patinete";
            this.chb_Patinete.UseVisualStyleBackColor = true;
            this.chb_Patinete.CheckedChanged += new System.EventHandler(this.chb_Patinete_CheckedChanged);
            // 
            // btn_AbrirFormularioFilho
            // 
            this.btn_AbrirFormularioFilho.Location = new System.Drawing.Point(115, 41);
            this.btn_AbrirFormularioFilho.Name = "btn_AbrirFormularioFilho";
            this.btn_AbrirFormularioFilho.Size = new System.Drawing.Size(181, 23);
            this.btn_AbrirFormularioFilho.TabIndex = 6;
            this.btn_AbrirFormularioFilho.Text = "Abrir Formulário Filho";
            this.btn_AbrirFormularioFilho.UseVisualStyleBackColor = true;
            this.btn_AbrirFormularioFilho.Click += new System.EventHandler(this.btn_AbrirFormularioFilho_Click);
            // 
            // frm_CheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 450);
            this.Controls.Add(this.btn_AbrirFormularioFilho);
            this.Controls.Add(this.chb_Patinete);
            this.Controls.Add(this.btn_TransportesMarcados);
            this.Controls.Add(this.cbo_Onibus);
            this.Controls.Add(this.cbo_Navio);
            this.Controls.Add(this.cbo_Aviao);
            this.Controls.Add(this.cbo_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_CheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_TransportesMarcados;
        private System.Windows.Forms.CheckBox chb_Patinete;
        public System.Windows.Forms.CheckBox cbo_Carro;
        public System.Windows.Forms.CheckBox cbo_Aviao;
        public System.Windows.Forms.CheckBox cbo_Navio;
        public System.Windows.Forms.CheckBox cbo_Onibus;
        private System.Windows.Forms.Button btn_AbrirFormularioFilho;
    }
}