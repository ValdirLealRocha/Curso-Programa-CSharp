using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class frm_SQLite : Form
    {
        public frm_SQLite()
        {
            InitializeComponent();

            // chama o formulário frm_Login
            frm_Login frmLogin = new frm_Login(this); // manipula o construtor e passo o form atual frm_SQLite
            frmLogin.ShowDialog();
        }

        private void logOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // abre o fomulário de 
            frm_Login frmLogin = new frm_Login(this);
            frmLogin.ShowDialog();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // define os valores padrão...
            lbl_Acesso.Text = "0";
            lbl_Usuario.Text = "...";
            pcb_LedLogado.Image = Properties.Resources.led_vermelho;
            class_Global.nivel = 0;
            class_Global.logado = false;
        }
    }
}
