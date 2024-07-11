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
    public partial class frm_PictureBox : Form
    {
        public frm_PictureBox()
        {
            InitializeComponent();
        }

        private void frm_PictureBox_Load(object sender, EventArgs e)
        {
            // utilizando os recursos editados no arquivo aula062/properties/Resources.resx
            label1.Text = Properties.Resources.NomeCanal;
            label2.Text = Properties.Resources.EnderecoCanal;
        }

        private void btn_Logo1_Click(object sender, EventArgs e)
        {
            // define logo1
            pcb_Logo.Image = Properties.Resources.eu_valdir_leal_rocha_gestor_de_trafego_iesi;
            pcb_Logo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btn_Logo2_Click(object sender, EventArgs e)
        {
            // define logo2
            pcb_Logo.Image = Properties.Resources.rabisco;
            pcb_Logo.SizeMode = PictureBoxSizeMode.CenterImage;
        }
    }
}
