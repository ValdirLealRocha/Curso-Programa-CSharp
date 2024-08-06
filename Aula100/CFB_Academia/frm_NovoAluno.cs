using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CFB_Academia
{
    public partial class frm_NovoAluno : Form
    {
        public frm_NovoAluno()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // limpa campos...
            txt_NomeAluno.Clear();
            txt_Telefone.Clear();
            cmb_Status.SelectedIndex = 0;
            txt_Turma.Clear();
            txt_Plano.Clear();

            // ativa campos...
            txt_NomeAluno.Enabled = true;
            txt_Telefone.Enabled = true;
            cmb_Status.Enabled = true;

            btn_Turma.Enabled = true;
            btn_Plano.Enabled = true;
            btn_Salvar.Enabled = true;
            btn_Cancelar.Enabled = true;

            // desativa campos...
            btn_Novo.Enabled = false;

            // campo padrão...
            txt_NomeAluno.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // limpa campos...
            txt_NomeAluno.Clear();
            txt_Telefone.Clear();
            cmb_Status.SelectedIndex = 0;
            txt_Turma.Clear();
            txt_Plano.Clear();

            // ativa campos...
            txt_NomeAluno.Enabled = false;
            txt_Telefone.Enabled = false;
            cmb_Status.Enabled = false;

            btn_Turma.Enabled = false;
            btn_Plano.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Cancelar.Enabled = false;

            // desativa campos...
            btn_Novo.Enabled = true;
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // terá a sql da operação Inserir/Atualizar
            string sSQL = "";

            // INSERT
            sSQL = String.Format(@"
                    INSERT INTO
                        tb_alunos
                        (t_nomealuno,
                         t_telefone,
                         t_status,
                         n_idturma)
                    VALUES
                        ('{0}', '{1}', '{2}', {3})", txt_NomeAluno.Text,
                                                     txt_Telefone.Text,
                                                     cmb_Status.SelectedValue,
                                                     txt_Turma.Tag.ToString());

            // Inserir/Atualiza dados no Banco de Dados...
            class_Banco.DML_CrudGenerico(sSQL);

            // mensagem
            MessageBox.Show("Dados SALVOS com sucesso!", "*** SALVAR ALUNO ***");

            // limpa campos...
            txt_NomeAluno.Clear();
            txt_Telefone.Clear();
            cmb_Status.SelectedIndex = 0;
            txt_Turma.Clear();
            txt_Plano.Clear();

            // ativa campos...
            txt_NomeAluno.Enabled = false;
            txt_Telefone.Enabled = false;
            cmb_Status.Enabled = false;

            btn_Turma.Enabled = false;
            btn_Plano.Enabled = false;
            btn_Salvar.Enabled = false;
            btn_Cancelar.Enabled = false;

            // desativa campos...
            btn_Novo.Enabled = true;
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            // fechar formulário
            Close();
        }

        private void frm_NovoAluno_Load(object sender, EventArgs e)
        {
            // Popular ComboBox Status (A=Ativa, B=Bloqueado, C=Cancelado)
            Dictionary<string,string> s_Status = new Dictionary<string,string>();
            s_Status.Add("A", "Ativa");
            s_Status.Add("B", "Bloqueado");
            s_Status.Add("C", "Cancelado");
            cmb_Status.DataSource = new BindingSource(s_Status,null);
            cmb_Status.DisplayMember = "Value";
            cmb_Status.ValueMember = "Key";
        }
    }
}
