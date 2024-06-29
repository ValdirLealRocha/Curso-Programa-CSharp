namespace Aula062
{
    partial class frm_DataTimePicker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtp_Data = new System.Windows.Forms.DateTimePicker();
            this.btn_ObterData = new System.Windows.Forms.Button();
            this.txt_Data = new System.Windows.Forms.TextBox();
            this.txt_Dia = new System.Windows.Forms.TextBox();
            this.txt_Mes = new System.Windows.Forms.TextBox();
            this.txt_Ano = new System.Windows.Forms.TextBox();
            this.btn_SetarData = new System.Windows.Forms.Button();
            this.btn_DataAtual = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtp_Data
            // 
            this.dtp_Data.Location = new System.Drawing.Point(12, 12);
            this.dtp_Data.Name = "dtp_Data";
            this.dtp_Data.Size = new System.Drawing.Size(249, 20);
            this.dtp_Data.TabIndex = 0;
            // 
            // btn_ObterData
            // 
            this.btn_ObterData.Location = new System.Drawing.Point(267, 12);
            this.btn_ObterData.Name = "btn_ObterData";
            this.btn_ObterData.Size = new System.Drawing.Size(284, 23);
            this.btn_ObterData.TabIndex = 1;
            this.btn_ObterData.Text = "Obter Data";
            this.btn_ObterData.UseVisualStyleBackColor = true;
            this.btn_ObterData.Click += new System.EventHandler(this.btn_ObterData_Click);
            // 
            // txt_Data
            // 
            this.txt_Data.Location = new System.Drawing.Point(12, 38);
            this.txt_Data.Name = "txt_Data";
            this.txt_Data.Size = new System.Drawing.Size(249, 20);
            this.txt_Data.TabIndex = 2;
            // 
            // txt_Dia
            // 
            this.txt_Dia.Location = new System.Drawing.Point(12, 70);
            this.txt_Dia.Name = "txt_Dia";
            this.txt_Dia.Size = new System.Drawing.Size(79, 20);
            this.txt_Dia.TabIndex = 3;
            // 
            // txt_Mes
            // 
            this.txt_Mes.Location = new System.Drawing.Point(97, 70);
            this.txt_Mes.Name = "txt_Mes";
            this.txt_Mes.Size = new System.Drawing.Size(79, 20);
            this.txt_Mes.TabIndex = 4;
            // 
            // txt_Ano
            // 
            this.txt_Ano.Location = new System.Drawing.Point(182, 70);
            this.txt_Ano.Name = "txt_Ano";
            this.txt_Ano.Size = new System.Drawing.Size(79, 20);
            this.txt_Ano.TabIndex = 5;
            // 
            // btn_SetarData
            // 
            this.btn_SetarData.Location = new System.Drawing.Point(267, 70);
            this.btn_SetarData.Name = "btn_SetarData";
            this.btn_SetarData.Size = new System.Drawing.Size(284, 23);
            this.btn_SetarData.TabIndex = 9;
            this.btn_SetarData.Text = "Setar Data";
            this.btn_SetarData.UseVisualStyleBackColor = true;
            this.btn_SetarData.Click += new System.EventHandler(this.btn_SetarData_Click);
            // 
            // btn_DataAtual
            // 
            this.btn_DataAtual.Location = new System.Drawing.Point(267, 41);
            this.btn_DataAtual.Name = "btn_DataAtual";
            this.btn_DataAtual.Size = new System.Drawing.Size(284, 23);
            this.btn_DataAtual.TabIndex = 10;
            this.btn_DataAtual.Text = "Data Atual";
            this.btn_DataAtual.UseVisualStyleBackColor = true;
            this.btn_DataAtual.Click += new System.EventHandler(this.btn_DataAtual_Click);
            // 
            // frm_DataTimePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 450);
            this.Controls.Add(this.btn_DataAtual);
            this.Controls.Add(this.btn_SetarData);
            this.Controls.Add(this.txt_Ano);
            this.Controls.Add(this.txt_Mes);
            this.Controls.Add(this.txt_Dia);
            this.Controls.Add(this.txt_Data);
            this.Controls.Add(this.btn_ObterData);
            this.Controls.Add(this.dtp_Data);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_DataTimePicker";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataTimePicker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_Data;
        private System.Windows.Forms.Button btn_ObterData;
        private System.Windows.Forms.TextBox txt_Data;
        private System.Windows.Forms.TextBox txt_Dia;
        private System.Windows.Forms.TextBox txt_Mes;
        private System.Windows.Forms.TextBox txt_Ano;
        private System.Windows.Forms.Button btn_SetarData;
        private System.Windows.Forms.Button btn_DataAtual;
    }
}