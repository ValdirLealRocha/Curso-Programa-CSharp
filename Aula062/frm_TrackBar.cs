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
    public partial class frm_TrackBar : Form
    {
        public frm_TrackBar()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            // preenche a caixa de texto com o valor de TrackBar
            txt_Valor.Text = trackBar1.Value.ToString();
            lbl_Valor.Text = trackBar1.Value.ToString();
        }

        private void btn_Definir_Click(object sender, EventArgs e)
        {
            // valida tamanho do TrackBar
            if (int.Parse(txt_Valor.Text) <= trackBar1.Maximum & int.Parse(txt_Valor.Text) >= trackBar1.Minimum)
            {
                // preenche a caixa de texto com o valor de TrackBar
                trackBar1.Value = int.Parse(txt_Valor.Text);
            }
            else 
            {
                // mostra o intervalo configurado no componente TrackBar...
                MessageBox.Show("Configure entre " + trackBar1.Minimum.ToString() + " até " + trackBar1.Maximum.ToString() + "!");
                txt_Valor.Clear();
                txt_Valor.Focus();
            }
        }

        private void frm_TrackBar_Load(object sender, EventArgs e)
        {
            // captura o valor do componente TrackBar | mudar no VALUE do componente para 50...
            txt_Valor.Text = trackBar1.Value.ToString();
        }
    }
}
