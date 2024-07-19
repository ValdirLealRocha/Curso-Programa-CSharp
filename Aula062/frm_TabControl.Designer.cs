namespace Aula062
{
    partial class frm_TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_Componentes = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.txt_NovaTab = new System.Windows.Forms.TextBox();
            this.btn_NovaTab = new System.Windows.Forms.Button();
            this.btn_RemoverTabAtual = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btn_PosicionarTab = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tab_Componentes.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_Componentes);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 64);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 374);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_Componentes
            // 
            this.tab_Componentes.Controls.Add(this.button1);
            this.tab_Componentes.Controls.Add(this.label1);
            this.tab_Componentes.Controls.Add(this.textBox1);
            this.tab_Componentes.Location = new System.Drawing.Point(4, 22);
            this.tab_Componentes.Name = "tab_Componentes";
            this.tab_Componentes.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Componentes.Size = new System.Drawing.Size(768, 348);
            this.tab_Componentes.TabIndex = 0;
            this.tab_Componentes.Text = "Componentes";
            this.tab_Componentes.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 348);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // txt_NovaTab
            // 
            this.txt_NovaTab.Location = new System.Drawing.Point(12, 12);
            this.txt_NovaTab.Name = "txt_NovaTab";
            this.txt_NovaTab.Size = new System.Drawing.Size(100, 20);
            this.txt_NovaTab.TabIndex = 1;
            // 
            // btn_NovaTab
            // 
            this.btn_NovaTab.Location = new System.Drawing.Point(118, 12);
            this.btn_NovaTab.Name = "btn_NovaTab";
            this.btn_NovaTab.Size = new System.Drawing.Size(184, 23);
            this.btn_NovaTab.TabIndex = 2;
            this.btn_NovaTab.Text = "Nova Tab";
            this.btn_NovaTab.UseVisualStyleBackColor = true;
            this.btn_NovaTab.Click += new System.EventHandler(this.btn_NovaTab_Click);
            // 
            // btn_RemoverTabAtual
            // 
            this.btn_RemoverTabAtual.Location = new System.Drawing.Point(308, 12);
            this.btn_RemoverTabAtual.Name = "btn_RemoverTabAtual";
            this.btn_RemoverTabAtual.Size = new System.Drawing.Size(184, 23);
            this.btn_RemoverTabAtual.TabIndex = 3;
            this.btn_RemoverTabAtual.Text = "Remover Tab Atual";
            this.btn_RemoverTabAtual.UseVisualStyleBackColor = true;
            this.btn_RemoverTabAtual.Click += new System.EventHandler(this.btn_RemoverTabAtual_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(12, 38);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(100, 20);
            this.numericUpDown1.TabIndex = 4;
            // 
            // btn_PosicionarTab
            // 
            this.btn_PosicionarTab.Location = new System.Drawing.Point(118, 38);
            this.btn_PosicionarTab.Name = "btn_PosicionarTab";
            this.btn_PosicionarTab.Size = new System.Drawing.Size(184, 23);
            this.btn_PosicionarTab.TabIndex = 5;
            this.btn_PosicionarTab.Text = "Posicionar na Tab";
            this.btn_PosicionarTab.UseVisualStyleBackColor = true;
            this.btn_PosicionarTab.Click += new System.EventHandler(this.btn_PosicionarTab_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 6);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 0;
            // 
            // frm_TabControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_PosicionarTab);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_RemoverTabAtual);
            this.Controls.Add(this.btn_NovaTab);
            this.Controls.Add(this.txt_NovaTab);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_TabControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TabControl";
            this.Load += new System.EventHandler(this.frm_TabControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_Componentes.ResumeLayout(false);
            this.tab_Componentes.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_Componentes;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txt_NovaTab;
        private System.Windows.Forms.Button btn_NovaTab;
        private System.Windows.Forms.Button btn_RemoverTabAtual;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btn_PosicionarTab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}