namespace PI_Cartagena_Jogo
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
            this.btnVerPartidas = new System.Windows.Forms.Button();
            this.lstListaPartidas = new System.Windows.Forms.ListBox();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.txtSenhaPartida = new System.Windows.Forms.TextBox();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblSenhaPE = new System.Windows.Forms.Label();
            this.txtSenhaPE = new System.Windows.Forms.TextBox();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblPartidaInformacao = new System.Windows.Forms.Label();
            this.panelCartas = new System.Windows.Forms.Panel();
            this.picCarta6 = new System.Windows.Forms.PictureBox();
            this.picCarta5 = new System.Windows.Forms.PictureBox();
            this.picCarta4 = new System.Windows.Forms.PictureBox();
            this.picCarta3 = new System.Windows.Forms.PictureBox();
            this.picCarta2 = new System.Windows.Forms.PictureBox();
            this.picCarta1 = new System.Windows.Forms.PictureBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.btnExibirJogadores = new System.Windows.Forms.Button();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnExibirMao = new System.Windows.Forms.Button();
            this.panelCartas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVerPartidas
            // 
            this.btnVerPartidas.BackColor = System.Drawing.Color.Wheat;
            this.btnVerPartidas.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerPartidas.Location = new System.Drawing.Point(39, 44);
            this.btnVerPartidas.Name = "btnVerPartidas";
            this.btnVerPartidas.Size = new System.Drawing.Size(128, 40);
            this.btnVerPartidas.TabIndex = 0;
            this.btnVerPartidas.Text = "Ver Partidas";
            this.btnVerPartidas.UseVisualStyleBackColor = false;
            this.btnVerPartidas.Click += new System.EventHandler(this.btnVerPartidas_Click);
            // 
            // lstListaPartidas
            // 
            this.lstListaPartidas.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstListaPartidas.FormattingEnabled = true;
            this.lstListaPartidas.ItemHeight = 28;
            this.lstListaPartidas.Location = new System.Drawing.Point(173, 44);
            this.lstListaPartidas.Name = "lstListaPartidas";
            this.lstListaPartidas.Size = new System.Drawing.Size(203, 228);
            this.lstListaPartidas.TabIndex = 1;
            this.lstListaPartidas.SelectedIndexChanged += new System.EventHandler(this.lstListaPartidas_SelectedIndexChanged);
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePartida.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.Location = new System.Drawing.Point(40, 99);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(121, 27);
            this.lblNomePartida.TabIndex = 2;
            this.lblNomePartida.Text = "Nome da partida:";
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(43, 121);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(124, 20);
            this.txtNomePartida.TabIndex = 3;
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPartida.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPartida.Location = new System.Drawing.Point(40, 149);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(122, 27);
            this.lblSenhaPartida.TabIndex = 4;
            this.lblSenhaPartida.Text = "Senha da partida:";
            // 
            // txtSenhaPartida
            // 
            this.txtSenhaPartida.Location = new System.Drawing.Point(43, 171);
            this.txtSenhaPartida.Name = "txtSenhaPartida";
            this.txtSenhaPartida.Size = new System.Drawing.Size(124, 20);
            this.txtSenhaPartida.TabIndex = 5;
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.BackColor = System.Drawing.Color.Wheat;
            this.btnCriarPartida.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriarPartida.Location = new System.Drawing.Point(39, 228);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(128, 40);
            this.btnCriarPartida.TabIndex = 6;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = false;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblNomeJogador.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeJogador.Location = new System.Drawing.Point(385, 99);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(107, 27);
            this.lblNomeJogador.TabIndex = 7;
            this.lblNomeJogador.Text = "Nome jogador:";
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(386, 121);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(156, 20);
            this.txtNomeJogador.TabIndex = 8;
            // 
            // lblSenhaPE
            // 
            this.lblSenhaPE.AutoSize = true;
            this.lblSenhaPE.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaPE.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaPE.Location = new System.Drawing.Point(383, 149);
            this.lblSenhaPE.Name = "lblSenhaPE";
            this.lblSenhaPE.Size = new System.Drawing.Size(122, 27);
            this.lblSenhaPE.TabIndex = 9;
            this.lblSenhaPE.Text = "Senha da partida:";
            // 
            // txtSenhaPE
            // 
            this.txtSenhaPE.Location = new System.Drawing.Point(385, 171);
            this.txtSenhaPE.Name = "txtSenhaPE";
            this.txtSenhaPE.Size = new System.Drawing.Size(156, 20);
            this.txtSenhaPE.TabIndex = 10;
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.BackColor = System.Drawing.Color.Wheat;
            this.btnEntrarPartida.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarPartida.Location = new System.Drawing.Point(382, 222);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(156, 40);
            this.btnEntrarPartida.TabIndex = 11;
            this.btnEntrarPartida.Text = "Entrar na Partida";
            this.btnEntrarPartida.UseVisualStyleBackColor = false;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.BackColor = System.Drawing.Color.Transparent;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(385, 268);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(13, 23);
            this.lblInformacao.TabIndex = 12;
            this.lblInformacao.Text = ".";
            // 
            // lblPartidaInformacao
            // 
            this.lblPartidaInformacao.AutoSize = true;
            this.lblPartidaInformacao.BackColor = System.Drawing.Color.Transparent;
            this.lblPartidaInformacao.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPartidaInformacao.Location = new System.Drawing.Point(40, 271);
            this.lblPartidaInformacao.Name = "lblPartidaInformacao";
            this.lblPartidaInformacao.Size = new System.Drawing.Size(13, 23);
            this.lblPartidaInformacao.TabIndex = 13;
            this.lblPartidaInformacao.Text = ".";
            // 
            // panelCartas
            // 
            this.panelCartas.BackColor = System.Drawing.Color.Transparent;
            this.panelCartas.Controls.Add(this.picCarta6);
            this.panelCartas.Controls.Add(this.picCarta5);
            this.panelCartas.Controls.Add(this.picCarta4);
            this.panelCartas.Controls.Add(this.picCarta3);
            this.panelCartas.Controls.Add(this.picCarta2);
            this.panelCartas.Controls.Add(this.picCarta1);
            this.panelCartas.Location = new System.Drawing.Point(43, 346);
            this.panelCartas.Name = "panelCartas";
            this.panelCartas.Size = new System.Drawing.Size(495, 110);
            this.panelCartas.TabIndex = 16;
            this.panelCartas.Visible = false;
            // 
            // picCarta6
            // 
            this.picCarta6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta6.Location = new System.Drawing.Point(408, 3);
            this.picCarta6.Name = "picCarta6";
            this.picCarta6.Size = new System.Drawing.Size(75, 104);
            this.picCarta6.TabIndex = 30;
            this.picCarta6.TabStop = false;
            // 
            // picCarta5
            // 
            this.picCarta5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta5.Location = new System.Drawing.Point(327, 3);
            this.picCarta5.Name = "picCarta5";
            this.picCarta5.Size = new System.Drawing.Size(75, 104);
            this.picCarta5.TabIndex = 29;
            this.picCarta5.TabStop = false;
            // 
            // picCarta4
            // 
            this.picCarta4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta4.Location = new System.Drawing.Point(246, 3);
            this.picCarta4.Name = "picCarta4";
            this.picCarta4.Size = new System.Drawing.Size(75, 104);
            this.picCarta4.TabIndex = 28;
            this.picCarta4.TabStop = false;
            // 
            // picCarta3
            // 
            this.picCarta3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta3.Location = new System.Drawing.Point(165, 3);
            this.picCarta3.Name = "picCarta3";
            this.picCarta3.Size = new System.Drawing.Size(75, 104);
            this.picCarta3.TabIndex = 27;
            this.picCarta3.TabStop = false;
            // 
            // picCarta2
            // 
            this.picCarta2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta2.Location = new System.Drawing.Point(84, 3);
            this.picCarta2.Name = "picCarta2";
            this.picCarta2.Size = new System.Drawing.Size(75, 104);
            this.picCarta2.TabIndex = 26;
            this.picCarta2.TabStop = false;
            // 
            // picCarta1
            // 
            this.picCarta1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCarta1.Location = new System.Drawing.Point(3, 2);
            this.picCarta1.Name = "picCarta1";
            this.picCarta1.Size = new System.Drawing.Size(75, 104);
            this.picCarta1.TabIndex = 25;
            this.picCarta1.TabStop = false;
            // 
            // lstJogadores
            // 
            this.lstJogadores.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 28;
            this.lstJogadores.Location = new System.Drawing.Point(698, 86);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(168, 88);
            this.lstJogadores.TabIndex = 19;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // btnExibirJogadores
            // 
            this.btnExibirJogadores.BackColor = System.Drawing.Color.Wheat;
            this.btnExibirJogadores.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirJogadores.Location = new System.Drawing.Point(698, 40);
            this.btnExibirJogadores.Name = "btnExibirJogadores";
            this.btnExibirJogadores.Size = new System.Drawing.Size(168, 40);
            this.btnExibirJogadores.TabIndex = 20;
            this.btnExibirJogadores.Text = "Ver Jogadores";
            this.btnExibirJogadores.UseVisualStyleBackColor = false;
            this.btnExibirJogadores.Click += new System.EventHandler(this.btnExibirJogadores_Click);
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.BackColor = System.Drawing.Color.Transparent;
            this.lblSenhaJogador.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhaJogador.Location = new System.Drawing.Point(708, 198);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(127, 27);
            this.lblSenhaJogador.TabIndex = 21;
            this.lblSenhaJogador.Text = "Senha do jogador:";
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(706, 225);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(160, 20);
            this.txtSenhaJogador.TabIndex = 22;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Wheat;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.Location = new System.Drawing.Point(699, 258);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(168, 40);
            this.btnIniciarPartida.TabIndex = 23;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.BackColor = System.Drawing.Color.Transparent;
            this.lblInicio.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInicio.Location = new System.Drawing.Point(696, 349);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(13, 23);
            this.lblInicio.TabIndex = 24;
            this.lblInicio.Text = ".";
            // 
            // btnExibirMao
            // 
            this.btnExibirMao.BackColor = System.Drawing.Color.Wheat;
            this.btnExibirMao.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExibirMao.Location = new System.Drawing.Point(699, 304);
            this.btnExibirMao.Name = "btnExibirMao";
            this.btnExibirMao.Size = new System.Drawing.Size(168, 40);
            this.btnExibirMao.TabIndex = 25;
            this.btnExibirMao.Text = "Exibir Mão";
            this.btnExibirMao.UseVisualStyleBackColor = false;
            this.btnExibirMao.Click += new System.EventHandler(this.btnExibirMao_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI_Cartagena_Jogo.Properties.Resources.fundo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(890, 492);
            this.Controls.Add(this.btnExibirMao);
            this.Controls.Add(this.lblInicio);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.btnExibirJogadores);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.panelCartas);
            this.Controls.Add(this.lblPartidaInformacao);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.txtSenhaPE);
            this.Controls.Add(this.lblSenhaPE);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.txtSenhaPartida);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lstListaPartidas);
            this.Controls.Add(this.btnVerPartidas);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Bogotá";
            this.panelCartas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCarta6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCarta1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVerPartidas;
        private System.Windows.Forms.ListBox lstListaPartidas;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.TextBox txtSenhaPartida;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblSenhaPE;
        private System.Windows.Forms.TextBox txtSenhaPE;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblPartidaInformacao;
        private System.Windows.Forms.Panel panelCartas;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Button btnExibirJogadores;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.PictureBox picCarta5;
        private System.Windows.Forms.PictureBox picCarta4;
        private System.Windows.Forms.PictureBox picCarta3;
        private System.Windows.Forms.PictureBox picCarta2;
        private System.Windows.Forms.PictureBox picCarta1;
        private System.Windows.Forms.PictureBox picCarta6;
        private System.Windows.Forms.Button btnExibirMao;
    }
}

