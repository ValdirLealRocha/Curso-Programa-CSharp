namespace Aula062
{
    partial class frm_ListView
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "0",
            "Mouse",
            "120",
            "19,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "Teclado",
            "85",
            "39,99"}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "2",
            "Monitor",
            "38",
            "500,00"}, -1);
            this.ltv_Produtos = new System.Windows.Forms.ListView();
            this.col_Id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Qtde = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Produto = new System.Windows.Forms.TextBox();
            this.lbl_Produto = new System.Windows.Forms.Label();
            this.txt_Qtde = new System.Windows.Forms.TextBox();
            this.lbl_Qtde = new System.Windows.Forms.Label();
            this.txt_Preco = new System.Windows.Forms.TextBox();
            this.lbl_Preco = new System.Windows.Forms.Label();
            this.btn_Obter = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.btn_Adicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ltv_Produtos
            // 
            this.ltv_Produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Id,
            this.col_Produto,
            this.col_Qtde,
            this.col_preco});
            this.ltv_Produtos.FullRowSelect = true;
            this.ltv_Produtos.HideSelection = false;
            this.ltv_Produtos.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.ltv_Produtos.Location = new System.Drawing.Point(12, 12);
            this.ltv_Produtos.MultiSelect = false;
            this.ltv_Produtos.Name = "ltv_Produtos";
            this.ltv_Produtos.Size = new System.Drawing.Size(511, 200);
            this.ltv_Produtos.TabIndex = 0;
            this.ltv_Produtos.UseCompatibleStateImageBehavior = false;
            this.ltv_Produtos.View = System.Windows.Forms.View.Details;
            this.ltv_Produtos.SelectedIndexChanged += new System.EventHandler(this.ltv_Produtos_SelectedIndexChanged);
            // 
            // col_Id
            // 
            this.col_Id.Text = "ID";
            this.col_Id.Width = 40;
            // 
            // col_Produto
            // 
            this.col_Produto.Text = "Produto";
            this.col_Produto.Width = 250;
            // 
            // col_Qtde
            // 
            this.col_Qtde.Text = "Qtde";
            this.col_Qtde.Width = 80;
            // 
            // col_preco
            // 
            this.col_preco.Text = "Preço";
            this.col_preco.Width = 120;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(12, 233);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(12, 249);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(72, 20);
            this.txt_ID.TabIndex = 2;
            // 
            // txt_Produto
            // 
            this.txt_Produto.Location = new System.Drawing.Point(90, 249);
            this.txt_Produto.Name = "txt_Produto";
            this.txt_Produto.Size = new System.Drawing.Size(271, 20);
            this.txt_Produto.TabIndex = 4;
            // 
            // lbl_Produto
            // 
            this.lbl_Produto.AutoSize = true;
            this.lbl_Produto.Location = new System.Drawing.Point(87, 233);
            this.lbl_Produto.Name = "lbl_Produto";
            this.lbl_Produto.Size = new System.Drawing.Size(44, 13);
            this.lbl_Produto.TabIndex = 3;
            this.lbl_Produto.Text = "Produto";
            // 
            // txt_Qtde
            // 
            this.txt_Qtde.Location = new System.Drawing.Point(367, 249);
            this.txt_Qtde.Name = "txt_Qtde";
            this.txt_Qtde.Size = new System.Drawing.Size(75, 20);
            this.txt_Qtde.TabIndex = 6;
            // 
            // lbl_Qtde
            // 
            this.lbl_Qtde.AutoSize = true;
            this.lbl_Qtde.Location = new System.Drawing.Point(364, 233);
            this.lbl_Qtde.Name = "lbl_Qtde";
            this.lbl_Qtde.Size = new System.Drawing.Size(30, 13);
            this.lbl_Qtde.TabIndex = 5;
            this.lbl_Qtde.Text = "Qtde";
            // 
            // txt_Preco
            // 
            this.txt_Preco.Location = new System.Drawing.Point(448, 249);
            this.txt_Preco.Name = "txt_Preco";
            this.txt_Preco.Size = new System.Drawing.Size(75, 20);
            this.txt_Preco.TabIndex = 8;
            // 
            // lbl_Preco
            // 
            this.lbl_Preco.AutoSize = true;
            this.lbl_Preco.Location = new System.Drawing.Point(445, 233);
            this.lbl_Preco.Name = "lbl_Preco";
            this.lbl_Preco.Size = new System.Drawing.Size(35, 13);
            this.lbl_Preco.TabIndex = 7;
            this.lbl_Preco.Text = "Preco";
            // 
            // btn_Obter
            // 
            this.btn_Obter.Location = new System.Drawing.Point(12, 348);
            this.btn_Obter.Name = "btn_Obter";
            this.btn_Obter.Size = new System.Drawing.Size(173, 23);
            this.btn_Obter.TabIndex = 11;
            this.btn_Obter.Text = "Obter";
            this.btn_Obter.UseVisualStyleBackColor = true;
            this.btn_Obter.Click += new System.EventHandler(this.btn_Obter_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(12, 319);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(173, 23);
            this.btn_Remover.TabIndex = 10;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // btn_Adicionar
            // 
            this.btn_Adicionar.Location = new System.Drawing.Point(12, 290);
            this.btn_Adicionar.Name = "btn_Adicionar";
            this.btn_Adicionar.Size = new System.Drawing.Size(173, 23);
            this.btn_Adicionar.TabIndex = 9;
            this.btn_Adicionar.Text = "Adicionar";
            this.btn_Adicionar.UseVisualStyleBackColor = true;
            this.btn_Adicionar.Click += new System.EventHandler(this.btn_Adicionar_Click);
            // 
            // frm_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.btn_Adicionar);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Obter);
            this.Controls.Add(this.txt_Preco);
            this.Controls.Add(this.lbl_Preco);
            this.Controls.Add(this.txt_Qtde);
            this.Controls.Add(this.lbl_Qtde);
            this.Controls.Add(this.txt_Produto);
            this.Controls.Add(this.lbl_Produto);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.ltv_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ltv_Produtos;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader col_Qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Produto;
        private System.Windows.Forms.Label lbl_Produto;
        private System.Windows.Forms.TextBox txt_Qtde;
        private System.Windows.Forms.Label lbl_Qtde;
        private System.Windows.Forms.TextBox txt_Preco;
        private System.Windows.Forms.Label lbl_Preco;
        private System.Windows.Forms.Button btn_Obter;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.Button btn_Adicionar;
    }
}