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
    public partial class frm_ComboBox : Form
    {
        public frm_ComboBox()
        {
            InitializeComponent();
        }

        private void btn_MostrarSelecionados_Click(object sender, EventArgs e)
        {
            // mostrar os itens selecionados
            MessageBox.Show(cmb_Transportes.Text);
        }

        private void btn_LimparElementos_Click(object sender, EventArgs e)
        {
            // limpar elementos
            cmb_Transportes.Items.Clear();
            cmb_Transportes.Text = null;
        }

        private void btn_ResetarElementos_Click(object sender, EventArgs e)
        {
            // limpar elementos
            cmb_Transportes.Items.Clear();
            cmb_Transportes.Text = null;

            // resetar elementos
            cmb_Transportes.Items.Add("Carro");
            cmb_Transportes.Items.Add("Avião");
            cmb_Transportes.Items.Add("Navio");
            cmb_Transportes.Items.Add("Ônibus");
            cmb_Transportes.Items.Add("Trem");
        }

        private void cmb_Transportes_SelectedIndexChanged(object sender, EventArgs e)
        {
            // inicializa o txt_Transporte
            txt_Transporte.Text = cmb_Transportes.Text;
            txt_Transporte.Focus();
        }

        private void btn_AdicionarNovoTransporte_Click(object sender, EventArgs e)
        {
            // valida
            if (cmb_Transportes.Text != "") 
            {
                // verifica se existe o elemento
                if (cmb_Transportes.FindString(txt_Transporte.Text) < 0)
                {
                    cmb_Transportes.Items.Add(txt_Transporte.Text);
                    cmb_Transportes.Text = txt_Transporte.Text;
                }
                else 
                {
                    MessageBox.Show("O elemento " + txt_Transporte.Text.ToString() + " já existe");
                }
            }
        }
    }
}
