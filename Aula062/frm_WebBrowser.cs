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
    public partial class frm_WebBrowser : Form
    {
        // declaração/definição de variáveis
        // página que será a padrão, podendo gravar em arquivo ou banco de dados...
        string home = null;
        string pesquisa = null;

        public frm_WebBrowser()
        {
            InitializeComponent();
        }

        // método NAVEGAR
        private void Navegar()
        {
            // validação da caixa de texto da url...
            if (txt_Url != null)
            {
                // nevegar...
                webBrowser1.Navigate(txt_Url.Text);
            }
            else
            {
                MessageBox.Show("Informe uma URL para Navegar!");
                txt_Url.Focus();
            }
        }

        private void btn_Navegar_Click(object sender, EventArgs e)
        {
            // chama o método NAVEGAR
            Navegar();
        }

        private void txt_Url_KeyDown(object sender, KeyEventArgs e)
        {
            // valida tecla enter
            if (e.KeyCode == Keys.Enter)
            {
                // chama o método NAVEGAR
                Navegar();
            }
        }

        private void btn_Home_Click(object sender, EventArgs e)
        {
            // valida variável home
            if (home == null)
            {
                // define a página homne
                webBrowser1.GoHome();
            }
            else 
            {
                // nevegar...
                webBrowser1.Navigate(home);
            }
        }

        private void btn_Voltar_Click(object sender, EventArgs e)
        {
            // voltar
            webBrowser1.GoBack();
        }

        // implementa método se existe página pra voltar...
        private void webBrowser1_CanGoBackChanged(object sender, EventArgs e)
        {
            // se pode voltar...
            btn_Voltar.Enabled = webBrowser1.CanGoBack;
        }

        private void btn_Proximo_Click(object sender, EventArgs e)
        {
            // próximo
            webBrowser1.GoForward();
        }

        // implementa método se existe página pra ir para o próximo...
        private void webBrowser1_CanGoForwaordChanged(object sender, EventArgs e)
        {
            // se pode ir para o próximo...
            btn_Proximo.Enabled = webBrowser1.CanGoForward;
        }

        private void btn_Parar_Click(object sender, EventArgs e)
        {
            // para navegação
            webBrowser1.Stop();
        }

        private void btn_Atualizar_Click(object sender, EventArgs e)
        {
            // atualiza página...
            webBrowser1.Refresh();
        }

        private void btn_Pesquisa_Click(object sender, EventArgs e)
        {
            // pesquisar uma página...
            webBrowser1.GoSearch();
        }

        private void btn_definirHome_Click(object sender, EventArgs e)
        {
            // definir página padrão...
            home = txt_Url.Text;
        }
    }
}
