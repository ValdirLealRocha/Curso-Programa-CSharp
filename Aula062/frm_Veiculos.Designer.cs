namespace Aula062
{
    partial class frm_Veiculos
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
            this.txt_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.lbl_ListaVeiculos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ListaVeiculos
            // 
            this.txt_ListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ListaVeiculos.Location = new System.Drawing.Point(15, 25);
            this.txt_ListaVeiculos.Multiline = true;
            this.txt_ListaVeiculos.Name = "txt_ListaVeiculos";
            this.txt_ListaVeiculos.Size = new System.Drawing.Size(601, 416);
            this.txt_ListaVeiculos.TabIndex = 0;
            // 
            // lbl_ListaVeiculos
            // 
            this.lbl_ListaVeiculos.AutoSize = true;
            this.lbl_ListaVeiculos.Location = new System.Drawing.Point(12, 9);
            this.lbl_ListaVeiculos.Name = "lbl_ListaVeiculos";
            this.lbl_ListaVeiculos.Size = new System.Drawing.Size(220, 13);
            this.lbl_ListaVeiculos.TabIndex = 1;
            this.lbl_ListaVeiculos.Text = "Lista de Veículos recebida do Form Principal:";
            // 
            // frm_Veiculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 453);
            this.Controls.Add(this.lbl_ListaVeiculos);
            this.Controls.Add(this.txt_ListaVeiculos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Veiculos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de Veículos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frm_Veiculos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ListaVeiculos;
        private System.Windows.Forms.Label lbl_ListaVeiculos;
    }
}