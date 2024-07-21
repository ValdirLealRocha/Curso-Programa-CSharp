using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula062
{
    // 
    public partial class frm_BackgroundWorker : Form
    {
        // variáveis
        int cont = 0;
        int max = 1000;

        public frm_BackgroundWorker()
        {
            InitializeComponent();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            // trabalho em segundo plano...
            for (int i = 0; i < max; i++)
            {
                // contador
                cont++;

                //
                backgroundWorker1.ReportProgress(0);

                // parada de 10 milessegundos...
                Thread.Sleep(10);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            // mostra mensagem de finalização do processo...
            MessageBox.Show("Processamento W1 Finalizado!");
            label1.Text = "";
            label2.Text = "";
            btn_Iniciar.Focus();
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Processando W1
            label1.Text = "Processando W1...";
            label2.Text = cont.ToString();
        }

        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker1.IsBusy)
            {
                // executa o BackgroundWorker
                backgroundWorker1.RunWorkerAsync();
            }
            else
            {
                // mostra mensagem de finalização do processo...
                MessageBox.Show("Aguarde este W1 procesasar...");
            }
        }
    }
}
