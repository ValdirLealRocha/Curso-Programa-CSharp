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
    public partial class frm_Timer : Form
    {
        // Declaração/Definição de variáveis
        int num = 0;
        int px = 0;
        int py = 0;

        public frm_Timer()
        {
            InitializeComponent();
        }

        private void frm_Timer_Load(object sender, EventArgs e)
        {
            // variável para o timer...
            num = 0;
            px = img_Carro.Location.X; // posição X de largada...
            py = img_Carro.Location.Y; // posição Y de largada...
        }

        // método INICIA TIMER...
        private void IniciaTimer1()
        {
            // inicia o timer
            timer1.Start();

            // valida texto do botão
            if (btn_Iniciar_t1.Text == "Continuar")
            {
                btn_Iniciar_t1.Text = "Iniciar";
            }
        }

        // método PARAR TIMER...
        private void PararTimer1()
        {
            // para o timer
            timer1.Stop();
        }

        private void btn_Iniciar_t1_Click(object sender, EventArgs e)
        {
            // chama método
            IniciaTimer1();
        }

        private void btn_Parar_t1_Click(object sender, EventArgs e)
        {
            // chama método
            PararTimer1();

            //se parar muda texto do botão INICIAR
            btn_Iniciar_t1.Text = "Continuar";

        }

        private void btn_Reiniciar_t1_Click(object sender, EventArgs e)
        {
            // chama método
            PararTimer1();

            // reinicializa num...
            num = 0;

            // processamento dentro do timer...
            label1.Text = num.ToString();

            // chama método
            IniciaTimer1();

            // se reiniciar atualiza texto do botão INICIAR
            btn_Iniciar_t1.Text = "Iniciar";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // incrementador...
            num++;

            // processamento dentro do timer...
            label1.Text = num.ToString();
        }

        private void btn_Ligar_Click(object sender, EventArgs e)
        {
            // liga o carro
            timer_Carro.Start();
            
            // desativa botão ligar...
            btn_Ligar.Enabled = false;

            // ativa botão desligar...
            btn_Desligar.Enabled = true;
        }

        private void btn_Desligar_Click(object sender, EventArgs e)
        {
            // desliga o carro
            timer_Carro.Stop();

            // ativa botão ligar...
            btn_Ligar.Enabled = true;

            // desativa botão desligar...
            btn_Desligar.Enabled = false;
        }

        private void timer_Carro_Tick(object sender, EventArgs e)
        {
            if (px >= 602)
            {
                px = 12; // posição X de largada...
                py = 143; // posição Y de largada...
            }

            // incrementa px
            px += 2; // px++;

            // faz o carro andar...
            img_Carro.Location = new Point(px, py);

            // posição X de largada...
            px = img_Carro.Location.X;
        }
    }
}
