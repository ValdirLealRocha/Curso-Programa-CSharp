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
    public partial class frm_TreeView : Form
    {
        public frm_TreeView()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // captura o nó selecionado...
            textBox1.Text = treeView1.SelectedNode.Text;
            if (treeView1.SelectedNode.Tag != null)
            {
                textBox2.Text = treeView1.SelectedNode.Tag.ToString();
            }
            else
            {
                textBox2.Clear();
            }
        }

        private void btn_Adicionar_Click(object sender, EventArgs e)
        {
            // adiciona Nó RAIZ na árvore
            TreeNode raizEstados = treeView1.Nodes.Add("Estados");
            raizEstados.Name = "raizestados";

            TreeNode raizCores = treeView1.Nodes.Add("Cores");
            raizCores.Name = "raizcores";

            // adiciona Nó FILHO aos nós RAIZ na árvore
            TreeNode estado1 = raizEstados.Nodes.Add("Minas Gerais");
            estado1.Name = "minasgerais";
            TreeNode estado2 = raizEstados.Nodes.Add("Paraná");
            estado2.Name = "parana";
            TreeNode estado3 = raizEstados.Nodes.Add("Santa Catarina");
            estado3.Name = "santacatarina";

            TreeNode cor1 = raizCores.Nodes.Add("Azul");
            cor1.Name = "azul";
            TreeNode cor2 = raizCores.Nodes.Add("Branco");
            cor2.Name = "branco";
            TreeNode cor3 = raizCores.Nodes.Add("Rosa");
            cor3.Name = "rosa";
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            try
            {
                // remove um nó informado via programação...
                //treeView1.Nodes.Remove(treeView1.Nodes["raizEstados"]);

                // verifica se tem nó selecionado...
                if (treeView1.SelectedNode != null)
                {
                    // Caso tenha seleção remove o selecionado...
                    // remove um nó se não houver selecionado...
                    treeView1.SelectedNode.Remove();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao remover o nó!");
            }
        }
    }
}
