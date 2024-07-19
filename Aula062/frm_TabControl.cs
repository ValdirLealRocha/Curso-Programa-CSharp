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
    public partial class frm_TabControl : Form
    {
        public frm_TabControl()
        {
            InitializeComponent();
        }

        private void btn_NovaTab_Click(object sender, EventArgs e)
        {
            // valida caixa de texto
            if (txt_NovaTab.Text != "")
            {
                // nova tab - CRIANDO NOVO OBJ/INSTANCIA
                TabPage pagina = new TabPage();
                // define propriedades do controle...
                pagina.Text = txt_NovaTab.Text;
                pagina.Name = txt_NovaTab.Text;
                pagina.TabIndex = tabControl1.TabPages.Count;
                // nova tab
                tabControl1.TabPages.Add(pagina);
                // limpa caixa de texto
                txt_NovaTab.Clear();

                // chama o método
                DefineNumeroMaximoPaginasTabControl();
            }
            else
            {
                MessageBox.Show("Informe o Nove da Nova TAB/ABA");
                // muda o cursor para a caixa de texto...
                txt_NovaTab.Focus();
            }
        }

        private void btn_RemoverTabAtual_Click(object sender, EventArgs e)
        {
            // Pergunto se o usuário deseja remover a tab/aba/página atual...
            if (MessageBox.Show("Deseja Remover a Tab/Aba/Página: " + tabControl1.SelectedTab.Text, "REMOVER TAB/ABA/PÁGINA",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // remover a tab atual
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
                // muda o cursor para a caixa de texto...
                txt_NovaTab.Focus();

                // chama o método
                DefineNumeroMaximoPaginasTabControl();
            }
            else
            {
                // muda o cursor para a caixa de texto...
                txt_NovaTab.Focus();
            }
        }

        private void btn_PosicionarTab_Click(object sender, EventArgs e)
        {
            // posicionar as TABs, navega entre as tabs...
            tabControl1.SelectedIndex = Int32.Parse(numericUpDown1.Value.ToString());
        }

        // método Define Número Máximo de Páginas do TabControl...
        private void DefineNumeroMaximoPaginasTabControl()
        {
            // não permite ultrapassar o número de páginas do TabControl
            numericUpDown1.Maximum = tabControl1.TabPages.Count - 1;
        }

        private void frm_TabControl_Load(object sender, EventArgs e)
        {
            // chama o método
            DefineNumeroMaximoPaginasTabControl();
        }
    }
}
