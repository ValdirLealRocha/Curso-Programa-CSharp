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
    }
}
