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
        // propriedades da classe
        public int num;

        public frm_Principal()
        {
            InitializeComponent();

            // inicializa num
            num = 0;
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
            frm_Veiculos frmveiculos = new frm_Veiculos(txt_ListaVeiculos.Text, this);
            frmveiculos.ShowDialog(); // não permite acesso as janelas anteriores...
            //frmveiculos.Show(); // posso clicar em janelas anteriores...
        }

        private void btn_MostraValorNum_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Valor de num = " + num.ToString());
        }

        private void checkBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_CheckBox via menu
            frm_CheckBox frmCheckBox = new frm_CheckBox();
            frmCheckBox.ShowDialog();
        }

        private void checkedListBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_CheckedListBox via menu
            frm_CheckedListBox frmCheckedListBox = new frm_CheckedListBox();
            frmCheckedListBox.ShowDialog();
        }

        private void comboBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_ComboBox via menu
            frm_ComboBox frmComboBox = new frm_ComboBox();
            frmComboBox.ShowDialog();
        }

        private void dateTimePickerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_DataTimePicker via menu
            frm_DataTimePicker frmDataTimePicker = new frm_DataTimePicker();
            frmDataTimePicker.ShowDialog();
        }

        private void linkLabelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_LinkLabel via menu
            frm_LinkLabel frmLinkLabel = new frm_LinkLabel();
            frmLinkLabel.ShowDialog();
        }

        private void listBoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_ListBox via menu
            frm_ListBox frmListBox = new frm_ListBox();
            frmListBox.ShowDialog();
        }

        private void listViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o formulário frm_ListView via menu
            frm_ListView frmListView = new frm_ListView();
            frmListView.ShowDialog();
        }
    }
}
