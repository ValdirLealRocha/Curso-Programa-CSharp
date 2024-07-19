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
    public partial class frm_ToolStripContainer : Form
    {
        public frm_ToolStripContainer()
        {
            InitializeComponent();
        }

        private void frm_ToolStripContainer_Load(object sender, EventArgs e)
        {
            // criar coleção de ToolStrip
            List<ToolStrip> bf = new List<ToolStrip>();

            // número de elementos tem no Painel de Ferramentas...
            int num_top = toolStripContainer1.TopToolStripPanel.Controls.Count;
            int num_bot = toolStripContainer1.BottomToolStripPanel.Controls.Count;
            int num_lef = toolStripContainer1.LeftToolStripPanel.Controls.Count;
            int num_rig = toolStripContainer1.RightToolStripPanel.Controls.Count;

            // 
            for (int i =0; i < num_top; i++)
            {
                // define o nome
                checkedListBox1.Items.Add(toolStripContainer1.TopToolStripPanel.Controls[i].Name);
                //toolStripContainer1.TopToolStripPanel.Controls[i].Visible = false;
                // define se ligado ou desligado...
                checkedListBox1.SetItemChecked(i, true);
            }
        }
    }
}
