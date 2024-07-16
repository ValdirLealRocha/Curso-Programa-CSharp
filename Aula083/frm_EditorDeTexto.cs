using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Aula083
{
    public partial class frm_EditorDeTexto : Form
    {
        // propriedades
        // variável para imprimir o exitor de textos...
        StringReader leitura = null;

        public frm_EditorDeTexto()
        {
            InitializeComponent();
        }

        // método novo...
        private void Novo() 
        {
            // implementações: salvar dados...

            // limpa o editor
            rtb_EditorTexto.Clear();
            // seta o cursos no editor
            rtb_EditorTexto.Focus();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // chama o método NOVO
            Novo();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método NOVO
            Novo();
        }

        // método salvar...
        private void Salvar() 
        {
            // validação de erros
            try
            {
                // validação para salvar dados do editor
                if (this.cxd_Salvar.ShowDialog() == DialogResult.OK) 
                {
                    // instancia o objeto para tratar o salvamento...
                    FileStream arquivo = new FileStream(cxd_Salvar.FileName, FileMode.OpenOrCreate, FileAccess.Write);

                    // prepara os dados para gravação
                    StreamWriter stream_Writer = new StreamWriter(arquivo);

                    // descarrega os dados do buffer do arquivo
                    stream_Writer.Flush();

                    // preparra a gravação para o arquivo...
                    stream_Writer.BaseStream.Seek(0, SeekOrigin.Begin);

                    // gravar fisicamente em arquivo...
                    stream_Writer.Write(this.rtb_EditorTexto.Text);

                    // descarrega os dados do buffer do arquivo
                    stream_Writer.Flush();

                    // fecha o objeto na memória
                    stream_Writer.Close();
                }
            }
            catch (Exception ex)
            {
                // mostra o erro
                MessageBox.Show("Erro na gravação: " + ex.Message, "Erro ao Gravar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // chama o método SALVAR
            Salvar();
        }

        private void salvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método SALVAR
            Salvar();
        }

        // método abrir...
        private void Abrir() 
        {
            // título da janela
            this.cxd_Abrir.Title = "Abrir Arquivo";

            // diretório padrão
            cxd_Abrir.InitialDirectory = @"D:\\ProjetosDEV\\Curso-Programa-CSharp\\Aula083\\arquivos";

            // define o tipo de extesão a ser mostrada
            cxd_Abrir.Filter = "(*.TXT)|*.TXT";

            // outra forma de validar a abertura de um arquivo... diferente do método SALVAR...
            DialogResult dr = this.cxd_Abrir.ShowDialog();

            // validação para abrir um arquivo
            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // validação de erros
                try
                {
                    // instancia o objeto para tratar o salvamento...
                    FileStream arquivo = new FileStream(cxd_Abrir.FileName, FileMode.Open, FileAccess.Read);

                    // prepara os dados para carregamento do arquivo
                    StreamReader Stream_Reader = new StreamReader(arquivo);

                    // preparra a leitura do arquivo...
                    Stream_Reader.BaseStream.Seek(0, SeekOrigin.Begin);

                    // limpa o editor de textos
                    this.rtb_EditorTexto.Clear();

                    // carrega o arquivo e carrega lin ha a linha e grava no editor de textos...
                    string linha = Stream_Reader.ReadLine();

                    // looping pra repetir a leitura das linhas do arquivo
                    while (linha != null) 
                    { 
                        // grava mais uma linha com uma quebra...
                        this.rtb_EditorTexto.Text += linha + "\n";

                        // carrega o arquivo e carrega lin ha a linha e grava no editor de textos...
                        linha = Stream_Reader.ReadLine();
                    }

                    // fecha o objeto na memória
                    Stream_Reader.Close();
                }
                catch (Exception ex)
                {
                    // mostra o erro
                    MessageBox.Show("Erro de leitura: " + ex.Message, "Erro ao Ler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Abrir_Click(object sender, EventArgs e)
        {
            // chama o método ABRIR
            Abrir();
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método ABRIR
            Abrir();
        }

        // método copiar...
        private void Copiar() 
        {
            // validação, verifica se tem texto selecionado...
            if (rtb_EditorTexto.SelectionLength > 0) 
            {
                // chama o método Copy do componente
                rtb_EditorTexto.Copy(); // recortar só usar o .cut
            }
        }

        private void btn_Copiar_Click(object sender, EventArgs e)
        {
            // chama o método COPIAR
            Copiar();
        }

        private void copiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método COPIAR
            Copiar();
        }

        // método colar...
        private void Colar()
        {
            // chama o método Paste do componente
            rtb_EditorTexto.Paste();
        }

        private void colarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método COLAR
            Colar();
        }

        private void btn_Colar_Click(object sender, EventArgs e)
        {
            // chama o método COLAR
            Colar();
        }

        // método negrito...
        private void Negrito()
        {
            // declaração/definição de variáveis...
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            // inicialização das variáceis
            nome_da_fonte = rtb_EditorTexto.Font.Name;
            tamanho_da_fonte = rtb_EditorTexto.Font.Size;
            n = rtb_EditorTexto.SelectionFont.Bold;
            i = rtb_EditorTexto.SelectionFont.Italic;
            s = rtb_EditorTexto.SelectionFont.Underline;

            // define sem negrito, sem itálico e sem sublinhado
            rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            // negrito desmarcado...
            if (n == false)
            {
                if (i == true & s == true) // itálico marcado e sublinhado marcado...
                {
                    // aplica negrito ao texto já selecionado e também aplica o itálico e sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true) // itálico desmarcado e sublinhado marcado
                {
                    // aplica negrito ao texto já selecionado e também aplica o sublinhado SEM o itálico...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & s == false) // itálico marcado e sublinhado desmarcado
                {
                    // aplica negrito ao texto já selecionado e também aplica o itálico SEM o sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (i == false & s == false) // itálico desmarcado e sublinhado desmarcado
                {
                    // aplica negrito ao texto já selecionado SEM itálico e SEM sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
            else // validação, se tem texto selecionado - NÃO aplica negrito e valida o itálico e sublinhado...
            {
                if (i == true & s == true) // itálico marcado e sublinhado marcado
                {
                    // NÃO aplica negrito ao texto já selecionado e aplica o itálico e sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & s == true) // itálico desmarcado e sublinhado marcado
                {
                    // NÃO aplica negrito ao texto já selecionado e aplica o sublinhado SEM o itálico...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (i == true & s == false) // itálico marcado e sublinhado desmarcado
                {
                    // NÃO aplica negrito ao texto já selecionado e aplica o itálico SEM o sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }

        private void negritoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método NEGRITO
            Negrito();
        }

        private void btn_Negrito_Click(object sender, EventArgs e)
        {
            // chama o método NEGRITO
            Negrito();
        }

        // método italico...
        private void Italico()
        {
            // declaração/definição de variáveis...
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            // inicialização das variáceis
            nome_da_fonte = rtb_EditorTexto.Font.Name;
            tamanho_da_fonte = rtb_EditorTexto.Font.Size;
            n = rtb_EditorTexto.SelectionFont.Bold;
            i = rtb_EditorTexto.SelectionFont.Italic;
            s = rtb_EditorTexto.SelectionFont.Underline;

            // define sem negrito, sem itálico e sem sublinhado
            rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            // itálico desmarcado...
            if (i == false)
            {
                if (n == true & s == true) // negrito marcado e sublinhado marcado...
                {
                    // aplica itálico ao texto já selecionado e também aplica o negrito e sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == false & s == true) // negrito desmarcado e sublinhado marcado
                {
                    // aplica itálico ao texto já selecionado e também aplica o sublinhado SEM o negrito...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Underline);
                }
                else if (n == true & s == false) // negrito marcado e sublinhado desmarcado
                {
                    // aplica itálico ao texto já selecionado e também aplica o negrito SEM o sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic);
                }
                else if (n == false & s == false) // negrito desmarcado e sublinhado desmarcado
                {
                    // aplica itálico ao texto já selecionado SEM itálico e SEM sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
            else // validação, se tem texto selecionado - NÃO aplica itálico e valida o negrito e sublinhado...
            {
                if (n == true & s == true) // negrito marcado e sublinhado marcado
                {
                    // NÃO aplica itálico ao texto já selecionado e aplica o negrito e sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (n == false & s == true) // negrito desmarcado e sublinhado marcado
                {
                    // NÃO aplica itálico ao texto já selecionado e aplica o sublinhado SEM o negrito...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
                else if (n == true & s == false) // negrito marcado e sublinhado desmarcado
                {
                    // NÃO aplica itálico ao texto já selecionado e aplica o negrito SEM o sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
            }
        }

        private void itálicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método ITALICO
            Italico();
        }

        private void btn_Italico_Click(object sender, EventArgs e)
        {
            // chama o método ITALICO
            Italico();
        }

        // método sublinhado...
        private void Sublinhado()
        {
            // declaração/definição de variáveis...
            string nome_da_fonte = null;
            float tamanho_da_fonte = 0;
            bool n, i, s = false;

            // inicialização das variáceis
            nome_da_fonte = rtb_EditorTexto.Font.Name;
            tamanho_da_fonte = rtb_EditorTexto.Font.Size;
            n = rtb_EditorTexto.SelectionFont.Bold;
            i = rtb_EditorTexto.SelectionFont.Italic;
            s = rtb_EditorTexto.SelectionFont.Underline;

            // define sem negrito, sem itálico e sem sublinhado
            rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Regular);

            // sublinhado desmarcado...
            if (s == false)
            {
                if (i == true & n == true) // itálico marcado e negrito marcado...
                {
                    // aplica sublinhado ao texto já selecionado e também aplica o itálico e negrito...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
                }
                else if (i == false & n == true) // itálico desmarcado e negrito marcado
                {
                    // aplica sublinhado ao texto já selecionado e também aplica o negrito SEM o itálico...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold | FontStyle.Underline);
                }
                else if (i == true & n == false) // itálico marcado e negrito desmarcado
                {
                    // aplica sublinhado ao texto já selecionado e também aplica o itálico SEM o negrito...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline | FontStyle.Italic);
                }
                else if (i == false & n == false) // itálico desmarcado e negrito desmarcado
                {
                    // aplica sublinhado ao texto já selecionado SEM itálico e SEM negrito...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Underline);
                }
            }
            else // validação, se tem texto selecionado - NÃO aplica sublinhado e valida o itálico e negrito...
            {
                if (i == true & n == true) // itálico marcado e negrito marcado
                { 
                    // NÃO aplica sublinhado ao texto já selecionado e aplica o itálico e sublinhado...
                    rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic | FontStyle.Bold);
                }
                else if (i == false & n == true) // itálico desmarcado e negrito marcado
                {
                // NÃO aplica sublinhado ao texto já selecionado e aplica o negrito SEM o itálico...
                rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Bold);
                }
                else if (i == true & n == false) // itálico marcado e negrito desmarcado
                {
                // NÃO aplica sublinhado ao texto já selecionado e aplica o itálico SEM o negrito...
                rtb_EditorTexto.SelectionFont = new Font(nome_da_fonte, tamanho_da_fonte, FontStyle.Italic);
                }
            }
        }

        private void sublinhadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método SUBLINHADO
            Sublinhado();
        }

        private void btn_Sublinhado_Click(object sender, EventArgs e)
        {
            // chama o método SUBLINHADO
            Sublinhado();
        }

        // método alinhamento a esquerda
        private void AlinharEsquerda()
        {
            // alinhar a esquerda
            rtb_EditorTexto.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void esquerdaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR A ESQUERDA
            AlinharEsquerda();
        }

        private void btn_Esquerda_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR A ESQUERDA
            AlinharEsquerda();
        }

        // método alinhamento a direita
        private void AlinharDireita()
        {
            // alinhar a direita
            rtb_EditorTexto.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void direitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR A DIREITA
            AlinharDireita();
        }

        private void btn_Direita_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR A DIREITA
            AlinharDireita();
        }

        // método alinhamento centralizado
        private void AlinharCentro()
        {
            // alinhar ao centro
            rtb_EditorTexto.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void centralizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR AO CENTRO
            AlinharCentro();
        }

        private void btn_Centralizar_Click(object sender, EventArgs e)
        {
            // chama o método ALINHAR AO CENTRO
            AlinharCentro();
        }

        // método imprimir
        private void Imprimir()
        {
            // define o modo de impressão por PrintDocument
            cxd_Imprimir.Document = cxd_PrintDocument;

            // armazena em variável o texto do editor
            string texto = this.rtb_EditorTexto.Text;

            // armazena a cadeia de dados do editor de texto...
            leitura = new StringReader(texto);

            // validação da tela de diálogo de impressão...
            if (cxd_Imprimir.ShowDialog() == DialogResult.OK)
            {
                // configurar o evento PrintPage de cxd_PrintDocument...

                // imprime os dados do editor de texto...
                this.cxd_PrintDocument.Print();
            }
        }

        private void imprimirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chama o método IMPRIMIR
            Imprimir();
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // chama o método IMPRIMIR
            Imprimir();
        }

        private void cxd_PrintDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // definir as configurações para impressão de fato dos dados...

            // declarar/definir variáveis
            float linhasPagina = 0; // linhas por página
            float PosY = 0; // posição da linha impressa
            int cont = 0; // contador
            float margemEsquerda = e.MarginBounds.Left - 50;
            float margemSuperior = e.MarginBounds.Top - 50;
            string linha = null;
            Font fonte = this.rtb_EditorTexto.Font;
            SolidBrush pincel = new SolidBrush(Color.Black);

            // calcular a medida das margens...
            linhasPagina = e.MarginBounds.Right / fonte.GetHeight(e.Graphics);

            // retorna as linhas do editor de textos...
            linha = leitura.ReadLine();

            // validação margemEsquerda
            if (margemEsquerda < 5)
            {
                margemEsquerda = 20;
            }

            // validação margemSuperior
            if (margemSuperior < 5)
            {
                margemSuperior = 20;
            }

            // imprime uma página...
            while (cont  < linhasPagina)
            {
                // defie a posição das linhas impressas...
                PosY = (margemSuperior + (cont * Font.GetHeight(e.Graphics)));

                // desenha a linha a ser impressa...
                e.Graphics.DrawString(linha, fonte, pincel, margemEsquerda, PosY,  new StringFormat());

                // contador...
                //cont++;
                cont += 1;

                // leitura da nova linha 
                linha = leitura.ReadLine();
            }

            // verifica se ainda tem linha na próxima página...
            if (linha != null)
            {
                // habilita nova página para ser impressa...
                e.HasMorePages = true;
            }
            else
            {
                // fim da página para ser impressa...
                e.HasMorePages = false;
            }

            // libera objetos de impressão da memória...
            pincel.Dispose();
        }
    }
}
