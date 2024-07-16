namespace Aula083
{
    partial class frm_EditorDeTexto
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.rtb_EditorTexto = new System.Windows.Forms.RichTextBox();
            this.men_Principal = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprimirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copiarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formatarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itálicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sublinhadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alinhamentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centralizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esquerdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.direitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_BarraBotoes = new System.Windows.Forms.ToolStrip();
            this.btn_Novo = new System.Windows.Forms.ToolStripButton();
            this.btn_Abrir = new System.Windows.Forms.ToolStripButton();
            this.btn_Salvar = new System.Windows.Forms.ToolStripButton();
            this.btn_Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Colar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Negrito = new System.Windows.Forms.ToolStripButton();
            this.btn_Italico = new System.Windows.Forms.ToolStripButton();
            this.btn_Sublinhado = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Esquerda = new System.Windows.Forms.ToolStripButton();
            this.btn_Centralizar = new System.Windows.Forms.ToolStripButton();
            this.btn_Direita = new System.Windows.Forms.ToolStripButton();
            this.cxd_Fonte = new System.Windows.Forms.FontDialog();
            this.cxd_Abrir = new System.Windows.Forms.OpenFileDialog();
            this.cxd_Salvar = new System.Windows.Forms.SaveFileDialog();
            this.cxd_Imprimir = new System.Windows.Forms.PrintDialog();
            this.cxd_PrintDocument = new System.Drawing.Printing.PrintDocument();
            this.men_Principal.SuspendLayout();
            this.btn_BarraBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtb_EditorTexto
            // 
            this.rtb_EditorTexto.Location = new System.Drawing.Point(12, 67);
            this.rtb_EditorTexto.Name = "rtb_EditorTexto";
            this.rtb_EditorTexto.Size = new System.Drawing.Size(741, 362);
            this.rtb_EditorTexto.TabIndex = 0;
            this.rtb_EditorTexto.Text = "";
            // 
            // men_Principal
            // 
            this.men_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.formatarToolStripMenuItem});
            this.men_Principal.Location = new System.Drawing.Point(0, 0);
            this.men_Principal.Name = "men_Principal";
            this.men_Principal.Size = new System.Drawing.Size(765, 24);
            this.men_Principal.TabIndex = 1;
            this.men_Principal.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.abrirToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.imprimirToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            this.novoToolStripMenuItem.Click += new System.EventHandler(this.novoToolStripMenuItem_Click);
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            this.salvarToolStripMenuItem.Click += new System.EventHandler(this.salvarToolStripMenuItem_Click);
            // 
            // imprimirToolStripMenuItem
            // 
            this.imprimirToolStripMenuItem.Name = "imprimirToolStripMenuItem";
            this.imprimirToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.imprimirToolStripMenuItem.Text = "Imprimir";
            this.imprimirToolStripMenuItem.Click += new System.EventHandler(this.imprimirToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(117, 6);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copiarToolStripMenuItem,
            this.colarToolStripMenuItem});
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // copiarToolStripMenuItem
            // 
            this.copiarToolStripMenuItem.Name = "copiarToolStripMenuItem";
            this.copiarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.copiarToolStripMenuItem.Text = "Copiar";
            this.copiarToolStripMenuItem.Click += new System.EventHandler(this.copiarToolStripMenuItem_Click);
            // 
            // colarToolStripMenuItem
            // 
            this.colarToolStripMenuItem.Name = "colarToolStripMenuItem";
            this.colarToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.colarToolStripMenuItem.Text = "Colar";
            this.colarToolStripMenuItem.Click += new System.EventHandler(this.colarToolStripMenuItem_Click);
            // 
            // formatarToolStripMenuItem
            // 
            this.formatarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negritoToolStripMenuItem,
            this.itálicoToolStripMenuItem,
            this.sublinhadoToolStripMenuItem,
            this.alinhamentoToolStripMenuItem});
            this.formatarToolStripMenuItem.Name = "formatarToolStripMenuItem";
            this.formatarToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.formatarToolStripMenuItem.Text = "Formatar";
            // 
            // negritoToolStripMenuItem
            // 
            this.negritoToolStripMenuItem.Name = "negritoToolStripMenuItem";
            this.negritoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.negritoToolStripMenuItem.Text = "Negrito";
            this.negritoToolStripMenuItem.Click += new System.EventHandler(this.negritoToolStripMenuItem_Click);
            // 
            // itálicoToolStripMenuItem
            // 
            this.itálicoToolStripMenuItem.Name = "itálicoToolStripMenuItem";
            this.itálicoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.itálicoToolStripMenuItem.Text = "Itálico";
            this.itálicoToolStripMenuItem.Click += new System.EventHandler(this.itálicoToolStripMenuItem_Click);
            // 
            // sublinhadoToolStripMenuItem
            // 
            this.sublinhadoToolStripMenuItem.Name = "sublinhadoToolStripMenuItem";
            this.sublinhadoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.sublinhadoToolStripMenuItem.Text = "Sublinhado";
            this.sublinhadoToolStripMenuItem.Click += new System.EventHandler(this.sublinhadoToolStripMenuItem_Click);
            // 
            // alinhamentoToolStripMenuItem
            // 
            this.alinhamentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centralizarToolStripMenuItem,
            this.esquerdaToolStripMenuItem,
            this.direitaToolStripMenuItem});
            this.alinhamentoToolStripMenuItem.Name = "alinhamentoToolStripMenuItem";
            this.alinhamentoToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.alinhamentoToolStripMenuItem.Text = "Alinhamento";
            // 
            // centralizarToolStripMenuItem
            // 
            this.centralizarToolStripMenuItem.Name = "centralizarToolStripMenuItem";
            this.centralizarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.centralizarToolStripMenuItem.Text = "Centralizar";
            this.centralizarToolStripMenuItem.Click += new System.EventHandler(this.centralizarToolStripMenuItem_Click);
            // 
            // esquerdaToolStripMenuItem
            // 
            this.esquerdaToolStripMenuItem.Name = "esquerdaToolStripMenuItem";
            this.esquerdaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.esquerdaToolStripMenuItem.Text = "Esquerda";
            this.esquerdaToolStripMenuItem.Click += new System.EventHandler(this.esquerdaToolStripMenuItem_Click);
            // 
            // direitaToolStripMenuItem
            // 
            this.direitaToolStripMenuItem.Name = "direitaToolStripMenuItem";
            this.direitaToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.direitaToolStripMenuItem.Text = "Direita";
            this.direitaToolStripMenuItem.Click += new System.EventHandler(this.direitaToolStripMenuItem_Click);
            // 
            // btn_BarraBotoes
            // 
            this.btn_BarraBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Novo,
            this.btn_Abrir,
            this.btn_Salvar,
            this.btn_Imprimir,
            this.toolStripSeparator1,
            this.btn_Copiar,
            this.btn_Colar,
            this.toolStripSeparator2,
            this.btn_Negrito,
            this.btn_Italico,
            this.btn_Sublinhado,
            this.toolStripSeparator3,
            this.btn_Esquerda,
            this.btn_Centralizar,
            this.btn_Direita});
            this.btn_BarraBotoes.Location = new System.Drawing.Point(0, 24);
            this.btn_BarraBotoes.Name = "btn_BarraBotoes";
            this.btn_BarraBotoes.Size = new System.Drawing.Size(765, 25);
            this.btn_BarraBotoes.TabIndex = 2;
            this.btn_BarraBotoes.Text = "Barra de Botões";
            // 
            // btn_Novo
            // 
            this.btn_Novo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Novo.Image = global::Aula083.Properties.Resources.arquivo_novo;
            this.btn_Novo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(23, 22);
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Abrir.Image = global::Aula083.Properties.Resources.arquivo_abrir;
            this.btn_Abrir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(23, 22);
            this.btn_Abrir.Text = "Abrir";
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // btn_Salvar
            // 
            this.btn_Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Salvar.Image = global::Aula083.Properties.Resources.arquivo_salvar;
            this.btn_Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Salvar.Name = "btn_Salvar";
            this.btn_Salvar.Size = new System.Drawing.Size(23, 22);
            this.btn_Salvar.Text = "Salvar";
            this.btn_Salvar.Click += new System.EventHandler(this.btn_Salvar_Click);
            // 
            // btn_Imprimir
            // 
            this.btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Imprimir.Image = global::Aula083.Properties.Resources.arquivo_imprimir;
            this.btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Imprimir.Name = "btn_Imprimir";
            this.btn_Imprimir.Size = new System.Drawing.Size(23, 22);
            this.btn_Imprimir.Text = "Imprimir";
            this.btn_Imprimir.Click += new System.EventHandler(this.btn_Imprimir_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = global::Aula083.Properties.Resources.texto_copiar;
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(23, 22);
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.Click += new System.EventHandler(this.btn_Copiar_Click);
            // 
            // btn_Colar
            // 
            this.btn_Colar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Colar.Image = global::Aula083.Properties.Resources.texto_colar;
            this.btn_Colar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Colar.Name = "btn_Colar";
            this.btn_Colar.Size = new System.Drawing.Size(23, 22);
            this.btn_Colar.Text = "Colar";
            this.btn_Colar.Click += new System.EventHandler(this.btn_Colar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Negrito
            // 
            this.btn_Negrito.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Negrito.Image = global::Aula083.Properties.Resources.fonte_negrito;
            this.btn_Negrito.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Negrito.Name = "btn_Negrito";
            this.btn_Negrito.Size = new System.Drawing.Size(23, 22);
            this.btn_Negrito.Text = "Negrito";
            this.btn_Negrito.Click += new System.EventHandler(this.btn_Negrito_Click);
            // 
            // btn_Italico
            // 
            this.btn_Italico.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Italico.Image = global::Aula083.Properties.Resources.fonte_italico;
            this.btn_Italico.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Italico.Name = "btn_Italico";
            this.btn_Italico.Size = new System.Drawing.Size(23, 22);
            this.btn_Italico.Text = "Itálico";
            this.btn_Italico.Click += new System.EventHandler(this.btn_Italico_Click);
            // 
            // btn_Sublinhado
            // 
            this.btn_Sublinhado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Sublinhado.Image = global::Aula083.Properties.Resources.fonte_sublinhar;
            this.btn_Sublinhado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sublinhado.Name = "btn_Sublinhado";
            this.btn_Sublinhado.Size = new System.Drawing.Size(23, 22);
            this.btn_Sublinhado.Text = "Sublinhado";
            this.btn_Sublinhado.Click += new System.EventHandler(this.btn_Sublinhado_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btn_Esquerda
            // 
            this.btn_Esquerda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Esquerda.Image = global::Aula083.Properties.Resources.alinhar_esquerda;
            this.btn_Esquerda.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Esquerda.Name = "btn_Esquerda";
            this.btn_Esquerda.Size = new System.Drawing.Size(23, 22);
            this.btn_Esquerda.Text = "Esquerda";
            this.btn_Esquerda.Click += new System.EventHandler(this.btn_Esquerda_Click);
            // 
            // btn_Centralizar
            // 
            this.btn_Centralizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Centralizar.Image = global::Aula083.Properties.Resources.alinhar_centralizar;
            this.btn_Centralizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Centralizar.Name = "btn_Centralizar";
            this.btn_Centralizar.Size = new System.Drawing.Size(23, 22);
            this.btn_Centralizar.Text = "Centraliza";
            this.btn_Centralizar.Click += new System.EventHandler(this.btn_Centralizar_Click);
            // 
            // btn_Direita
            // 
            this.btn_Direita.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Direita.Image = global::Aula083.Properties.Resources.alinhar_direita;
            this.btn_Direita.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Direita.Name = "btn_Direita";
            this.btn_Direita.Size = new System.Drawing.Size(23, 22);
            this.btn_Direita.Text = "Direita";
            this.btn_Direita.Click += new System.EventHandler(this.btn_Direita_Click);
            // 
            // cxd_Abrir
            // 
            this.cxd_Abrir.FileName = "openFileDialog1";
            // 
            // cxd_Salvar
            // 
            this.cxd_Salvar.DefaultExt = "txt";
            this.cxd_Salvar.Filter = "(*.TXT)|*.TXT";
            // 
            // cxd_Imprimir
            // 
            this.cxd_Imprimir.UseEXDialog = true;
            // 
            // cxd_PrintDocument
            // 
            this.cxd_PrintDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.cxd_PrintDocument_PrintPage);
            // 
            // frm_EditorDeTexto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 441);
            this.Controls.Add(this.btn_BarraBotoes);
            this.Controls.Add(this.rtb_EditorTexto);
            this.Controls.Add(this.men_Principal);
            this.MainMenuStrip = this.men_Principal;
            this.MaximizeBox = false;
            this.Name = "frm_EditorDeTexto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Textos - Aula 083 até 089";
            this.men_Principal.ResumeLayout(false);
            this.men_Principal.PerformLayout();
            this.btn_BarraBotoes.ResumeLayout(false);
            this.btn_BarraBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtb_EditorTexto;
        private System.Windows.Forms.MenuStrip men_Principal;
        private System.Windows.Forms.ToolStrip btn_BarraBotoes;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprimirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copiarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formatarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem itálicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sublinhadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alinhamentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centralizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esquerdaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem direitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btn_Novo;
        private System.Windows.Forms.ToolStripButton btn_Abrir;
        private System.Windows.Forms.ToolStripButton btn_Salvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripButton btn_Colar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Negrito;
        private System.Windows.Forms.ToolStripButton btn_Italico;
        private System.Windows.Forms.ToolStripButton btn_Sublinhado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btn_Esquerda;
        private System.Windows.Forms.ToolStripButton btn_Centralizar;
        private System.Windows.Forms.ToolStripButton btn_Direita;
        private System.Windows.Forms.FontDialog cxd_Fonte;
        private System.Windows.Forms.OpenFileDialog cxd_Abrir;
        private System.Windows.Forms.SaveFileDialog cxd_Salvar;
        private System.Windows.Forms.PrintDialog cxd_Imprimir;
        private System.Drawing.Printing.PrintDocument cxd_PrintDocument;
        private System.Windows.Forms.ToolStripButton btn_Imprimir;
    }
}

