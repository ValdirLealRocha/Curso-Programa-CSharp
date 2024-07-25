using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace CFB_Academia
{
    public partial class frm_GestaoUsuarios : Form
    {
        public frm_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // carrega o formulário frm_NovoUsuario
            frm_NovoUsuario frmNovoUsuario = new frm_NovoUsuario();
            frmNovoUsuario.ShowDialog();

            // carregar dados do Grid de Usuários
            dgv_Usuarios.DataSource = class_Banco.ObterUsuariosIdNome();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // obtem a linha atual da edição...
            int linha = dgv_Usuarios.SelectedRows[0].Index;

            // cria uma instância do objeto Usuário...
            class_Usuario u = new class_Usuario();

            // define os valores nas propriedades da classe Usuário
            u.P_n_idusuario = Convert.ToInt32(txt_ID.Text);
            u.P_t_nomeusuario = txt_Nome.Text;
            // Este campo deveria ser pesquisado antes de deixar alterar,
            // pra ter certeza de não ter duplicata dele...
            u.P_t_username = txt_UserName.Text; // <<<<<<<
            u.P_t_senhausuario = txt_Senha.Text;
            u.P_t_statususuario = cmb_Status.Text;
            u.P_n_nivelusuario = Convert.ToInt32(Math.Round(txt_Nivel.Value, 0));

            // executa o método
            class_Banco.AtualizarUsuario(u);

            // carregar dados do Grid de Usuários
            // para aliviar a carga do sistema pode ser melhorado atualizando o gri direto...
            //dgv_Usuarios.DataSource = class_Banco.ObterUsuariosIdNome();

            // ATUALIZA o grid direto... Pois So temos o NOME...
            dgv_Usuarios[1, linha].Value = txt_Nome.Text; // melhor....

            // volta para a linha referente a edição dos dados...
            dgv_Usuarios.CurrentCell = dgv_Usuarios[0, linha];
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            // obtem a linha atual da edição...
            int linha = dgv_Usuarios.SelectedRows[0].Index;

            // valida a exclusão do registro no banco de dados...
            if (MessageBox.Show("Deseja Excluir o Usuário: " + dgv_Usuarios[0, linha].Value.ToString() + "-" + dgv_Usuarios[1, linha].Value.ToString(), "*** EXCLUIR USUÁRIO ***", MessageBoxButtons.YesNo) == DialogResult.Yes) 
            {
                // EXCLUI o usuário...  Poderia passar direto o txt_ID.Text
                class_Banco.ExcluirUsuario(dgv_Usuarios[0, linha].Value.ToString());

                // PRIMEIRO - excluir e atualizar a grid
                //dgv_Usuarios.DataSource = class_Banco.ObterUsuariosIdNome();
                // SEGUNDO - excluir a linha no grid
                dgv_Usuarios.Rows.Remove(dgv_Usuarios.CurrentRow); // txt_ID.Text
            }

            // volta para a linha referente a seleção da exclusão dos dados...
            dgv_Usuarios.CurrentCell = dgv_Usuarios[0, linha];
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            // fecha janela
            Close();
        }

        private void frm_GestaoUsuarios_Load(object sender, EventArgs e)
        {
            // carregar dados do Grid de Usuários
            dgv_Usuarios.DataSource = class_Banco.ObterUsuariosIdNome();

            // define tamanho das colunas id e nome
            dgv_Usuarios.Columns[0].Width = 100;
            dgv_Usuarios.Columns[1].Width = 500;
        }

        private void dgv_Usuarios_SelectionChanged(object sender, EventArgs e)
        {
            // cria um objeto do tipo DataGridView vindo do sender...
            DataGridView dgv = (DataGridView)sender;

            // obtem a linha selecionada do GridView e valida...
            int contLinhas = dgv.SelectedRows.Count;
            if (contLinhas > 0)
            {
                // cria uma instância dt do tipo DataTable
                DataTable dt = new DataTable();

                // captura o id
                //dt = class_Banco.ObterDadosUsuario(Int64.Parse(dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString()));
                dt = class_Banco.ObterDadosUsuario(dgv_Usuarios.SelectedRows[0].Cells[0].Value.ToString());

                // inicializa os campos da tela...
                txt_ID.Text = dt.Rows[0].Field<Int64>("n_idusuario").ToString();
                txt_Nome.Text = dt.Rows[0].Field<string>("t_nomeusuario").ToString();
                txt_UserName.Text = dt.Rows[0].Field<string>("t_username").ToString();
                txt_Senha.Text = dt.Rows[0].Field<string>("t_senhausuario").ToString();
                cmb_Status.Text = dt.Rows[0].Field<string>("t_statususuario").ToString();
                txt_Nivel.Value = dt.Rows[0].Field<Int64>("n_nivelusuario");
            }
        }
    }
}
