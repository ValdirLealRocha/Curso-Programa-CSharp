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
    public partial class frm_NovoUsuario : Form
    {
        public frm_NovoUsuario()
        {
            InitializeComponent();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            // limpa campos da tela...
            txt_Nome.Clear();
            txt_UserName.Clear();
            txt_Senha.Clear();
            cmb_Status.Text = "";
            txt_Nivel.Value = 0;

            // move o cursor
            txt_Nome.Focus();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            // validação dos campos...
            if (ValidaCampos())
            {
                // cria o objeto classUsuario
                class_Usuario classUsuario = new class_Usuario();

                // obtem dados para o objeto usuário
                classUsuario.P_t_nomeusuario = txt_Nome.Text;
                classUsuario.P_t_username = txt_UserName.Text;
                classUsuario.P_t_senhausuario = txt_Senha.Text;
                classUsuario.P_t_statususuario = cmb_Status.Text;
                //classUsuario.P_n_nivelusuario = int.Parse(txt_Nivel.Value.ToString());
                // Primeiro arredonda o value, depois converte pra int32...
                classUsuario.P_n_nivelusuario = Convert.ToInt32(Math.Round(txt_Nivel.Value, 0));

                // chama método pra salvar dados...
                class_Banco.NovoUsuario(classUsuario);
            }
        }

        // VALIDA CAMPOS
        private bool ValidaCampos()
        {
            // valida txt_Nome
            if (txt_Nome.Text == "")
            {
                MessageBox.Show("Informe o NOME do Usuário!");
                txt_Nome.Focus();
                return false;
            }

            // valida txt_UserName
            if (txt_UserName.Text == "")
            {
                MessageBox.Show("Informe o USER NAME do Usuário!");
                txt_UserName.Focus();
                return false;
            }

            // valida txt_Senha
            if (txt_Senha.Text == "")
            {
                MessageBox.Show("Informe a SENHA do Usuário!");
                txt_Senha.Focus();
                return false;
            }

            // campos validados...
            return true;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            // limpa campos da tela...
            txt_Nome.Clear();
            txt_UserName.Clear();
            txt_Senha.Clear();
            cmb_Status.Text = "";
            txt_Nivel.Value = 0;

            // move o cursor
            txt_Nome.Focus();
        }

        private void btn_Fechar_Click(object sender, EventArgs e)
        {
            // fecha a janela...
            Close();
        }
    }
}
