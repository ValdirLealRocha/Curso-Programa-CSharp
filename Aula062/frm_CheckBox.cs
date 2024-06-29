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
    public partial class frm_CheckBox : Form
    {
        // declada variaveis
        List<CheckBox> transp = new List<CheckBox>();

        public frm_CheckBox()
        {
            InitializeComponent();

            // add os elementos da tela do checkbox
            transp.Add(cbo_Carro);
            transp.Add(cbo_Aviao);
            transp.Add(cbo_Navio);
            transp.Add(cbo_Onibus);
        }

        private void btn_TransportesMarcados_Click(object sender, EventArgs e)
        {
            // inicializa variáveis
            string txt = "";

            // validação
            // SUBSTITUIR por um looping foreach...
            //if (cbo_Carro.Checked)
            //{
            //    txt += cbo_Carro.Text + ", ";
            //}

            //if (cbo_Aviao.Checked)
            //{
            //    txt += cbo_Aviao.Text + ", ";
            //}

            //if (cbo_Navio.Checked)
            //{
            //    txt += cbo_Navio.Text + ", ";
            //}

            //if (cbo_Onibus.Checked)
            //{
            //    txt += cbo_Onibus.Text + ", ";
            //}

            foreach (CheckBox i in transp)
            {
                if (i.Checked)
                {
                    txt += i.Text + ", ";
                }
            }

            // mostra txt
            MessageBox.Show(txt);
        }

        private void chb_Patinete_CheckedChanged(object sender, EventArgs e)
        {
            // validação
            if (chb_Patinete.Checked)
            {
                // mostra chb_Patinete
                MessageBox.Show("Patinete marcado.");
            }
        }

        private void btn_AbrirFormularioFilho_Click(object sender, EventArgs e)
        {
            // abre formulário filhocheckbox para mostrar relação entre os campos marcados...
            frm_FilhoCheckBox frmFilhoCheckBox = new frm_FilhoCheckBox();
            frmFilhoCheckBox.ShowDialog();
        }
    }
}
