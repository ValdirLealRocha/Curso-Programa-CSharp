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
    public partial class frm_ListBox : Form
    {
        // propriedades
        List<string> carros = new List<string>();

        public frm_ListBox()
        {
            InitializeComponent();

            // inicializa a lista
            carros.Add("HRV");
            carros.Add("Golf");
            carros.Add("Focus");

            // add a lista ao listbox
            ltb_Carros.DataSource = carros;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            if (txt_Carro.Text == "")
            {
                MessageBox.Show("Digite um carro!");
                txt_Carro.Focus();
            }
            else 
            {
                //carros.Add((string)txt_Carro.Text);
                // adiciona carro na lista
                carros.Add(txt_Carro.Text);
                // limpa o campo
                txt_Carro.Clear();
                // atualiza a lista
                //ltb_Carros.DataSource = null;
                //ltb_Carros.DataSource = carros;
                // utilizando método para evitar código duplicado
                AtualizaLista();
            }
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            // remove o carro selecionado da lista
            carros.RemoveAt(ltb_Carros.SelectedIndex);
            // atualiza a lista
            //ltb_Carros.DataSource = null;
            //ltb_Carros.DataSource = carros;
            // utilizando método para evitar código duplicado
            AtualizaLista();
        }

        private void btn_Obter_Click(object sender, EventArgs e)
        {
            // obtem o item selecionado da lista
            // retorna o indice
            //txt_Carro.Text = ltb_Carros.SelectedIndex.ToString();
            // retorna o carro
            txt_Carro.Text = carros[ltb_Carros.SelectedIndex];
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            // limpa o campo
            txt_Carro.Clear();
            // limpar a lista
            carros.Clear();
            // atualiza a lista
            //ltb_Carros.DataSource = null;
            //ltb_Carros.DataSource = carros;
            // utilizando método para evitar código duplicado
            AtualizaLista();
        }

        private void AtualizaLista()
        {
            // atualiza a lista
            ltb_Carros.DataSource = null;
            ltb_Carros.DataSource = carros;
        }
    }
}
