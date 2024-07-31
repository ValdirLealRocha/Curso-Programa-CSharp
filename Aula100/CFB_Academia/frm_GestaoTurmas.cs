using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Data.Entity.Infrastructure.Design.Executor;

namespace CFB_Academia
{
    public partial class frm_GestaoTurmas : Form
    {
        // Guardar o ID selecionado...
        string idTurmaSelecionada = "";

        // define um modo deoperação
        // 0=Padrão, 1=Edição e 2=Inserção
        int modo = 0;

        public frm_GestaoTurmas()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // limpa campos...
            txt_DescricaoTurma.Clear();
            cmb_Professor.SelectedIndex = -1;
            txt_MaximoAlunos.Value = 0;
            cmb_Status.SelectedIndex = -1;
            cmb_Horario.SelectedIndex = -1;

            // limpa calculo de vagas
            txt_Vagas.Clear();

            // setar modo
            modo = 2;

            // campo padrão...
            txt_DescricaoTurma.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // declara/define variáveis
            // obtem o número da linha no grid...
            int linha = dgv_Turmas.SelectedRows[0].Index;

            // terá a sql da operação Inserir/Atualizar
            string sSQL = "";

            // mensagem
            string sMSG = "";

            // operação
            string sOPERACAO = "";

            // não encontrou alteração nos campos da tela em relação aos campos da grid
            if (modo != 0)
            {
                // ATUALIZAÇÃO
                if (modo == 1)
                {
                    // UPDATE
                    sSQL = String.Format(@"
                    UPDATE 
                        tb_turmas 
                    SET t_descricaoturma = '{0}',
                        n_idprofessor = {1},
                        n_maximoalunos = {2},
                        t_status = '{3}',
                        n_idhorario = {4}
                    WHERE n_idturma = {5}", txt_DescricaoTurma.Text,
                                            cmb_Professor.SelectedValue,
                     Int32.Parse(Math.Round(txt_MaximoAlunos.Value, 0).ToString()),
                                            cmb_Status.SelectedValue,
                                            cmb_Horario.SelectedValue,
                                            idTurmaSelecionada);
                    sMSG = "Dados ATUALIZADOS com sucesso!";
                    sOPERACAO = "*** ATUALIZAR TURMA ***";
                }
                else if (modo == 2) // INSERÇÃO
                {
                    // INSERT
                    sSQL = String.Format(@"
                    INSERT INTO
                        tb_turmas
                        (t_descricaoturma,
                         n_idprofessor,
                         n_maximoalunos,
                         t_status,
                         n_idhorario)
                    VALUES
                        ('{0}', {1}, {2}, '{3}', {4})", txt_DescricaoTurma.Text,
                                                        cmb_Professor.SelectedValue,
                                 Int32.Parse(Math.Round(txt_MaximoAlunos.Value, 0).ToString()),
                                                        cmb_Status.SelectedValue,
                                                        cmb_Horario.SelectedValue);
                    sMSG = "Dados SALVOS com sucesso!";
                    sOPERACAO = "*** SALVAR TURMA ***";
                }
            }

            // Inserir/Atualiza dados no Banco de Dados...
            class_Banco.DML_CrudGenerico(sSQL);

            if (modo == 1) // ATUALIZAÇÃO
            {
                // atualiza a Grid
                dgv_Turmas[1, linha].Value = txt_DescricaoTurma.Text;
                dgv_Turmas[2, linha].Value = cmb_Horario.Text;
            }
            else // INSERÇÃO
            {
                sSQL = @"
                    SELECT
                        tbt.n_idturma AS 'ID',
                        tbt.t_descricaoturma AS 'Turma',
                        tbh.t_descricaohorario AS 'Horário'
                    FROM
                        tb_turmas AS tbt
                    INNER JOIN
                        tb_horarios AS tbh ON tbh.n_idhorario = tbt.n_idhorario
                    ORDER BY
                        n_idturma
                ";
                dgv_Turmas.DataSource = class_Banco.DQL_ConsultaGenerica(sSQL);
            }

            // chama método CalculaVagas...
            txt_Vagas.Text = CalculaVagasPorTurma();

            // campo padrão...
            dgv_Turmas.Focus();

