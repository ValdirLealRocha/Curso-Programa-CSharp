namespace Aula062
{
    partial class frm_FilhoCheckBox
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
            this.cbo_Onibus = new System.Windows.Forms.CheckBox();
            this.cbo_Navio = new System.Windows.Forms.CheckBox();
            this.cbo_Aviao = new System.Windows.Forms.CheckBox();
            this.cbo_Carro = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cbo_Onibus
            // 
            this.cbo_Onibus.AutoSize = true;
            this.cbo_Onibus.Location = new System.Drawing.Point(12, 81);
            this.cbo_Onibus.Name = "cbo_Onibus";
            this.cbo_Onibus.Size = new System.Drawing.Size(59, 17);
            this.cbo_Onibus.TabIndex = 7;
            this.cbo_Onibus.Text = "Ônibus";
            this.cbo_Onibus.UseVisualStyleBackColor = true;
            this.cbo_Onibus.CheckedChanged += new System.EventHandler(this.cbo_Onibus_CheckedChanged);
            // 
            // cbo_Navio
            // 
            this.cbo_Navio.AutoSize = true;
            this.cbo_Navio.Location = new System.Drawing.Point(12, 58);
            this.cbo_Navio.Name = "cbo_Navio";
            this.cbo_Navio.Size = new System.Drawing.Size(54, 17);
            this.cbo_Navio.TabIndex = 6;
            this.cbo_Navio.Text = "Navio";
            this.cbo_Navio.UseVisualStyleBackColor = true;
            this.cbo_Navio.CheckedChanged += new System.EventHandler(this.cbo_Navio_CheckedChanged);
            // 
            // cbo_Aviao
            // 
            this.cbo_Aviao.AutoSize = true;
            this.cbo_Aviao.Location = new System.Drawing.Point(12, 35);
            this.cbo_Aviao.Name = "cbo_Aviao";
            this.cbo_Aviao.Size = new System.Drawing.Size(53, 17);
            this.cbo_Aviao.TabIndex = 5;
            this.cbo_Aviao.Text = "Avião";
            this.cbo_Aviao.UseVisualStyleBackColor = true;
            this.cbo_Aviao.CheckedChanged += new System.EventHandler(this.cbo_Aviao_CheckedChanged);
            // 
            // cbo_Carro
            // 
            this.cbo_Carro.AutoSize = true;
            this.cbo_Carro.Location = new System.Drawing.Point(12, 12);
            this.cbo_Carro.Name = "cbo_Carro";
            this.cbo_Carro.Size = new System.Drawing.Size(51, 17);
            this.cbo_Carro.TabIndex = 4;
            this.cbo_Carro.Text = "Carro";
            this.cbo_Carro.UseVisualStyleBackColor = true;
            this.cbo_Carro.CheckedChanged += new System.EventHandler(this.cbo_Carro_CheckedChanged);
            // 
            // frm_FilhoCheckBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 295);
            this.Controls.Add(this.cbo_Onibus);
            this.Controls.Add(this.cbo_Navio);
            this.Controls.Add(this.cbo_Aviao);
            this.Controls.Add(this.cbo_Carro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_FilhoCheckBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filho CheckBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbo_Onibus;
        private System.Windows.Forms.CheckBox cbo_Navio;
        private System.Windows.Forms.CheckBox cbo_Aviao;
        private System.Windows.Forms.CheckBox cbo_Carro;
    }
}