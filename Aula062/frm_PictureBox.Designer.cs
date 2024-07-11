namespace Aula062
{
    partial class frm_PictureBox
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
            this.pcb_Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Logo1 = new System.Windows.Forms.Button();
            this.btn_Logo2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pcb_Logo
            // 
            this.pcb_Logo.Image = global::Aula062.Properties.Resources.eu_valdir_leal_rocha_gestor_de_trafego_iesi;
            this.pcb_Logo.Location = new System.Drawing.Point(12, 12);
            this.pcb_Logo.Name = "pcb_Logo";
            this.pcb_Logo.Size = new System.Drawing.Size(250, 250);
            this.pcb_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcb_Logo.TabIndex = 0;
            this.pcb_Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // btn_Logo1
            // 
            this.btn_Logo1.Location = new System.Drawing.Point(333, 102);
            this.btn_Logo1.Name = "btn_Logo1";
            this.btn_Logo1.Size = new System.Drawing.Size(75, 23);
            this.btn_Logo1.TabIndex = 3;
            this.btn_Logo1.Text = "Logo 1";
            this.btn_Logo1.UseVisualStyleBackColor = true;
            this.btn_Logo1.Click += new System.EventHandler(this.btn_Logo1_Click);
            // 
            // btn_Logo2
            // 
            this.btn_Logo2.Location = new System.Drawing.Point(333, 131);
            this.btn_Logo2.Name = "btn_Logo2";
            this.btn_Logo2.Size = new System.Drawing.Size(75, 23);
            this.btn_Logo2.TabIndex = 4;
            this.btn_Logo2.Text = "Logo 2";
            this.btn_Logo2.UseVisualStyleBackColor = true;
            this.btn_Logo2.Click += new System.EventHandler(this.btn_Logo2_Click);
            // 
            // frm_PictureBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 450);
            this.Controls.Add(this.btn_Logo2);
            this.Controls.Add(this.btn_Logo1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcb_Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_PictureBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PictureBox";
            this.Load += new System.EventHandler(this.frm_PictureBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcb_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcb_Logo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Logo1;
        private System.Windows.Forms.Button btn_Logo2;
    }
}