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
    public partial class frm_GestaoHorario : Form
    {
        public frm_GestaoHorario()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // limpa campos...
            txt_IDHorario.Clear();
            txt_DescricaoHorario.Clear();
            txt_DescricaoHorario.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // declara/define variáveis
            string vquery = "";

            // Inserir / Atualizar
            if (txt_IDHorario.Text == "")
            {
                // INSERT
                vquery = @"
                INSERT INTO 
                    tb_horarios
                    (t_descricaohorario)
                    VALUES
                    ('" + txt_DescricaoHorario.Text + "')";
            }
            else
            {
                // UPDATE
                vquery = @"
                    UPDATE 
                        tb_horarios 
                    SET t_descricaohorario = '" + txt_DescricaoHorario.Text + "' " +
                    "WHERE n_idhorario = " + txt_IDHorario.Text;
            }

            // Inserir dados no Banco de Dados...
            class_Banco.DML_CrudGenerico(vquery);

            // Atualiar Grid...
            // declara/define variáveis
            vquery = @"
                SELECT 
                    n_idhorario AS 'ID Horário', 
                    t_descricaohorario AS 'Desc. Horário'
                FROM
                    tb_horarios
                ORDER BY
                    t_descricaohorario
            ";
            dgv_Horarios.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // valida exclusão
            if (MessageBox.Show("Deseja Excluir o Horário com ID: " + txt_IDHorario.Text + " - Horários: " + txt_DescricaoHorario.Text + "?","EXCLUIR HORÁRIO",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // EXCLUI!
                // declara/define variáveis
                string vquery = @"
                    DELETE FROM
                        tb_horarios
                    WHERE
                        n_idhorario=" + txt_IDHorario.Text;

                // Excluir dados no Banco de Dados...
                class_Banco.DML_CrudGenerico(vquery);

                // Atualiar Grid...
                /*
                // FORÇA LEITURA NO BANCO DE DADOS...
                vquery = @"
                    SELECT 
                        n_idhorario AS 'ID Horário', 
                        t_descricaohorario AS 'Desc. Horário'
                    FROM
                        tb_horarios
                    ORDER BY
                        t_descricaohorario
                ";
                dgv_Horarios.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
                */

                // EXCLUIR a linha do Grid...
                dgv_Horarios.Rows.Remove(dgv_Horarios.CurrentRow);
                //txt_IDHorario.Clear();
                //txt_DescricaoHorario.Clear();
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
                    n_idhorario AS 'ID Horário', 
                    t_descricaohorario AS 'Desc. Horário'
                FROM
                    tb_horarios
                ORDER BY
                    t_descricaohorario
            ";
            dgv_Horarios.DataSource = class_Banco.DQL_ConsultaGenerica(vquery);
            dgv_Horarios.Columns[0].Width = 70;
            dgv_Horarios.Columns[1].Width = 400;
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
                string vid = dgv_Horarios.SelectedRows[0].Cells[0].Value.ToString();
                //txt_DescricaoHorario.Text = dgv_Horarios.SelectedRows[0].Cells[1].Value.ToString();
                // define a SQL
                string vquery = @"
                    SELECT
                        *
                    FROM
                        tb_horarios
                    WHERE
                        n_idhorario=" + vid;
                // chama método pra executar a SQL
                dt = class_Banco.DQL_ConsultaGenerica(vquery);
                // obtem o id horário
                txt_IDHorario.Text = dt.Rows[0].Field<Int64>("n_idhorario").ToString();
                // obtem a descrição do horário
                txt_DescricaoHorario.Text = dt.Rows[0].Field<string>("t_descricaohorario");

            }

        }
    }
}
