namespace Aula062
{
    partial class frm_Timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_Iniciar_t1 = new System.Windows.Forms.Button();
            this.btn_Parar_t1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Reiniciar_t1 = new System.Windows.Forms.Button();
            this.img_Carro = new System.Windows.Forms.PictureBox();
            this.timer_Carro = new System.Windows.Forms.Timer(this.components);
            this.btn_Ligar = new System.Windows.Forms.Button();
            this.btn_Desligar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_Iniciar_t1
            // 
            this.btn_Iniciar_t1.Location = new System.Drawing.Point(12, 12);
            this.btn_Iniciar_t1.Name = "btn_Iniciar_t1";
            this.btn_Iniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_Iniciar_t1.TabIndex = 0;
            this.btn_Iniciar_t1.Text = "Iniciar";
            this.btn_Iniciar_t1.UseVisualStyleBackColor = true;
            this.btn_Iniciar_t1.Click += new System.EventHandler(this.btn_Iniciar_t1_Click);
            // 
            // btn_Parar_t1
            // 
            this.btn_Parar_t1.Location = new System.Drawing.Point(93, 12);
            this.btn_Parar_t1.Name = "btn_Parar_t1";
            this.btn_Parar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar_t1.TabIndex = 1;
            this.btn_Parar_t1.Text = "Parar";
            this.btn_Parar_t1.UseVisualStyleBackColor = true;
            this.btn_Parar_t1.Click += new System.EventHandler(this.btn_Parar_t1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "0";
            // 
            // btn_Reiniciar_t1
            // 
            this.btn_Reiniciar_t1.Location = new System.Drawing.Point(174, 12);
            this.btn_Reiniciar_t1.Name = "btn_Reiniciar_t1";
            this.btn_Reiniciar_t1.Size = new System.Drawing.Size(75, 23);
            this.btn_Reiniciar_t1.TabIndex = 3;
            this.btn_Reiniciar_t1.Text = "Reiniciar";
            this.btn_Reiniciar_t1.UseVisualStyleBackColor = true;
            this.btn_Reiniciar_t1.Click += new System.EventHandler(this.btn_Reiniciar_t1_Click);
            // 
            // img_Carro
            // 
            this.img_Carro.Image = global::Aula062.Properties.Resources.carro1;
            this.img_Carro.Location = new System.Drawing.Point(12, 143);
            this.img_Carro.Name = "img_Carro";
            this.img_Carro.Size = new System.Drawing.Size(129, 109);
            this.img_Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.img_Carro.TabIndex = 4;
            this.img_Carro.TabStop = false;
            // 
            // timer_Carro
            // 
            this.timer_Carro.Interval = 1;
            this.timer_Carro.Tick += new System.EventHandler(this.timer_Carro_Tick);
            // 
            // btn_Ligar
            // 
            this.btn_Ligar.Location = new System.Drawing.Point(12, 114);
            this.btn_Ligar.Name = "btn_Ligar";
            this.btn_Ligar.Size = new System.Drawing.Size(103, 23);
            this.btn_Ligar.TabIndex = 5;
            this.btn_Ligar.Text = "Liga o Carro";
            this.btn_Ligar.UseVisualStyleBackColor = true;
            this.btn_Ligar.Click += new System.EventHandler(this.btn_Ligar_Click);
            // 
            // btn_Desligar
            // 
            this.btn_Desligar.Enabled = false;
            this.btn_Desligar.Location = new System.Drawing.Point(121, 114);
            this.btn_Desligar.Name = "btn_Desligar";
            this.btn_Desligar.Size = new System.Drawing.Size(103, 23);
            this.btn_Desligar.TabIndex = 6;
            this.btn_Desligar.Text = "Desliga o Carro";
            this.btn_Desligar.UseVisualStyleBackColor = true;
            this.btn_Desligar.Click += new System.EventHandler(this.btn_Desligar_Click);
            // 
            // frm_Timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 450);
            this.Controls.Add(this.btn_Desligar);
            this.Controls.Add(this.btn_Ligar);
            this.Controls.Add(this.img_Carro);
            this.Controls.Add(this.btn_Reiniciar_t1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Parar_t1);
            this.Controls.Add(this.btn_Iniciar_t1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Timer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.frm_Timer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.img_Carro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_Iniciar_t1;
        private System.Windows.Forms.Button btn_Parar_t1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Reiniciar_t1;
        private System.Windows.Forms.PictureBox img_Carro;
        private System.Windows.Forms.Timer timer_Carro;
        private System.Windows.Forms.Button btn_Ligar;
        private System.Windows.Forms.Button btn_Desligar;
    }
}