namespace Jogo_de_Cartas
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
            this.labelCartasPlayer1 = new System.Windows.Forms.Label();
            this.labelCartasPlayer2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalDePontosPlayer1 = new System.Windows.Forms.Label();
            this.labelTotalDePontosPlayer2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonJogar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelQuantidadeDeVitorias = new System.Windows.Forms.Label();
            this.labelQuantidadeDeEmpates = new System.Windows.Forms.Label();
            this.labelQuantidadeDeDerrotas = new System.Windows.Forms.Label();
            this.buttonReiniciar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCartasPlayer1
            // 
            this.labelCartasPlayer1.AutoSize = true;
            this.labelCartasPlayer1.Location = new System.Drawing.Point(169, 101);
            this.labelCartasPlayer1.Name = "labelCartasPlayer1";
            this.labelCartasPlayer1.Size = new System.Drawing.Size(130, 25);
            this.labelCartasPlayer1.TabIndex = 0;
            this.labelCartasPlayer1.Text = "Suas Cartas";
            // 
            // labelCartasPlayer2
            // 
            this.labelCartasPlayer2.AutoSize = true;
            this.labelCartasPlayer2.Location = new System.Drawing.Point(174, 201);
            this.labelCartasPlayer2.Name = "labelCartasPlayer2";
            this.labelCartasPlayer2.Size = new System.Drawing.Size(155, 25);
            this.labelCartasPlayer2.TabIndex = 1;
            this.labelCartasPlayer2.Text = "Cartas do CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "VOCE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(91, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total de Pontos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Total de Pontos:";
            // 
            // labelTotalDePontosPlayer1
            // 
            this.labelTotalDePontosPlayer1.AutoSize = true;
            this.labelTotalDePontosPlayer1.Location = new System.Drawing.Point(267, 139);
            this.labelTotalDePontosPlayer1.Name = "labelTotalDePontosPlayer1";
            this.labelTotalDePontosPlayer1.Size = new System.Drawing.Size(24, 25);
            this.labelTotalDePontosPlayer1.TabIndex = 6;
            this.labelTotalDePontosPlayer1.Text = "0";
            // 
            // labelTotalDePontosPlayer2
            // 
            this.labelTotalDePontosPlayer2.AutoSize = true;
            this.labelTotalDePontosPlayer2.Location = new System.Drawing.Point(272, 241);
            this.labelTotalDePontosPlayer2.Name = "labelTotalDePontosPlayer2";
            this.labelTotalDePontosPlayer2.Size = new System.Drawing.Size(24, 25);
            this.labelTotalDePontosPlayer2.TabIndex = 7;
            this.labelTotalDePontosPlayer2.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(91, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "RESULTADO:";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Location = new System.Drawing.Point(244, 340);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(0, 25);
            this.labelResultado.TabIndex = 9;
            // 
            // buttonJogar
            // 
            this.buttonJogar.Location = new System.Drawing.Point(96, 548);
            this.buttonJogar.Name = "buttonJogar";
            this.buttonJogar.Size = new System.Drawing.Size(164, 57);
            this.buttonJogar.TabIndex = 10;
            this.buttonJogar.Text = "Jogar";
            this.buttonJogar.UseVisualStyleBackColor = true;
            this.buttonJogar.Click += new System.EventHandler(this.buttonJogar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(91, 383);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(237, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Quantidade de Vitorias:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(91, 420);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 25);
            this.label7.TabIndex = 12;
            this.label7.Text = "Quantidade de Empates:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 459);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(247, 25);
            this.label8.TabIndex = 13;
            this.label8.Text = "Quantidade de Derrotas:";
            // 
            // labelQuantidadeDeVitorias
            // 
            this.labelQuantidadeDeVitorias.AutoSize = true;
            this.labelQuantidadeDeVitorias.Location = new System.Drawing.Point(353, 382);
            this.labelQuantidadeDeVitorias.Name = "labelQuantidadeDeVitorias";
            this.labelQuantidadeDeVitorias.Size = new System.Drawing.Size(24, 25);
            this.labelQuantidadeDeVitorias.TabIndex = 14;
            this.labelQuantidadeDeVitorias.Text = "0";
            // 
            // labelQuantidadeDeEmpates
            // 
            this.labelQuantidadeDeEmpates.AutoSize = true;
            this.labelQuantidadeDeEmpates.Location = new System.Drawing.Point(353, 420);
            this.labelQuantidadeDeEmpates.Name = "labelQuantidadeDeEmpates";
            this.labelQuantidadeDeEmpates.Size = new System.Drawing.Size(24, 25);
            this.labelQuantidadeDeEmpates.TabIndex = 15;
            this.labelQuantidadeDeEmpates.Text = "0";
            // 
            // labelQuantidadeDeDerrotas
            // 
            this.labelQuantidadeDeDerrotas.AutoSize = true;
            this.labelQuantidadeDeDerrotas.Location = new System.Drawing.Point(353, 459);
            this.labelQuantidadeDeDerrotas.Name = "labelQuantidadeDeDerrotas";
            this.labelQuantidadeDeDerrotas.Size = new System.Drawing.Size(24, 25);
            this.labelQuantidadeDeDerrotas.TabIndex = 16;
            this.labelQuantidadeDeDerrotas.Text = "0";
            // 
            // buttonReiniciar
            // 
            this.buttonReiniciar.Location = new System.Drawing.Point(358, 548);
            this.buttonReiniciar.Name = "buttonReiniciar";
            this.buttonReiniciar.Size = new System.Drawing.Size(158, 57);
            this.buttonReiniciar.TabIndex = 17;
            this.buttonReiniciar.Text = "Reiniciar";
            this.buttonReiniciar.UseVisualStyleBackColor = true;
            this.buttonReiniciar.Click += new System.EventHandler(this.buttonReiniciar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1663, 830);
            this.Controls.Add(this.buttonReiniciar);
            this.Controls.Add(this.labelQuantidadeDeDerrotas);
            this.Controls.Add(this.labelQuantidadeDeEmpates);
            this.Controls.Add(this.labelQuantidadeDeVitorias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonJogar);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelTotalDePontosPlayer2);
            this.Controls.Add(this.labelTotalDePontosPlayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelCartasPlayer2);
            this.Controls.Add(this.labelCartasPlayer1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCartasPlayer1;
        private System.Windows.Forms.Label labelCartasPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalDePontosPlayer1;
        private System.Windows.Forms.Label labelTotalDePontosPlayer2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonJogar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelQuantidadeDeVitorias;
        private System.Windows.Forms.Label labelQuantidadeDeEmpates;
        private System.Windows.Forms.Label labelQuantidadeDeDerrotas;
        private System.Windows.Forms.Button buttonReiniciar;
    }
}

