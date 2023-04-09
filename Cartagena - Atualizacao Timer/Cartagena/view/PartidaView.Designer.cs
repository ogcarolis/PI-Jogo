namespace Cartagena
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtgJogadores = new System.Windows.Forms.DataGridView();
            this.IdJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CorJogador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelTabuleiro = new System.Windows.Forms.Panel();
            this.picBarco = new System.Windows.Forms.PictureBox();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.panelCartas = new System.Windows.Forms.Panel();
            this.lbltitulo = new System.Windows.Forms.Label();
            this.tmrViewJogadores = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dtgJogadores)).BeginInit();
            this.panelTabuleiro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBarco)).BeginInit();
            this.panelCartas.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgJogadores
            // 
            this.dtgJogadores.AllowUserToAddRows = false;
            this.dtgJogadores.AllowUserToDeleteRows = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgJogadores.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dtgJogadores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dtgJogadores.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            this.dtgJogadores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgJogadores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedVertical;
            this.dtgJogadores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJogadores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dtgJogadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgJogadores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdJogador,
            this.NomeJogador,
            this.CorJogador});
            this.dtgJogadores.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgJogadores.DefaultCellStyle = dataGridViewCellStyle13;
            this.dtgJogadores.EnableHeadersVisualStyles = false;
            this.dtgJogadores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            this.dtgJogadores.Location = new System.Drawing.Point(740, 43);
            this.dtgJogadores.MultiSelect = false;
            this.dtgJogadores.Name = "dtgJogadores";
            this.dtgJogadores.ReadOnly = true;
            this.dtgJogadores.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgJogadores.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dtgJogadores.RowHeadersVisible = false;
            this.dtgJogadores.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(150)))), ((int)(((byte)(132)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(135)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgJogadores.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgJogadores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgJogadores.Size = new System.Drawing.Size(284, 147);
            this.dtgJogadores.TabIndex = 7;
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
            this.NomeJogador.Width = 110;
            // 
            // CorJogador
            // 
            this.CorJogador.HeaderText = "Cor";
            this.CorJogador.Name = "CorJogador";
            this.CorJogador.ReadOnly = true;
            this.CorJogador.Width = 110;
            // 
            // panelTabuleiro
            // 
            this.panelTabuleiro.BackColor = System.Drawing.Color.Transparent;
            this.panelTabuleiro.BackgroundImage = global::Cartagena.Properties.Resources.fundo_tabuleiro;
            this.panelTabuleiro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTabuleiro.Controls.Add(this.picBarco);
            this.panelTabuleiro.Location = new System.Drawing.Point(0, 0);
            this.panelTabuleiro.Name = "panelTabuleiro";
            this.panelTabuleiro.Size = new System.Drawing.Size(538, 659);
            this.panelTabuleiro.TabIndex = 8;
            // 
            // picBarco
            // 
            this.picBarco.BackgroundImage = global::Cartagena.Properties.Resources.barco;
            this.picBarco.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBarco.Location = new System.Drawing.Point(304, 2);
            this.picBarco.Name = "picBarco";
            this.picBarco.Size = new System.Drawing.Size(202, 96);
            this.picBarco.TabIndex = 11;
            this.picBarco.TabStop = false;
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciarPartida.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIniciarPartida.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciarPartida.ForeColor = System.Drawing.Color.White;
            this.btnIniciarPartida.Location = new System.Drawing.Point(740, 203);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(284, 46);
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
            this.panelCartas.Location = new System.Drawing.Point(561, 466);
            this.panelCartas.Name = "panelCartas";
            this.panelCartas.Size = new System.Drawing.Size(491, 183);
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
            // PartidaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Cartagena.Properties.Resources.fundo_partida;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1064, 661);
            this.Controls.Add(this.panelCartas);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.panelTabuleiro);
            this.Controls.Add(this.dtgJogadores);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "PartidaView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            ((System.ComponentModel.ISupportInitialize)(this.dtgJogadores)).EndInit();
            this.panelTabuleiro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBarco)).EndInit();
            this.panelCartas.ResumeLayout(false);
            this.panelCartas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgJogadores;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeJogador;
        private System.Windows.Forms.DataGridViewTextBoxColumn CorJogador;
        private System.Windows.Forms.Panel panelTabuleiro;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.PictureBox picBarco;
        private System.Windows.Forms.Panel panelCartas;
        private System.Windows.Forms.Label lbltitulo;
        private System.Windows.Forms.Timer tmrViewJogadores;
    }
}