using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula062
{
    public partial class frm_MaskedTextBox : Form
    {
        public frm_MaskedTextBox()
        {
            InitializeComponent();
        }

        private void btn_MudarMascaraEntrada_Click(object sender, EventArgs e)
        {
            // declaração de variáveis
            // validação da máscara
            if (chb_SomenteTexto.Checked)
            {
                txt_MudarMascaraEntrada.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            }
            else
            {
                txt_MudarMascaraEntrada.TextMaskFormat = MaskFormat.IncludeLiterals;
            }
            string msg = txt_MudarMascaraEntrada.Text;
            MessageBox.Show(msg);
        }

        private void ckb_VerSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_VerSenha.Checked)
            {
                txt_Senha.PasswordChar = '\0';
            }
            else
            {
                txt_Senha.PasswordChar = '#';
            }
        }
    }
}
