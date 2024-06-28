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
    public partial class frm_Veiculos : Form
    {
        // propriedades
        frm_Principal frm_principal;

        public frm_Veiculos(string sListaVeiculos, frm_Principal frmprincipal)
        {
            InitializeComponent();

            //MessageBox.Show(sListaVeiculos);
            txt_ListaVeiculos.Text = sListaVeiculos;

            // inicializa a pripriedade com o objeto form principal
            frm_principal = frmprincipal;

            // inicializa num e mostra lá no frm_Principal...
            frmprincipal.num = 10;
        }

        private void frm_Veiculos_FormClosed(object sender, FormClosedEventArgs e)
        {
            // inicializa a lista do form principal com a lista do form de veiculos...
            frm_principal.txt_ListaVeiculos.Text = txt_ListaVeiculos.Text;
        }
    }
}
