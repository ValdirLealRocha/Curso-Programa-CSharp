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
    public partial class frm_FilhoCheckBox : Form
    {
        // propriedades
        public frm_CheckBox frmCheckBox;
        public frm_FilhoCheckBox()
        {
            InitializeComponent();

            // valida se o form frm_CheckBox está aberto... "Se foi criado"
            //if (Application.OpenForms["frm_CheckBox"].Created)
            // melhor sempre tratar um erro de modo mais efetivo...
            try
            {
                // inicializa com um formulario aberto "frm_CheckBox"
                // de uma coleção gerado com o OpenForms
                frmCheckBox = Application.OpenForms["frm_CheckBox"] as frm_CheckBox;

                // busca os valores dos componentes do frm_CheckBox setados como public...
                cbo_Carro.Checked = frmCheckBox.cbo_Carro.Checked;
                cbo_Aviao.Checked = frmCheckBox.cbo_Aviao.Checked;
                cbo_Navio.Checked = frmCheckBox.cbo_Navio.Checked;
                cbo_Onibus.Checked = frmCheckBox.cbo_Onibus.Checked;
            }
            catch
            {
                MessageBox.Show("Erro ao abrir formulário!");
            }
        }

        private void cbo_Carro_CheckedChanged(object sender, EventArgs e)
        {
            // atualiza os valores dos componentes lá no frm_CheckBox setados como public...
            // se for o caso fazer as validações pertinentes...
            frmCheckBox.cbo_Carro.Checked = cbo_Carro.Checked;
        }

        private void cbo_Aviao_CheckedChanged(object sender, EventArgs e)
        {
            // atualiza os valores dos componentes lá no frm_CheckBox setados como public...
            // se for o caso fazer as validações pertinentes...
            frmCheckBox.cbo_Aviao.Checked = cbo_Aviao.Checked;
        }

        private void cbo_Navio_CheckedChanged(object sender, EventArgs e)
        {
            // atualiza os valores dos componentes lá no frm_CheckBox setados como public...
            // se for o caso fazer as validações pertinentes...
            frmCheckBox.cbo_Navio.Checked = cbo_Navio.Checked;
        }

        private void cbo_Onibus_CheckedChanged(object sender, EventArgs e)
        {
            // atualiza os valores dos componentes lá no frm_CheckBox setados como public...
            // se for o caso fazer as validações pertinentes...
            frmCheckBox.cbo_Onibus.Checked = cbo_Onibus.Checked;
        }
    }
}
