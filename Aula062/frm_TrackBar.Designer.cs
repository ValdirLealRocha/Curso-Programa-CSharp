namespace Aula062
{
    partial class frm_TrackBar
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
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.txt_Valor = new System.Windows.Forms.TextBox();
            this.btn_Definir = new System.Windows.Forms.Button();
            this.lbl_Valor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 12);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(448, 45);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // txt_Valor
            // 
            this.txt_Valor.Location = new System.Drawing.Point(12, 76);
            this.txt_Valor.Name = "txt_Valor";
            this.txt_Valor.Size = new System.Drawing.Size(100, 20);
            this.txt_Valor.TabIndex = 1;
            // 
            // btn_Definir
            // 
            this.btn_Definir.Location = new System.Drawing.Point(118, 76);
            this.btn_Definir.Name = "btn_Definir";
            this.btn_Definir.Size = new System.Drawing.Size(75, 23);
            this.btn_Definir.TabIndex = 2;
            this.btn_Definir.Text = "Definir";
            this.btn_Definir.UseVisualStyleBackColor = true;
            this.btn_Definir.Click += new System.EventHandler(this.btn_Definir_Click);
            // 
            // lbl_Valor
            // 
            this.lbl_Valor.AutoSize = true;
            this.lbl_Valor.Location = new System.Drawing.Point(12, 99);
            this.lbl_Valor.Name = "lbl_Valor";
            this.lbl_Valor.Size = new System.Drawing.Size(13, 13);
            this.lbl_Valor.TabIndex = 3;
            this.lbl_Valor.Text = "0";
            // 
            // frm_TrackBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.lbl_Valor);
            this.Controls.Add(this.btn_Definir);
            this.Controls.Add(this.txt_Valor);
            this.Controls.Add(this.trackBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TrackBar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TrackBar";
            this.Load += new System.EventHandler(this.frm_TrackBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.TextBox txt_Valor;
        private System.Windows.Forms.Button btn_Definir;
        private System.Windows.Forms.Label lbl_Valor;
    }
}