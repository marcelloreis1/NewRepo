namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnManterProfessor = new System.Windows.Forms.Button();
            this.txtManterProfessor = new System.Windows.Forms.Label();
            this.txtManterSecretario = new System.Windows.Forms.Label();
            this.btnManterSecretario = new System.Windows.Forms.Button();
            this.txtManterAnalista = new System.Windows.Forms.Label();
            this.btnManterAnalista = new System.Windows.Forms.Button();
            this.txtAreaAnalistaRH = new System.Windows.Forms.Label();
            this.txtOla_NomeDeUsuario = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBoxTelaManter = new System.Windows.Forms.GroupBox();
            this.groupBoxTelaManter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManterProfessor
            // 
            this.btnManterProfessor.Location = new System.Drawing.Point(253, 86);
            this.btnManterProfessor.Name = "btnManterProfessor";
            this.btnManterProfessor.Size = new System.Drawing.Size(54, 66);
            this.btnManterProfessor.TabIndex = 0;
            this.btnManterProfessor.Text = "button1";
            this.btnManterProfessor.UseVisualStyleBackColor = true;
            this.btnManterProfessor.Click += new System.EventHandler(this.btnManterProfessor_Click);
            // 
            // txtManterProfessor
            // 
            this.txtManterProfessor.AutoSize = true;
            this.txtManterProfessor.Location = new System.Drawing.Point(238, 167);
            this.txtManterProfessor.Name = "txtManterProfessor";
            this.txtManterProfessor.Size = new System.Drawing.Size(87, 13);
            this.txtManterProfessor.TabIndex = 1;
            this.txtManterProfessor.Text = "Manter Professor";
            // 
            // txtManterSecretario
            // 
            this.txtManterSecretario.AutoSize = true;
            this.txtManterSecretario.Location = new System.Drawing.Point(351, 167);
            this.txtManterSecretario.Name = "txtManterSecretario";
            this.txtManterSecretario.Size = new System.Drawing.Size(91, 13);
            this.txtManterSecretario.TabIndex = 3;
            this.txtManterSecretario.Text = "Manter Secretário";
            // 
            // btnManterSecretario
            // 
            this.btnManterSecretario.Location = new System.Drawing.Point(370, 86);
            this.btnManterSecretario.Name = "btnManterSecretario";
            this.btnManterSecretario.Size = new System.Drawing.Size(54, 66);
            this.btnManterSecretario.TabIndex = 2;
            this.btnManterSecretario.Text = "button2";
            this.btnManterSecretario.UseVisualStyleBackColor = true;
            this.btnManterSecretario.Click += new System.EventHandler(this.btnManterSecretario_Click);
            // 
            // txtManterAnalista
            // 
            this.txtManterAnalista.AutoSize = true;
            this.txtManterAnalista.Location = new System.Drawing.Point(471, 167);
            this.txtManterAnalista.Name = "txtManterAnalista";
            this.txtManterAnalista.Size = new System.Drawing.Size(80, 13);
            this.txtManterAnalista.TabIndex = 5;
            this.txtManterAnalista.Text = "Manter Analista";
            // 
            // btnManterAnalista
            // 
            this.btnManterAnalista.Location = new System.Drawing.Point(484, 86);
            this.btnManterAnalista.Name = "btnManterAnalista";
            this.btnManterAnalista.Size = new System.Drawing.Size(54, 66);
            this.btnManterAnalista.TabIndex = 4;
            this.btnManterAnalista.Text = "button3";
            this.btnManterAnalista.UseVisualStyleBackColor = true;
            this.btnManterAnalista.Click += new System.EventHandler(this.btnManterAnalista_Click);
            // 
            // txtAreaAnalistaRH
            // 
            this.txtAreaAnalistaRH.AutoSize = true;
            this.txtAreaAnalistaRH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAreaAnalistaRH.Location = new System.Drawing.Point(66, 9);
            this.txtAreaAnalistaRH.Name = "txtAreaAnalistaRH";
            this.txtAreaAnalistaRH.Size = new System.Drawing.Size(148, 16);
            this.txtAreaAnalistaRH.TabIndex = 6;
            this.txtAreaAnalistaRH.Text = "Área do Analista de RH";
            // 
            // txtOla_NomeDeUsuario
            // 
            this.txtOla_NomeDeUsuario.AutoSize = true;
            this.txtOla_NomeDeUsuario.Location = new System.Drawing.Point(66, 25);
            this.txtOla_NomeDeUsuario.Name = "txtOla_NomeDeUsuario";
            this.txtOla_NomeDeUsuario.Size = new System.Drawing.Size(113, 13);
            this.txtOla_NomeDeUsuario.TabIndex = 7;
            this.txtOla_NomeDeUsuario.Text = "Olá, (nome de usuário)";
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(712, 16);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(46, 22);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // groupBoxTelaManter
            // 
            this.groupBoxTelaManter.Controls.Add(this.btnManterSecretario);
            this.groupBoxTelaManter.Controls.Add(this.btnManterProfessor);
            this.groupBoxTelaManter.Controls.Add(this.txtManterProfessor);
            this.groupBoxTelaManter.Controls.Add(this.txtManterSecretario);
            this.groupBoxTelaManter.Controls.Add(this.txtManterAnalista);
            this.groupBoxTelaManter.Controls.Add(this.btnManterAnalista);
            this.groupBoxTelaManter.Location = new System.Drawing.Point(-7, 53);
            this.groupBoxTelaManter.Name = "groupBoxTelaManter";
            this.groupBoxTelaManter.Size = new System.Drawing.Size(800, 295);
            this.groupBoxTelaManter.TabIndex = 9;
            this.groupBoxTelaManter.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 410);
            this.Controls.Add(this.groupBoxTelaManter);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtOla_NomeDeUsuario);
            this.Controls.Add(this.txtAreaAnalistaRH);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tela Manter";
            this.groupBoxTelaManter.ResumeLayout(false);
            this.groupBoxTelaManter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnManterProfessor;
        private System.Windows.Forms.Label txtManterProfessor;
        private System.Windows.Forms.Label txtManterSecretario;
        private System.Windows.Forms.Button btnManterSecretario;
        private System.Windows.Forms.Label txtManterAnalista;
        private System.Windows.Forms.Button btnManterAnalista;
        private System.Windows.Forms.Label txtAreaAnalistaRH;
        private System.Windows.Forms.Label txtOla_NomeDeUsuario;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox groupBoxTelaManter;
    }
}

