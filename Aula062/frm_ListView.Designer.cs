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
            // frm_ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.ltv_Produtos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_ListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ListView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ltv_Produtos;
        private System.Windows.Forms.ColumnHeader col_Id;
        private System.Windows.Forms.ColumnHeader col_Produto;
        private System.Windows.Forms.ColumnHeader col_Qtde;
        private System.Windows.Forms.ColumnHeader col_preco;
    }
}