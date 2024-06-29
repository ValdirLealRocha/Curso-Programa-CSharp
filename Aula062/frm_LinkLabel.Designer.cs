namespace Aula062
{
    partial class frm_LinkLabel
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
            this.lbl_DigiteSeuNome = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.lkl_Canal = new System.Windows.Forms.LinkLabel();
            this.lkl_Calculadora = new System.Windows.Forms.LinkLabel();
            this.lkl_MultiplosLinks = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_DigiteSeuNome
            // 
            this.lbl_DigiteSeuNome.AutoSize = true;
            this.lbl_DigiteSeuNome.Location = new System.Drawing.Point(12, 9);
            this.lbl_DigiteSeuNome.Name = "lbl_DigiteSeuNome";
            this.lbl_DigiteSeuNome.Size = new System.Drawing.Size(83, 13);
            this.lbl_DigiteSeuNome.TabIndex = 0;
            this.lbl_DigiteSeuNome.Text = "Digite seu nome";
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(15, 25);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(227, 20);
            this.txt_Nome.TabIndex = 1;
            // 
            // lkl_Canal
            // 
            this.lkl_Canal.AutoSize = true;
            this.lkl_Canal.Location = new System.Drawing.Point(12, 77);
            this.lkl_Canal.Name = "lkl_Canal";
            this.lkl_Canal.Size = new System.Drawing.Size(34, 13);
            this.lkl_Canal.TabIndex = 2;
            this.lkl_Canal.TabStop = true;
            this.lkl_Canal.Text = "Canal";
            this.lkl_Canal.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Canal_LinkClicked);
            // 
            // lkl_Calculadora
            // 
            this.lkl_Calculadora.AutoSize = true;
            this.lkl_Calculadora.Location = new System.Drawing.Point(73, 77);
            this.lkl_Calculadora.Name = "lkl_Calculadora";
            this.lkl_Calculadora.Size = new System.Drawing.Size(63, 13);
            this.lkl_Calculadora.TabIndex = 3;
            this.lkl_Calculadora.TabStop = true;
            this.lkl_Calculadora.Text = "Calculadora";
            this.lkl_Calculadora.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_Calculadora_LinkClicked);
            // 
            // lkl_MultiplosLinks
            // 
            this.lkl_MultiplosLinks.AutoSize = true;
            this.lkl_MultiplosLinks.Location = new System.Drawing.Point(12, 118);
            this.lkl_MultiplosLinks.Name = "lkl_MultiplosLinks";
            this.lkl_MultiplosLinks.Size = new System.Drawing.Size(126, 13);
            this.lkl_MultiplosLinks.TabIndex = 4;
            this.lkl_MultiplosLinks.TabStop = true;
            this.lkl_MultiplosLinks.Text = "Google - Canal - Youtube";
            this.lkl_MultiplosLinks.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_MultiplosLinks_LinkClicked);
            // 
            // frm_LinkLabel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 450);
            this.Controls.Add(this.lkl_MultiplosLinks);
            this.Controls.Add(this.lkl_Calculadora);
            this.Controls.Add(this.lkl_Canal);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.lbl_DigiteSeuNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_LinkLabel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LinkLabel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_DigiteSeuNome;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.LinkLabel lkl_Canal;
        private System.Windows.Forms.LinkLabel lkl_Calculadora;
        private System.Windows.Forms.LinkLabel lkl_MultiplosLinks;
    }
}