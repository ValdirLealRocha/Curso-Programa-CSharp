namespace Aula062
{
    partial class frm_WebBrowser
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.btn_Navegar = new System.Windows.Forms.Button();
            this.btn_Home = new System.Windows.Forms.Button();
            this.btn_Voltar = new System.Windows.Forms.Button();
            this.btn_Atualizar = new System.Windows.Forms.Button();
            this.btn_Parar = new System.Windows.Forms.Button();
            this.btn_Proximo = new System.Windows.Forms.Button();
            this.btn_Pesquisa = new System.Windows.Forms.Button();
            this.btn_definirHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.webBrowser1.Location = new System.Drawing.Point(0, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(785, 395);
            this.webBrowser1.TabIndex = 1;
            // 
            // txt_Url
            // 
            this.txt_Url.Dock = System.Windows.Forms.DockStyle.Top;
            this.txt_Url.Location = new System.Drawing.Point(0, 0);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(785, 20);
            this.txt_Url.TabIndex = 0;
            this.txt_Url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_Url_KeyDown);
            // 
            // btn_Navegar
            // 
            this.btn_Navegar.Location = new System.Drawing.Point(0, 26);
            this.btn_Navegar.Name = "btn_Navegar";
            this.btn_Navegar.Size = new System.Drawing.Size(75, 23);
            this.btn_Navegar.TabIndex = 2;
            this.btn_Navegar.Text = "Navegar";
            this.btn_Navegar.UseVisualStyleBackColor = true;
            this.btn_Navegar.Click += new System.EventHandler(this.btn_Navegar_Click);
            // 
            // btn_Home
            // 
            this.btn_Home.Location = new System.Drawing.Point(81, 26);
            this.btn_Home.Name = "btn_Home";
            this.btn_Home.Size = new System.Drawing.Size(75, 23);
            this.btn_Home.TabIndex = 3;
            this.btn_Home.Text = "Home";
            this.btn_Home.UseVisualStyleBackColor = true;
            this.btn_Home.Click += new System.EventHandler(this.btn_Home_Click);
            // 
            // btn_Voltar
            // 
            this.btn_Voltar.Location = new System.Drawing.Point(162, 26);
            this.btn_Voltar.Name = "btn_Voltar";
            this.btn_Voltar.Size = new System.Drawing.Size(75, 23);
            this.btn_Voltar.TabIndex = 4;
            this.btn_Voltar.Text = "Voltar";
            this.btn_Voltar.UseVisualStyleBackColor = true;
            this.btn_Voltar.Click += new System.EventHandler(this.btn_Voltar_Click);
            // 
            // btn_Atualizar
            // 
            this.btn_Atualizar.Location = new System.Drawing.Point(405, 26);
            this.btn_Atualizar.Name = "btn_Atualizar";
            this.btn_Atualizar.Size = new System.Drawing.Size(75, 23);
            this.btn_Atualizar.TabIndex = 7;
            this.btn_Atualizar.Text = "Atualizar";
            this.btn_Atualizar.UseVisualStyleBackColor = true;
            this.btn_Atualizar.Click += new System.EventHandler(this.btn_Atualizar_Click);
            // 
            // btn_Parar
            // 
            this.btn_Parar.Location = new System.Drawing.Point(324, 26);
            this.btn_Parar.Name = "btn_Parar";
            this.btn_Parar.Size = new System.Drawing.Size(75, 23);
            this.btn_Parar.TabIndex = 6;
            this.btn_Parar.Text = "Parar";
            this.btn_Parar.UseVisualStyleBackColor = true;
            this.btn_Parar.Click += new System.EventHandler(this.btn_Parar_Click);
            // 
            // btn_Proximo
            // 
            this.btn_Proximo.Location = new System.Drawing.Point(243, 26);
            this.btn_Proximo.Name = "btn_Proximo";
            this.btn_Proximo.Size = new System.Drawing.Size(75, 23);
            this.btn_Proximo.TabIndex = 5;
            this.btn_Proximo.Text = "Próximo";
            this.btn_Proximo.UseVisualStyleBackColor = true;
            this.btn_Proximo.Click += new System.EventHandler(this.btn_Proximo_Click);
            // 
            // btn_Pesquisa
            // 
            this.btn_Pesquisa.Location = new System.Drawing.Point(486, 26);
            this.btn_Pesquisa.Name = "btn_Pesquisa";
            this.btn_Pesquisa.Size = new System.Drawing.Size(75, 23);
            this.btn_Pesquisa.TabIndex = 8;
            this.btn_Pesquisa.Text = "Pesquisa";
            this.btn_Pesquisa.UseVisualStyleBackColor = true;
            this.btn_Pesquisa.Click += new System.EventHandler(this.btn_Pesquisa_Click);
            // 
            // btn_definirHome
            // 
            this.btn_definirHome.Location = new System.Drawing.Point(567, 26);
            this.btn_definirHome.Name = "btn_definirHome";
            this.btn_definirHome.Size = new System.Drawing.Size(99, 23);
            this.btn_definirHome.TabIndex = 9;
            this.btn_definirHome.Text = "Definir Home";
            this.btn_definirHome.UseVisualStyleBackColor = true;
            this.btn_definirHome.Click += new System.EventHandler(this.btn_definirHome_Click);
            // 
            // frm_WebBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 450);
            this.Controls.Add(this.btn_definirHome);
            this.Controls.Add(this.btn_Pesquisa);
            this.Controls.Add(this.btn_Atualizar);
            this.Controls.Add(this.btn_Parar);
            this.Controls.Add(this.btn_Proximo);
            this.Controls.Add(this.btn_Voltar);
            this.Controls.Add(this.btn_Home);
            this.Controls.Add(this.btn_Navegar);
            this.Controls.Add(this.txt_Url);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_WebBrowser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebBrowser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.Button btn_Navegar;
        private System.Windows.Forms.Button btn_Home;
        private System.Windows.Forms.Button btn_Voltar;
        private System.Windows.Forms.Button btn_Atualizar;
        private System.Windows.Forms.Button btn_Parar;
        private System.Windows.Forms.Button btn_Proximo;
        private System.Windows.Forms.Button btn_Pesquisa;
        private System.Windows.Forms.Button btn_definirHome;
    }
}