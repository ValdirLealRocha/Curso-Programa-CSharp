using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Aula062
{
    public partial class frm_CheckedListBox : Form
    {
        public frm_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_Selecionados_Click(object sender, EventArgs e)
        {
            // declaração e inicialização de variáveis
            string txt = "";

            // mostrar itens selecionados...
            //txt = clb_Transportes.Items[0].ToString(); // mostra item da coleção na posição 0
            //txt = clb_Transportes.CheckedItems[0].ToString(); // mostra coleção dos marcados, na posição 0
            foreach (string t in clb_Transportes.CheckedItems) 
            {
                txt += t + ", ";
            }

            MessageBox.Show(txt);
        }

        private void btn_LimparLista_Click(object sender, EventArgs e)
        {
            // limpar a lista
            clb_Transportes.Items.Clear();
        }

        private void btn_ResetarLista_Click(object sender, EventArgs e)
        {
            // limpar a lista
            clb_Transportes.Items.Clear();

            // Resetar a lista, refaz a lista... Poderia somente desmarcar os irens também...
            // desativei o bloco abaixo, para mostrar outra forma de adicionar os itens
            //clb_Transportes.Items.Add("Carro", false);
            //clb_Transportes.Items.Add("Avião", false);
            //clb_Transportes.Items.Add("Navio", false);
            //clb_Transportes.Items.Add("Ônibus", false);
            //clb_Transportes.Items.Add("Trem", false);

            // adicionar através da lista numa coleção...
            List<string> lista = new List<string>();
            lista.Add("Carro");
            lista.Add("Avião");
            lista.Add("Navio");
            lista.Add("Ônibus");
            lista.Add("Trem");

            // adiciona a lista e converte pra array...
            clb_Transportes.Items.AddRange(lista.ToArray());
        }

        private void btn_AdicionaNovoTransporte_Click(object sender, EventArgs e)
        {
            // Adiciona um item na lista...
            //if (txt_NovoTransporte.Text.Equals(null))
            if (txt_NovoTransporte.Text != "")
            {
                clb_Transportes.Items.Add(txt_NovoTransporte.Text);
                txt_NovoTransporte.Clear();
            }
            else
            {
                MessageBox.Show("Informe uma meio de transporte!");
            }

            txt_NovoTransporte.Focus();
        }
    }
}
