using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula062
{
    public partial class frm_ListView : Form
    {
        public frm_ListView()
        {
            InitializeComponent();
        }

        private void LimparCampos() 
        {
            // limpa campos
            txt_ID.Clear();
            txt_Produto.Clear();
            txt_Qtde.Clear();
            txt_Preco.Clear();

            // posiciona cursor
            txt_ID.Focus();
        }

        private bool VerificaCampos()
        {
            Boolean ret = true;

            // validação dos campos
            if (txt_ID.Text == "")
            {
                MessageBox.Show("Preencher o ID");
                txt_ID.Focus();
                ret = false;
            }
            else if (txt_Produto.Text == "")
            {
                MessageBox.Show("Preencher o PRODUTO");
                txt_Produto.Focus();
                ret = false;
            }
            else if (txt_Qtde.Text == "")
            {
                MessageBox.Show("Preencher a QTDE");
                txt_Qtde.Focus();
                ret = false;
            }
            else if (txt_Preco.Text == "")
            {
                MessageBox.Show("Preencher o PREÇO");
                txt_Preco.Focus();
                ret = false;
            }

            return ret;
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            // validação dos campos
            if (VerificaCampos()) 
            {
                // declarar variáveis
                string[] pr = new string[4];
                // inicializa campos...
                pr[0] = txt_ID.Text;
                pr[1] = txt_Produto.Text;
                pr[2] = txt_Qtde.Text;
                pr[3] = txt_Preco.Text;

                // validar o Item e subitem
                ListViewItem listViewItem = new ListViewItem(pr);
                ltv_Produtos.Items.Add(listViewItem);
                LimparCampos();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            // valida se tem item selecionado
            if (ltv_Produtos.SelectedItems.Count > 0)
            {
                //ltv_Produtos.Items.RemoveAt(ltv_Produtos.SelectedIndices[0]);
                MessageBox.Show(ltv_Produtos.SelectedIndices[0].ToString());
            }
            else
            {
                MessageBox.Show("Selecione um ítem da lista!");
            }
        }

        private void IniciaCampos()
        {
            // obtem valores do item
            txt_ID.Text = ltv_Produtos.SelectedItems[0].SubItems[0].Text;
            txt_Produto.Text = ltv_Produtos.SelectedItems[0].SubItems[1].Text;
            txt_Qtde.Text = ltv_Produtos.SelectedItems[0].SubItems[2].Text;
            txt_Preco.Text = ltv_Produtos.SelectedItems[0].SubItems[3].Text;
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            // valida se tem item selecionado
            if (ltv_Produtos.SelectedItems.Count > 0)
            {
                // obtem valores do item
                IniciaCampos();
            }
            else
            {
                MessageBox.Show("Selecione um ítem da lista!");
            }
        }

        private void ltv_Produtos_SelectedIndexChanged(object sender, EventArgs e)
        {
            // valida se tem item selecionado
            if (ltv_Produtos.SelectedItems.Count > 0)
            {
                // obtem valores do item
                IniciaCampos();
            }
        }
    }
}
