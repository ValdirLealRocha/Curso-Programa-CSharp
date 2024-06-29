namespace Aula062
{
    partial class frm_Principal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Veiculo = new System.Windows.Forms.TextBox();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.lbl_Veiculo = new System.Windows.Forms.Label();
            this.txt_ListaVeiculos = new System.Windows.Forms.TextBox();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.btn_MostrarVeiculos = new System.Windows.Forms.Button();
            this.btn_MostraValorNum = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.componentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkedListBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateTimePickerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.linkLabelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Veiculo
            // 
            this.txt_Veiculo.Location = new System.Drawing.Point(12, 40);
            this.txt_Veiculo.Name = "txt_Veiculo";
            this.txt_Veiculo.Size = new System.Drawing.Size(170, 20);
            this.txt_Veiculo.TabIndex = 0;
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(188, 40);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(75, 23);
            this.btn_Adicionar.TabIndex = 1;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // lbl_Veiculo
            // 
            this.lbl_Veiculo.AutoSize = true;
            this.lbl_Veiculo.Location = new System.Drawing.Point(12, 24);
            this.lbl_Veiculo.Name = "lbl_Veiculo";
            this.lbl_Veiculo.Size = new System.Drawing.Size(91, 13);
            this.lbl_Veiculo.TabIndex = 2;
            this.lbl_Veiculo.Text = "Digite um Veículo";
            // 
            // txt_ListaVeiculos
            // 
            this.txt_ListaVeiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ListaVeiculos.Location = new System.Drawing.Point(12, 69);
            this.txt_ListaVeiculos.Multiline = true;
            this.txt_ListaVeiculos.Name = "txt_ListaVeiculos";
            this.txt_ListaVeiculos.ReadOnly = true;
            this.txt_ListaVeiculos.Size = new System.Drawing.Size(251, 248);
            this.txt_ListaVeiculos.TabIndex = 3;
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.Location = new System.Drawing.Point(12, 323);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(248, 23);
            this.btn_Limpar.TabIndex = 4;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.UseVisualStyleBackColor = true;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // btn_MostrarVeiculos
            // 
            this.btn_MostrarVeiculos.Location = new System.Drawing.Point(12, 352);
            this.btn_MostrarVeiculos.Name = "btn_MostrarVeiculos";
            this.btn_MostrarVeiculos.Size = new System.Drawing.Size(248, 23);
            this.btn_MostrarVeiculos.TabIndex = 5;
            this.btn_MostrarVeiculos.Text = "Mostrar Veículos";
            this.btn_MostrarVeiculos.UseVisualStyleBackColor = true;
            this.btn_MostrarVeiculos.Click += new System.EventHandler(this.btn_MostrarVeiculos_Click);
            // 
            // btn_MostraValorNum
            // 
            this.btn_MostraValorNum.Location = new System.Drawing.Point(12, 381);
            this.btn_MostraValorNum.Name = "btn_MostraValorNum";
            this.btn_MostraValorNum.Size = new System.Drawing.Size(248, 23);
            this.btn_MostraValorNum.TabIndex = 6;
            this.btn_MostraValorNum.Text = "Mostrar Valor de NUM";
            this.btn_MostraValorNum.UseVisualStyleBackColor = true;
            this.btn_MostraValorNum.Click += new System.EventHandler(this.btn_MostraValorNum_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.componentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(277, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // componentesToolStripMenuItem
            // 
            this.componentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkBoxToolStripMenuItem,
            this.checkedListBoxToolStripMenuItem,
            this.comboBoxToolStripMenuItem,
            this.dateTimePickerToolStripMenuItem,
            this.linkLabelToolStripMenuItem});
            this.componentesToolStripMenuItem.Name = "componentesToolStripMenuItem";
            this.componentesToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.componentesToolStripMenuItem.Text = "Componentes";
            // 
            // checkBoxToolStripMenuItem
            // 
            this.checkBoxToolStripMenuItem.Name = "checkBoxToolStripMenuItem";
            this.checkBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkBoxToolStripMenuItem.Text = "CheckBox";
            this.checkBoxToolStripMenuItem.Click += new System.EventHandler(this.checkBoxToolStripMenuItem_Click);
            // 
            // checkedListBoxToolStripMenuItem
            // 
            this.checkedListBoxToolStripMenuItem.Name = "checkedListBoxToolStripMenuItem";
            this.checkedListBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.checkedListBoxToolStripMenuItem.Text = "CheckedListBox";
            this.checkedListBoxToolStripMenuItem.Click += new System.EventHandler(this.checkedListBoxToolStripMenuItem_Click);
            // 
            // comboBoxToolStripMenuItem
            // 
            this.comboBoxToolStripMenuItem.Name = "comboBoxToolStripMenuItem";
            this.comboBoxToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comboBoxToolStripMenuItem.Text = "ComboBox";
            this.comboBoxToolStripMenuItem.Click += new System.EventHandler(this.comboBoxToolStripMenuItem_Click);
            // 
            // dateTimePickerToolStripMenuItem
            // 
            this.dateTimePickerToolStripMenuItem.Name = "dateTimePickerToolStripMenuItem";
            this.dateTimePickerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dateTimePickerToolStripMenuItem.Text = "DateTimePicker";
            this.dateTimePickerToolStripMenuItem.Click += new System.EventHandler(this.dateTimePickerToolStripMenuItem_Click);
            // 
            // linkLabelToolStripMenuItem
            // 
            this.linkLabelToolStripMenuItem.Name = "linkLabelToolStripMenuItem";
            this.linkLabelToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.linkLabelToolStripMenuItem.Text = "LinkLabel";
            this.linkLabelToolStripMenuItem.Click += new System.EventHandler(this.linkLabelToolStripMenuItem_Click);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 412);
            this.Controls.Add(this.btn_MostraValorNum);
            this.Controls.Add(this.btn_MostrarVeiculos);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.txt_ListaVeiculos);
            this.Controls.Add(this.lbl_Veiculo);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.txt_Veiculo);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal | Aulas 62 até 71 do Curso de C# - CFB Cursos";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Veiculo;
        private System.Windows.Forms.Button btn_Adicionar;
        private System.Windows.Forms.Label lbl_Veiculo;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_MostrarVeiculos;
        private System.Windows.Forms.Button btn_MostraValorNum;
        public System.Windows.Forms.TextBox txt_ListaVeiculos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem componentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkedListBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comboBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dateTimePickerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem linkLabelToolStripMenuItem;
    }
}

