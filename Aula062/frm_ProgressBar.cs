using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Aula062
{
    public partial class frm_ProgressBar : Form
    {
        public frm_ProgressBar()
        {
            InitializeComponent();
        }

        private void btn_DefinirValor_Click(object sender, EventArgs e)
        {
            // definir valor de preenchimento da barra...
            if ((int.Parse(txt_DefinirValor.Text) >= prb_Barra.Minimum) & 
                (int.Parse(txt_DefinirValor.Text) <= prb_Barra.Maximum))
            {
                prb_Barra.Value = int.Parse(txt_DefinirValor.Text);
            }
        }

        private void btn_Preencher_Click(object sender, EventArgs e)
        {
            // zerar a barra de progresso
            prb_Barra.Value = 0;

            // pausa no processamento, tempo de espera...
            for (int i = 1; i <= prb_Barra.Maximum; i++)
            {
                prb_Barra.Value = i;
                Thread.Sleep(20);
            }

            lbl_Porcentagem.Text = "Concuído!";
        }
    }
}