            // mensagem
            MessageBox.Show(sMSG, sOPERACAO);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // valida exclusão
            if (MessageBox.Show("Deseja Excluir a Turma: " + txt_DescricaoTurma.Text + "?","*** EXCLUIR TURMA ***", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // EXCLUI!
                // declara/define variáveis
                string sSQL = String.Format(@"
                    DELETE FROM
                        tb_turmas
                    WHERE
                        n_idturma={0}", idTurmaSelecionada);

                // Excluir dados no Banco de Dados...
                class_Banco.DML_CrudGenerico(sSQL);

                // EXCLUIR a linha do Grid...
                dgv_Turmas.Rows.Remove(dgv_Turmas.CurrentRow);

                // campo padrão...
                dgv_Turmas.Focus();
            }
        }

        private void btn_Imprimir_Click(object sender, EventArgs e)
        {
            // imprimir...

        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            // fechar formulário
            Close();
        }

        private void frm_GestaoTurmas_Load(object sender, EventArgs e)
        {
            // Popular DataGridView dgv_Turmas
            string s_SQL = @"
                SELECT
                    tbt.n_idturma AS 'ID',
                    tbt.t_descricaoturma AS 'Turma',
                    tbh.t_descricaohorario AS 'Horário'
                FROM
                    tb_turmas AS tbt
                INNER JOIN
                    tb_horarios AS tbh ON tbh.n_idhorario = tbt.n_idhorario
                ORDER BY
                    n_idturma
            ";
            dgv_Turmas.DataSource = class_Banco.DQL_ConsultaGenerica(s_SQL);
            dgv_Turmas.Columns[0].Width = 40;
            dgv_Turmas.Columns[1].Width = 190;
            dgv_Turmas.Columns[2].Width = 90;

            // Popular ComboBox Professores
            s_SQL = @"
                SELECT
                    n_idprofessor,
                    t_nomeprofessor
                FROM
                    tb_professores
                ORDER BY
                    t_nomeprofessor
            ";
            cmb_Professor.DataSource = class_Banco.DQL_ConsultaGenerica(s_SQL);
            cmb_Professor.DisplayMember = "t_nomeprofessor";
            cmb_Professor.ValueMember = "n_idprofessor";

            // Popular ComboBox Status (A=Ativa, P=Paralisada, C=Cancelada)
            Dictionary<string,string> s_Status = new Dictionary<string,string>();
            s_Status.Add("A", "Ativa");
            s_Status.Add("P", "Paralisada");
            s_Status.Add("C", "Cancelada");
            cmb_Status.DataSource = new BindingSource(s_Status,null);
            cmb_Status.DisplayMember = "Value";
            cmb_Status.ValueMember = "Key";

            // Popular ComboBox Horários
            s_SQL = @"
                SELECT
                    n_idhorario,
                    t_descricaohorario
                FROM
                    tb_horarios
                ORDER BY
                    t_descricaohorario
            ";
            cmb_Horario.DataSource = class_Banco.DQL_ConsultaGenerica(s_SQL);
            cmb_Horario.DisplayMember = "t_descricaohorario";
            cmb_Horario.ValueMember = "n_idhorario";
        }

        private void dgv_GestaoTurmas_SelectionChanged(object sender, EventArgs e)
        {
            // obter a linha para mostrar na caixa de texto da tela...
            // convert o sender para o tipo de datagridview
            DataGridView dgv = (DataGridView)sender;
            // validar linhas disponiveis de dados...
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                // setar modo
                modo = 0;

                // guarda ID slecionado...
                idTurmaSelecionada = dgv_Turmas.Rows[dgv_Turmas.SelectedRows[0].Index].Cells[0].Value.ToString();

                // define a SQL
                string sSQL = @"
                    SELECT
                        t_descricaoturma,
                        n_idprofessor,
                        n_idhorario,
                        n_maximoalunos,
                        t_status
                    FROM
                        tb_turmas
                    WHERE
                        n_idturma=" + idTurmaSelecionada;

                // cria um objeto dgv
                DataTable dt = class_Banco.DQL_ConsultaGenerica(sSQL);

                // inicializa os campos da tela...
                txt_DescricaoTurma.Text = dt.Rows[0].Field<string>("t_descricaoturma");
                cmb_Professor.SelectedValue = dt.Rows[0].Field<Int64>("n_idprofessor").ToString();
                txt_MaximoAlunos.Value = dt.Rows[0].Field<Int64>("n_maximoalunos");
                cmb_Status.SelectedValue = dt.Rows[0].Field<string>("t_status");
                cmb_Horario.SelectedValue = dt.Rows[0].Field<Int64>("n_idhorario");

                // chama método CalculaVagas...
                txt_Vagas.Text = CalculaVagasPorTurma();
            }
        }

        private string CalculaVagasPorTurma()
        {
            // calcula vagas...
            // define a SQL
            String sSQL = String.Format(@"
                SELECT
                    COUNT(n_idaluno) AS 'VagasAlunosPorTurma'
                FROM
                    tb_alunos
                WHERE
                    t_status='A' and n_idturma={0}", idTurmaSelecionada);

            // processa o DataTable
            DataTable dt = class_Banco.DQL_ConsultaGenerica(sSQL);
            return (Int32.Parse(Math.Round(txt_MaximoAlunos.Value, 0).ToString()) -
                    Int32.Parse(dt.Rows[0].Field<Int64>("VagasAlunosPorTurma").ToString())).ToString();
        }

        private void txt_DescricaoTurma_TextChanged(object sender, EventArgs e)
        {
            // setar modo
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cmb_Professor_SelectedIndexChanged(object sender, EventArgs e)
        {
            // setar modo
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void txt_MaximoAlunos_ValueChanged(object sender, EventArgs e)
        {
            // setar modo
            if (modo == 0)
            {
                modo = 1;
            }
            // chama método CalculaVagas...
            txt_Vagas.Text = CalculaVagasPorTurma();
        }

        private void cmb_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            // setar modo
            if (modo == 0)
            {
                modo = 1;
            }
        }

        private void cmb_Horario_SelectedIndexChanged(object sender, EventArgs e)
        {
            // setar modo
            if (modo == 0)
            {
                modo = 1;
            }
        }
    }
}
