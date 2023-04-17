﻿namespace Cartagena
{
    partial class PartidaView
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgJogadores = new System.Windows.Forms.DataGridView();
            this.panelTabuleiro = new System.Windows.Forms.Panel();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.panelCartas = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tmrViewJogadores = new System.Windows.Forms.Timer(this.components);
            this.btnMoverFrente = new System.Windows.Forms.Button();
            this.btnMoverAtras = new System.Windows.Forms.Button();
            this.panelJogar = new System.Windows.Forms.Panel();
            this.txtCarta = new System.Windows.Forms.TextBox();
            this.btnPularVez = new System.Windows.Forms.Button();
            this.txtPosicao = new System.Windows.Forms.TextBox();
            this.lblCarta = new System.Windows.Forms.Label();
            this.lblPosicao = new System.Windows.Forms.Label();
            this.tmrVez = new System.Windows.Forms.Timer(this.components);
            this.IdJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jogadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNomePartida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgJogadores)).BeginInit();
            this.panelCartas.SuspendLayout();
            this.panelJogar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgJogadores
            // 
            this.dtgJogadores.AllowUserToAddRows = false;
            this.dtgJogadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgJogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dtgJogadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgJogadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            this.dtgJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgJogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dtgJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdJogador,
            this.NomeJogador,
            this.CorJogador,
            this.Status,
            this.Jogadas});
            this.dtgJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgJogadores.DefaultCellStyle = dataGridViewCellStyle8;
            this.dtgJogadores.EnableHeadersVisualStyles = false;
            this.dtgJogadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            this.dtgJogadores.Location = new System.Drawing.Point(561, 43);
            this.dtgJogadores.MultiSelect = false;
            this.dtgJogadores.Name = "dtgJogadores";
            this.dtgJogadores.ReadOnly = true;
            this.dtgJogadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJogadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dtgJogadores.RowHeadersVisible = false;
            this.dtgJogadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgJogadores.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dtgJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgJogadores.Size = new System.Drawing.Size(481, 147);
            this.dtgJogadores.TabIndex = 7;
            // 
            // panelTabuleiro
            // 
            this.panelTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.panelTabuleiro.BackgroundImage = global::Cartagena.Properties.Resources.fundo_tabuleiro;
            this.panelTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTabuleiro.Location = new System.Drawing.Point(0, 3);
            this.panelTabuleiro.Name = "panelTabuleiro";
            this.panelTabuleiro.Size = new System.Drawing.Size(538, 659);
            this.panelTabuleiro.TabIndex = 8;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.Location = new System.Drawing.Point(883, 6);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(159, 34);
            this.btnIniciarPartida.TabIndex = 9;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = false;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // panelCartas
            // 
            this.panelCartas.AutoScroll = true;
            this.panelCartas.BackColor = System.Drawing.Color.Transparent;
            this.panelCartas.Controls.Add(this.lbltitulo);
            this.panelCartas.Location = new System.Drawing.Point(561, 211);
            this.panelCartas.Name = "panelCartas";
            this.panelCartas.Size = new System.Drawing.Size(463, 183);
            this.panelCartas.TabIndex = 11;
            this.panelCartas.Visible = false;
            // 
            // lbltitulo
            // 
            this.lbltitulo.AutoSize = true;
            this.lbltitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.lbltitulo.Location = new System.Drawing.Point(3, 7);
            this.lbltitulo.Name = "lbltitulo";
            this.lbltitulo.Size = new System.Drawing.Size(128, 23);
            this.lbltitulo.TabIndex = 5;
            this.lbltitulo.Text = "Minhas Cartas:";
            this.lbltitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrViewJogadores
            // 
            this.tmrViewJogadores.Interval = 5000;
            this.tmrViewJogadores.Tick += new System.EventHandler(this.tmrViewJogadores_Tick);
            // 
            // btnMoverFrente
            // 
            this.btnMoverFrente.BackColor = System.Drawing.Color.Transparent;
            this.btnMoverFrente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoverFrente.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverFrente.ForeColor = System.Drawing.Color.White;
            this.btnMoverFrente.Location = new System.Drawing.Point(248, 73);
            this.btnMoverFrente.Name = "btnMoverFrente";
            this.btnMoverFrente.Size = new System.Drawing.Size(200, 46);
            this.btnMoverFrente.TabIndex = 12;
            this.btnMoverFrente.Text = "Mover Para Frente";
            this.btnMoverFrente.UseVisualStyleBackColor = false;
            this.btnMoverFrente.Click += new System.EventHandler(this.btnMoverFrente_Click);
            // 
            // btnMoverAtras
            // 
            this.btnMoverAtras.BackColor = System.Drawing.Color.Transparent;
            this.btnMoverAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMoverAtras.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoverAtras.ForeColor = System.Drawing.Color.White;
            this.btnMoverAtras.Location = new System.Drawing.Point(248, 16);
            this.btnMoverAtras.Name = "btnMoverAtras";
            this.btnMoverAtras.Size = new System.Drawing.Size(200, 46);
            this.btnMoverAtras.TabIndex = 13;
            this.btnMoverAtras.Text = "Mover Para Trás";
            this.btnMoverAtras.UseVisualStyleBackColor = false;
            this.btnMoverAtras.Click += new System.EventHandler(this.btnMoverAtras_Click);
            // 
            // panelJogar
            // 
            this.panelJogar.BackColor = System.Drawing.Color.Transparent;
            this.panelJogar.Controls.Add(this.txtCarta);
            this.panelJogar.Controls.Add(this.btnPularVez);
            this.panelJogar.Controls.Add(this.txtPosicao);
            this.panelJogar.Controls.Add(this.lblCarta);
            this.panelJogar.Controls.Add(this.lblPosicao);
            this.panelJogar.Controls.Add(this.btnMoverAtras);
            this.panelJogar.Controls.Add(this.btnMoverFrente);
            this.panelJogar.Location = new System.Drawing.Point(561, 416);
            this.panelJogar.Name = "panelJogar";
            this.panelJogar.Size = new System.Drawing.Size(463, 192);
            this.panelJogar.TabIndex = 14;
            this.panelJogar.Visible = false;
            // 
            // txtCarta
            // 
            this.txtCarta.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarta.Location = new System.Drawing.Point(92, 76);
            this.txtCarta.Name = "txtCarta";
            this.txtCarta.Size = new System.Drawing.Size(135, 34);
            this.txtCarta.TabIndex = 20;
            // 
            // btnPularVez
            // 
            this.btnPularVez.BackColor = System.Drawing.Color.Transparent;
            this.btnPularVez.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPularVez.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPularVez.ForeColor = System.Drawing.Color.White;
            this.btnPularVez.Location = new System.Drawing.Point(124, 130);
            this.btnPularVez.Name = "btnPularVez";
            this.btnPularVez.Size = new System.Drawing.Size(200, 46);
            this.btnPularVez.TabIndex = 19;
            this.btnPularVez.Text = "Pular Vez";
            this.btnPularVez.UseVisualStyleBackColor = false;
            this.btnPularVez.Click += new System.EventHandler(this.btnPularVez_Click);
            // 
            // txtPosicao
            // 
            this.txtPosicao.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPosicao.Location = new System.Drawing.Point(92, 21);
            this.txtPosicao.Name = "txtPosicao";
            this.txtPosicao.Size = new System.Drawing.Size(135, 34);
            this.txtPosicao.TabIndex = 18;
            // 
            // lblCarta
            // 
            this.lblCarta.AutoSize = true;
            this.lblCarta.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.lblCarta.Location = new System.Drawing.Point(10, 86);
            this.lblCarta.Name = "lblCarta";
            this.lblCarta.Size = new System.Drawing.Size(68, 23);
            this.lblCarta.TabIndex = 17;
            this.lblCarta.Text = "Carta: ";
            this.lblCarta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPosicao
            // 
            this.lblPosicao.AutoSize = true;
            this.lblPosicao.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosicao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.lblPosicao.Location = new System.Drawing.Point(10, 26);
            this.lblPosicao.Name = "lblPosicao";
            this.lblPosicao.Size = new System.Drawing.Size(78, 23);
            this.lblPosicao.TabIndex = 16;
            this.lblPosicao.Text = "Posição: ";
            this.lblPosicao.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrVez
            // 
            this.tmrVez.Interval = 10000;
            this.tmrVez.Tick += new System.EventHandler(this.tmrVez_Tick);
            // 
            // IdJogador
            // 
            this.IdJogador.HeaderText = "Id";
            this.IdJogador.Name = "IdJogador";
            this.IdJogador.ReadOnly = true;
            this.IdJogador.Width = 63;
            // 
            // NomeJogador
            // 
            this.NomeJogador.HeaderText = "Nome";
            this.NomeJogador.Name = "NomeJogador";
            this.NomeJogador.ReadOnly = true;
            this.NomeJogador.Width = 91;
            // 
            // CorJogador
            // 
            this.CorJogador.HeaderText = "Cor";
            this.CorJogador.Name = "CorJogador";
            this.CorJogador.ReadOnly = true;
            this.CorJogador.Width = 110;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 140;
            // 
            // Jogadas
            // 
            this.Jogadas.HeaderText = "Jogadas";
            this.Jogadas.Name = "Jogadas";
            this.Jogadas.ReadOnly = true;
            this.Jogadas.Width = 77;
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.BackColor = System.Drawing.Color.Transparent;
            this.lblNomePartida.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomePartida.ForeColor = System.Drawing.Color.White;
            this.lblNomePartida.Location = new System.Drawing.Point(560, 10);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(94, 27);
            this.lblNomePartida.TabIndex = 17;
            this.lblNomePartida.Text = "Partida: ";
            this.lblNomePartida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PartidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartagena.Properties.Resources.fundo_partida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1082, 667);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.panelJogar);
            this.Controls.Add(this.panelCartas);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.panelTabuleiro);
            this.Controls.Add(this.dtgJogadores);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "PartidaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bogotá";
            ((System.ComponentModel.ISupportInitialize)(this.dtgJogadores)).EndInit();
            this.panelCartas.ResumeLayout(false);
            this.panelCartas.PerformLayout();
            this.panelJogar.ResumeLayout(false);
            this.panelJogar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgJogadores;
        private System.Windows.Forms.Panel panelTabuleiro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.Panel panelCartas;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Timer tmrViewJogadores;
        private System.Windows.Forms.Button btnMoverFrente;
        private System.Windows.Forms.Button btnMoverAtras;
        private System.Windows.Forms.Panel panelJogar;
        private System.Windows.Forms.Label lblCarta;
        private System.Windows.Forms.Label lblPosicao;
        private System.Windows.Forms.Timer tmrVez;
        private System.Windows.Forms.TextBox txtPosicao;
        private System.Windows.Forms.Button btnPularVez;
        private System.Windows.Forms.TextBox txtCarta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jogadas;
        private System.Windows.Forms.Label lblNomePartida;
    }
}