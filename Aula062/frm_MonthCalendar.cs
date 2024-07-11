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
    public partial class frm_MonthCalendar : Form
    {
        public frm_MonthCalendar()
        {
            InitializeComponent();
        }

        // método para atualizar campos de data...
        private void MostraDatas()
        {
            // retorna a data inicial e final...
            textBox1.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBox2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBox3.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void btn_PegarData_Click(object sender, EventArgs e)
        {
            // retorna a data completa como string...
            //textBox1.Text = monthCalendar1.SelectionStart.ToString();
            MostraDatas();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            MostraDatas();
        }
    }
}
