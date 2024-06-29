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
    public partial class frm_DataTimePicker : Form
    {
        public frm_DataTimePicker()
        {
            InitializeComponent();
        }

        private void btn_ObterData_Click(object sender, EventArgs e)
        {
            // extrair do DataTimePicker a data completa, o dia, o mês e o ano
            txt_Data.Text = dtp_Data.Text; // data completa
            txt_Dia.Text = dtp_Data.Value.Day.ToString(); // dia
            txt_Mes.Text = dtp_Data.Value.Month.ToString(); // mês
            txt_Ano.Text = dtp_Data.Value.Year.ToString(); // ano
        }

        private void btn_SetarData_Click(object sender, EventArgs e)
        {
            // setar/atualizar os campos data, dia, mês e ano
            int nDia, nMes, nAno;

            nDia = Int32.Parse(txt_Dia.Text); // dia
            nMes = Int32.Parse(txt_Mes.Text); // mes
            nAno = Int32.Parse(txt_Ano.Text); // ano

            DateTime dt = new DateTime(nAno, nMes, nDia); // monta dta completa

            dtp_Data.Value = dt; // datatimepicker

            txt_Data.Text = dtp_Data.Text; // data completa
        }

        private void btn_DataAtual_Click(object sender, EventArgs e)
        {
            dtp_Data.Value = DateTime.Now; // data atual

            // atualiza campos...
            //
            // aqui poderia chamar o click do botão obter data...
            // aqui poderia criar um método para não precisar repetir código...
            //
            // extrair do DataTimePicker a data completa, o dia, o mês e o ano
            txt_Data.Text = dtp_Data.Text; // data completa
            txt_Dia.Text = dtp_Data.Value.Day.ToString(); // dia
            txt_Mes.Text = dtp_Data.Value.Month.ToString(); // mês
            txt_Ano.Text = dtp_Data.Value.Year.ToString(); // ano

        }
    }
}
