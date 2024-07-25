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
    public partial class frm_GestaoUsuarios : Form
    {
        public frm_GestaoUsuarios()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            //

        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            //

        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //

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
