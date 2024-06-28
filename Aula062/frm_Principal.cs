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
    public partial class frm_Principal : Form
    {
        public frm_Principal()
        {
            InitializeComponent();
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            if (txt_Veiculo.Text == "")
            {
                MessageBox.Show("Digite um Veículo");
                txt_Veiculo.Focus();
                return;
            }

            // adiciona veicolos na lista
            txt_ListaVeiculos.Text += txt_Veiculo.Text + ", ";

            // limpa campos e posiciona o cursor
            txt_Veiculo.Clear();
            txt_Veiculo.Focus();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            // limpa campos e posiciona o cursor
            txt_ListaVeiculos.Clear();
            txt_Veiculo.Clear();
            txt_Veiculo.Focus();
        }

        private void btn_MostrarVeiculos_Click(object sender, EventArgs e)
        {
            frm_Veiculos frmveiculos = new frm_Veiculos(txt_ListaVeiculos.Text);
            frmveiculos.ShowDialog(); // não permite acesso as janelas anteriores...
            //frmveiculos.Show(); // posso clicar em janelas anteriores...
        }
    }
}
