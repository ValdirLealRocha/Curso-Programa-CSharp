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
    public partial class frm_RadioButton : Form
    {
        public frm_RadioButton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // cria variável
            string txt = "";

            // pegar um radiobutton selecionado em um grupo
            // e obter o texto deste item selecionado...
            txt = groupBox1.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text;

            // mostra texto obtido...
            textBox1.Text = txt;
            //MessageBox.Show(txt);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // pegar um radiobutton selecionado em um grupo
            // e obter o texto deste item selecionado...
            // com um laço...
            foreach (RadioButton rb in groupBox2.Controls)
            {
                // percorre os radionbutton e verifica se está marcado...
                if (rb.Checked)
                {
                    textBox2.Text = rb.Text;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // validar cada radiobutton e retornar o text se estiver marcado...
            if (radioButton12.Checked)
            {
                textBox3.Text = radioButton12.Text;
            }
            else if (radioButton11.Checked)
            {
                textBox3.Text = radioButton11.Text;
            }
            if (radioButton10.Checked)
            {
                textBox3.Text = radioButton10.Text;
            }
            if (radioButton9.Checked)
            {
                textBox3.Text = radioButton9.Text;
            }
        }
    }
}
