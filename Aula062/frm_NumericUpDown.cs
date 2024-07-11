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
    public partial class frm_NumericUpDown : Form
    {
        public frm_NumericUpDown()
        {
            InitializeComponent();
        }

        private void btn_DefinirValor_Click(object sender, EventArgs e)
        {
            // setar novo valor para o componente NumericUpDwon
            if ((Decimal.Parse(txt_Valor.Text) >= numericUpDown1.Minimum) &
                (Decimal.Parse(txt_Valor.Text) <= numericUpDown1.Maximum)) 
            {
                numericUpDown1.Value = Decimal.Parse(txt_Valor.Text);
            }
        }
    }
}
