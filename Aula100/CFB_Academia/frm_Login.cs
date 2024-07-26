using CFB_Academia.Properties;
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
    public partial class frm_Login : Form
    {
        // cria um objeto do tipo formulário SQLite
        frm_SQLite frmSQLite;
        DataTable dt = new DataTable();

        public frm_Login(frm_SQLite f_SQLite) // manipula o método construtor...
        {
            InitializeComponent();

            // crio uma instância do frm_SQLite em f... Posso usar tudo do frm_SQLite aqui...
            frmSQLite = f_SQLite;
        }

        private void btn_Logar_Click(object sender, EventArgs e)
        {
            // obtem dados das caixas de texto usuario e senha
            string username = txt_UserName.Text;
            string senha = txt_Senha.Text;

            // valida Nome do Usuário
            if (username == "") 
            {
                MessageBox.Show("Verifique se o Nome do Usuário está preenchido corretamente!");
                txt_UserName.Focus();
                return; // finaliza processamento...
            }

            // valida Senha do Usuário
            if (senha == "")
            {
                MessageBox.Show("Verifique se a Senha está preenchida corretamente!");
                txt_Senha.Focus();
                return; // finaliza processamento...
            }

            // string de sql pra consulta
            string sql = "SELECT * FROM tb_usuarios WHERE t_username = '" + username + "' AND t_senhausuario = '" + username + "'";

            // monta o data table
            dt = class_Banco.DQL_ConsultaGenerica(sql);

            // valida se tem dados
            if (dt.Rows.Count == 1)
            {
                // le o nome do data table e salva na caixa de texto lá do form SQLite...
                frmSQLite.lbl_Acesso.Text = dt.Rows[0].ItemArray[5].ToString();

                // le a senha do data table e salva na caixa de texto lá do form SQLite...
                frmSQLite.lbl_Usuario.Text = dt.Rows[0].Field<string>("t_nomeusuario");

                // le a imagem da tela de recursos e salva na imagem lá do form SQLite...
                frmSQLite.pcb_LedLogado.Image = Properties.Resources.led_verde;

                // definir valores das variáveis gobais
                class_Global.nivel = int.Parse(dt.Rows[0].Field<Int64>("n_nivelusuario").ToString());
                class_Global.logado = true;

                // fecha a janela...
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado!");
                txt_UserName.Focus();
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // fecha a janela de login
            this.Close();
        }
    }
}
