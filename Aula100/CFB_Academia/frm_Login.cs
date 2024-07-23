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
    public partial class frm_Login : Form
    {
        // cria um objeto do tipo formulário SQLite
        frm_SQLite frmSQLite;
        public frm_Login(frm_SQLite f) // manipula o método construtor...
        {
            InitializeComponent();

            // crio uma instância do frm_SQLite em f... Posso usar tudo do frm_SQLite aqui...
            frmSQLite = f;
        }
    }
}
