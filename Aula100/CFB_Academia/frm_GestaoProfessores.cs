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
    public partial class frm_GestaoProfessores : Form
    {
        public frm_GestaoProfessores()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // limpa campos...
            txt_IDProfessor.Clear();
            txt_NomeProfessor.Clear();
            txt_NomeProfessor.Focus();
            txt_Telefone.Clear();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // declara/define variáveis
            string vquery = "";

            // Inserir / Atualizar
            if (txt_IDProfessor.Text == "")
            {
                // INSERT
                vquery = @"
                INSERT INTO 
                    tb_professores
                    (t_nomeprofessor, t_telefone)
                    VALUES
                    ('" + txt_NomeProfessor.Text + "', '" + txt_Telefone.Text + "')";
            }
            else
            {
                // UPDATE
                vquery = @"
                    UPDATE 
                        tb_professores 
                    SET t_nomeprofessor = '" + txt_NomeProfessor.Text + "', " +
                       "t_telefone = '" + txt_Telefone.Text + "' " +
                    "WHERE n_idprofessor = " + txt_IDProfessor.Text;
            }

            // Inserir dados no Banco de Dados...
            class_Banco.DML_CrudGenerico(vquery);

            // Atualiar Grid...
            // declara/define variáveis
            vquery = @"
                SELECT 
                    n_idprofessor AS 'ID Professor', 
                    t_nomeprofessor AS 'Nome Professor',
                    t_telefone AS 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    t_nomeprofessor
            ";
            dgv_Professor.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // valida exclusão
            if (MessageBox.Show("Deseja Excluir o Professor com ID: " + txt_IDProfessor.Text + " - Nome: " + txt_NomeProfessor.Text + "?","EXCLUIR PROFESSOR", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // EXCLUI!
                // declara/define variáveis
                string vquery = @"
                    DELETE FROM
                        tb_professores
                    WHERE
                        n_idprofessor=" + txt_IDProfessor.Text;

                // Excluir dados no Banco de Dados...
                class_Banco.DML_CrudGenerico(vquery);

                // Atualiar Grid...
                /*
                // FORÇA LEITURA NO BANCO DE DADOS...
                vquery = @"
                    SELECT 
                    n_idprofessor AS 'ID Professor', 
                    t_nomeprofessor AS 'Nome Professor',
                    t_telefone AS 'Telefone'
                    FROM
                        tb_professores
                    ORDER BY
                        t_nomeprofessor
                ";
                dgv_Horarios.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
                */

                // EXCLUIR a linha do Grid...
                dgv_Professor.Rows.Remove(dgv_Professor.CurrentRow);
                //txt_IDProfessor.Clear();
                //txt_NomeProfessor.Clear();
                //txt_Telefone.Clear();
            }
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            // fechar formulário
            Close();
        }

        private void frm_Horario_Load(object sender, EventArgs e)
        {
            // declara/define variáveis
            string vquery = @"
                SELECT 
                    n_idprofessor AS 'ID Professor', 
                    t_nomeprofessor AS 'Nome Professor',
                    t_telefone AS 'Telefone'
                FROM
                    tb_professores
                ORDER BY
                    t_nomeprofessor
            ";
            dgv_Professor.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
            dgv_Professor.Columns[0].Width = 60;
            dgv_Professor.Columns[1].Width = 300;
            dgv_Professor.Columns[2].Width = 110;
        }

        private void dgv_Horarios_SelectionChanged(object sender, EventArgs e)
        {
            // obter a linha para mostrar na caixa de texto da tela...
            // convert o sender para o tipo de datagridview
            DataGridView dgv = (DataGridView)sender;
            // validar linhas disponiveis de dados...
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                // cria um objeto dgv
                DataTable dt = new DataTable();
                // obtem o id do grid
                string vid = dgv_Professor.SelectedRows[0].Cells[0].Value.ToString();
                //txt_NomeProfessor.Text = dgv_Horarios.SelectedRows[0].Cells[1].Value.ToString();
                // define a SQL
                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_professores
                    WHERE
                        n_idprofessor=" + vid;
                // chama método pra executar a SQL
                dt = class_Banco.DQL_ConsultaGenerica(vquery);
                // obtem o id horário
                txt_IDProfessor.Text = dt.Rows[0].Field<Int64>("n_idprofessor").ToString();
                // obtem o nome do professor
                txt_NomeProfessor.Text = dt.Rows[0].Field<string>("t_nomeprofessor");
                // obtem o telefone
                txt_Telefone.Text = dt.Rows[0].Field<string>("t_telefone");
            }

        }
    }
}
