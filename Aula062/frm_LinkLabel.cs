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
    public partial class frm_LinkLabel : Form
    {
        public frm_LinkLabel()
        {
            InitializeComponent();

            // gerar dados para o componente multiplos links
            lkl_MultiplosLinks.Links.Add(0, 6, "www.google.com.br");
            lkl_MultiplosLinks.Links.Add(9, 5, "www.youtube.com/cfbcursos");
            lkl_MultiplosLinks.Links.Add(17, 7, "www.youtube.com");

            // desabilita a posição 2
            lkl_MultiplosLinks.Links[2].Enabled = false;
        }

        private void lkl_Canal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // executa comando externo ao programa
            //System.Diagnostics.Process.Start("https://youtube.com/cfbcursos?nome=" + txt_Nome.Text);
            System.Diagnostics.Process.Start("https://youtube.com/cfbcursos");

            // marcar que foi visitado...
            //lkl_Canal.LinkVisited = true;
            // usando o sender para fazer a mesma coisa da linha anterior...
            // aqui fica genérico e poderia criar um método pra não haver repetiçõers...
            LinkLabel ll = (LinkLabel)sender; // garante o cast
            ll.LinkVisited = true;
        }

        private void lkl_Calculadora_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // executa comando externo ao programa
            System.Diagnostics.Process.Start("calc.exe");

            // marcar que foi visitado...
            //lkl_Calculadora.LinkVisited = true;
            // usando o sender para fazer a mesma coisa da linha anterior...
            // aqui fica genérico e poderia criar um método pra não haver repetiçõers...
            LinkLabel ll = (LinkLabel)sender; // garante o cast
            ll.LinkVisited = true;
        }

        private void lkl_MultiplosLinks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // definir os links para os links adicionados no construtor da classe...
            // executa comando externo ao programa
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());

            // marcar que foi visitado...
            e.Link.Visited = true;
        }
    }
}
