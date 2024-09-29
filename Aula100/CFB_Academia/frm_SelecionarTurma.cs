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
    public partial class frm_SelecionarTurma : Form
    {
        // cria objeto...
        frm_NovoAluno formNovoAluno;

        public frm_SelecionarTurma(frm_NovoAluno objfrmNovoAluno)
        {
            InitializeComponent();

            // instância do Form Novo Aluno
            formNovoAluno = objfrmNovoAluno;
        }

        private void frm_SelecionarTurma_Load(object sender, EventArgs e)
        {
            // terá a sql da operação Inserir
            string sSQL = "";

            // INSERT
            sSQL = String.Format(@"
                    SELECT
                        tbt.n_idturma AS 'ID',
                        tbt.t_descricaoturma AS 'Turma',
                        tbh.t_descricaohorario AS 'Horário',
                        tbp.t_nomeprofessor AS 'Professor',
                        tbt.n_maximoalunos AS 'Máx. Alunos',

                        (   SELECT
                                count(n_idaluno)
                            FROM
                                tb_alunos AS tda
                            WHERE
                                tda.n_idturma = tbt.n_idturma AND tbt.t_status = 'A'
                        ) AS 'Qtde. Alunos'
                    FROM
                        tb_turmas AS tbt
                    INNER JOIN
                        tb_professores AS tbp ON tbp.n_idprofessor = tbt.n_idprofessor
                    INNER JOIN
                        tb_horarios AS tbh ON tbh.n_idhorario = tbt.n_idhorario
             ");

            // Inserir/Atualiza DataGrid...
            dgv_Turmas.DataSource = class_Banco.DQL_ConsultaGenerica(sSQL);
        }

        private void dgv_Turmas_DoubleClick(object sender, EventArgs e)
        {
            // converte e sender genérico para o tipo DataGridView
            DataGridView dgv = (DataGridView)sender;

            // inicia variáveis
            int maxAlunos = 0;
            int qtdeAluno = 0;
            
            maxAlunos = Int32.Parse(dgv.SelectedRows[0].Cells[4].Value.ToString());
            qtdeAluno = Int32.Parse(dgv.SelectedRows[0].Cells[5].Value.ToString());

            // Validação de qtde de alunos
            if (qtdeAluno >= maxAlunos)
            {
                // não pode adicionar mais alunos...
                MessageBox.Show("Não há Vagas nesta Turma!");
            }
            else 
            {
                // Adiciona alunos...
                formNovoAluno.txt_Turma.Text = dgv.Rows[dgv.SelectedRows[0].Index].Cells[1].Value.ToString();
                // salvar na TAG da turma o ID da turma
                formNovoAluno.txt_Turma.Tag = dgv.Rows[dgv.SelectedRows[0].Index].Cells[0].Value.ToString();
                Close();
            }
        }
    }
}
