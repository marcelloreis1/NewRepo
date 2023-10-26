namespace WindowsFormsApp1
{
    partial class Form2
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
            this.btnSair = new System.Windows.Forms.Button();
            this.txtOla_NomeDeUsuario = new System.Windows.Forms.Label();
            this.txtAreaAnalistaRH = new System.Windows.Forms.Label();
            this.lblFiltrarNomes = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.TextBox();
            this.lblIncluir = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxTelaDados = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxTelaDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(711, 26);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 22);
            this.btnSair.TabIndex = 11;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtOla_NomeDeUsuario
            // 
            this.txtOla_NomeDeUsuario.AutoSize = true;
            this.txtOla_NomeDeUsuario.Location = new System.Drawing.Point(96, 31);
            this.txtOla_NomeDeUsuario.Name = "txtOla_NomeDeUsuario";
            this.txtOla_NomeDeUsuario.Size = new System.Drawing.Size(113, 13);
            this.txtOla_NomeDeUsuario.TabIndex = 10;
            this.txtOla_NomeDeUsuario.Text = "Olá, (nome de usuário)";
            // 
            // txtAreaAnalistaRH
            // 
            this.txtAreaAnalistaRH.AutoSize = true;
            this.txtAreaAnalistaRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaAnalistaRH.Location = new System.Drawing.Point(96, 15);
            this.txtAreaAnalistaRH.Name = "txtAreaAnalistaRH";
            this.txtAreaAnalistaRH.Size = new System.Drawing.Size(148, 16);
            this.txtAreaAnalistaRH.TabIndex = 9;
            this.txtAreaAnalistaRH.Text = "Área do Analista de RH";
            // 
            // lblFiltrarNomes
            // 
            this.lblFiltrarNomes.Location = new System.Drawing.Point(69, 47);
            this.lblFiltrarNomes.Name = "lblFiltrarNomes";
            this.lblFiltrarNomes.Size = new System.Drawing.Size(365, 20);
            this.lblFiltrarNomes.TabIndex = 12;
            this.lblFiltrarNomes.Text = "Insira o nome para filtrar:";
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.Location = new System.Drawing.Point(440, 47);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(146, 20);
            this.lblPesquisar.TabIndex = 13;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // lblIncluir
            // 
            this.lblIncluir.Location = new System.Drawing.Point(592, 47);
            this.lblIncluir.Name = "lblIncluir";
            this.lblIncluir.Size = new System.Drawing.Size(85, 20);
            this.lblIncluir.TabIndex = 14;
            this.lblIncluir.Text = "Novo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.RG,
            this.CPF});
            this.dataGridView1.Location = new System.Drawing.Point(69, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(605, 166);
            this.dataGridView1.TabIndex = 20;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            // 
            // RG
            // 
            this.RG.HeaderText = "RG";
            this.RG.Name = "RG";
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.Name = "CPF";
            // 
            // groupBoxTelaDados
            // 
            this.groupBoxTelaDados.Controls.Add(this.dataGridView1);
            this.groupBoxTelaDados.Controls.Add(this.lblFiltrarNomes);
            this.groupBoxTelaDados.Controls.Add(this.lblIncluir);
            this.groupBoxTelaDados.Controls.Add(this.lblPesquisar);
            this.groupBoxTelaDados.Location = new System.Drawing.Point(-3, 61);
            this.groupBoxTelaDados.Name = "groupBoxTelaDados";
            this.groupBoxTelaDados.Size = new System.Drawing.Size(791, 283);
            this.groupBoxTelaDados.TabIndex = 21;
            this.groupBoxTelaDados.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 405);
            this.Controls.Add(this.groupBoxTelaDados);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtOla_NomeDeUsuario);
            this.Controls.Add(this.txtAreaAnalistaRH);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela de Dados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxTelaDados.ResumeLayout(false);
            this.groupBoxTelaDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label txtOla_NomeDeUsuario;
        private System.Windows.Forms.Label txtAreaAnalistaRH;
        private System.Windows.Forms.TextBox lblFiltrarNomes;
        private System.Windows.Forms.TextBox lblPesquisar;
        private System.Windows.Forms.TextBox lblIncluir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn RG;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.GroupBox groupBoxTelaDados;
    }
}