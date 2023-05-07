using Cartagena.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Cartagena
{
    public partial class PartidaView : Form
    {
        List<Jogador> jogadores;
        List<Carta> cartas;
        List<Elemento> tabuleiro;

        List<Panel> panelPosTabuleiro;
        List<PictureBox> picCartas;
        List<PictureBox> picPiratas;

        Game game;
        Partida partida;
        Jogador meuJogador;

        HistoricoView historico;

        public PartidaView(Partida p, Jogador j)
        {
            try
            {
                InitializeComponent();

                this.partida = p;
                lblNomePartida.Text = "Partida: " + p.Nome;
                this.jogadores = new List<Jogador>();
                
                this.meuJogador = j;
                this.cartas = new List<Carta>();
                this.picCartas = new List<PictureBox>();

                this.game = new Game();
               
                this.tabuleiro = new List<Elemento>();
                this.panelPosTabuleiro = new List<Panel>();
                this.picPiratas = new List<PictureBox>();
                
                tmrViewJogadores.Enabled = true;
                tmrVez.Enabled = true;

                preencherDataGridJogadoresView();
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }            
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.meuJogador != null)
                {
                    string retorno = this.game.iniciarPartida(this.meuJogador);
                    enviaMsg("Partida Iniciada! Jogador: " + this.meuJogador.Nome, "check");
                    enviaMsg(retorno, "erro");

                    this.partida.Iniciou = true;

                    exibirTabuleiro();
                    exibirPiratas();
                    exibirCartas();
                    exibirHistorico();

                    btnIniciarPartida.Visible = false;
                }
                else
                {
                    enviaMsg("Você está apenas assistindo a partida!", "aviso");
                    btnIniciarPartida.Visible = false;
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            InicioView i = new InicioView();
            i.Show();
            this.Hide();

            if(this.historico != null && this.historico.Visible)
            {
                this.historico.Hide();
            }
        }

        private void exibirTabuleiro()
        {
            try
            {
                int x = 284, y = 586;

                this.tabuleiro = this.game.exibirTabuleiro(this.partida.Id);
                this.tabuleiro = atualizarImgPosicoes(this.tabuleiro);

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Remove(this.panelPosTabuleiro[i]);
                }

                this.panelPosTabuleiro.Clear();
                for (int i = 0; i < this.tabuleiro.Count; i++)
                {
                    this.tabuleiro[i].X = x;
                    this.tabuleiro[i].Y = y;

                    if (i == 0)
                    {
                        this.tabuleiro[i].X = 0;
                        this.tabuleiro[i].Y = 576;
                    }
                    
                    Panel p = new Panel();

                    p.Location = new System.Drawing.Point(this.tabuleiro[i].X, this.tabuleiro[i].Y);
                    p.Width = this.tabuleiro[i].W;
                    p.Height = this.tabuleiro[i].H;
                    p.BackgroundImage = this.tabuleiro[i].Img;

                    if(i == 0)
                    {
                        p.BackgroundImageLayout = ImageLayout.Stretch;
                    }
                    else
                    {
                        p.BackgroundImageLayout = ImageLayout.Zoom;
                    }
                    
                    this.panelPosTabuleiro.Add(p);

                    if(i >= 1)
                    {
                        if (i < 3)
                        {
                            x += 89;
                        }

                        if (i > 3 && i < 9)
                        {
                            x -= 89;
                        }

                        if (i > 9 && i < 15)
                        {
                            x += 89;
                        }

                        if (i > 15 && i < 21)
                        {
                            x -= 89;
                        }

                        if (i > 21 && i < 27)
                        {
                            x += 89;
                        }

                        if (i > 27 && i < 33)
                        {
                            x -= 89;
                        }

                        if (i > 33)
                        {
                            x += 89;
                        }

                        if (i == 36)
                        {
                            y = 0;
                        }

                        if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                        {
                            y -= 94;
                        }
                    }
                }

                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Add(this.panelPosTabuleiro[i]);
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void exibirPiratas()
        {
            try
            {
                this.jogadores = atualizarImgPiratas(this.jogadores);
                this.tabuleiro = this.game.exibirPiratas(this.partida.Id, this.tabuleiro, this.jogadores);

                this.picPiratas.Clear();
                for (int i = 0; i < this.panelPosTabuleiro.Count; i++)
                {
                    this.panelPosTabuleiro[i].Controls.Clear();
                }

                for(int i = 0; i < this.tabuleiro.Count; i++)
                {
                    int x = 25, y = 0;
                    int x0 = 4, y0 = 24;
                    int xF = 57, yF = 0;

                    for (int l = 0; l < this.tabuleiro[i].Piratas.Count; l++)
                    {
                        PictureBox p = new PictureBox();
                        p.Width = 18;
                        p.Height = 18;
                        p.BackgroundImageLayout = ImageLayout.Stretch;
                        p.BackgroundImage = this.tabuleiro[i].Piratas[l].Jogador.ImgPirata;
                      
                        if (i == 0)
                        {
                            p.Location = new System.Drawing.Point(x0, y0);
                            x0 += 20;

                            if(l == 11 || l == 23)
                            {
                                x0 = 4;
                                y0 += 22;
                            }
                        }
                        else if (i == 37)
                        {
                            p.Location = new System.Drawing.Point(xF, yF);
                            xF += 20;

                            if (l == 5 || l == 11 || l == 17 || l == 23)
                            {
                                xF = 57;
                                yF += 18;
                            }
                        }
                        else
                        {
                            p.Location = new System.Drawing.Point(x, y);
                            y += 18;
                        }

                        this.picPiratas.Add(p);
                        panelPosTabuleiro[i].Controls.Add(p);
                    }
                    
                }

            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void exibirCartas()
        {
            try
            {
                if(this.meuJogador != null)
                {
                    panelCartas.Visible = true;
                    int x = 4, y = 39;

                    this.cartas = this.game.consultarMao(this.meuJogador);
                    this.cartas = atualizarImgCartas(this.cartas);

                    for (int i = 0; i < this.picCartas.Count; i++)
                    {
                        panelCartas.Controls.Remove(this.picCartas[i]);

                    }

                    this.picCartas.Clear();
                    for (int i = 0; i < this.cartas.Count; i++)
                    {
                        PictureBox p = new PictureBox();

                        p.Location = new System.Drawing.Point(x, y);
                        p.Width = 79;
                        p.Height = 121;
                        p.BackgroundImage = this.cartas[i].Img;
                        p.BackgroundImageLayout = ImageLayout.Stretch;

                        this.picCartas.Add(p);
                        x += 40;
                    }

                    for (int i = 0; i < this.picCartas.Count; i++)
                    {
                        panelCartas.Controls.Add(this.picCartas[i]);
                    }
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            } 
        }

        private void exibirHistorico()
        {
            if (this.historico == null)
            {
                this.historico = new HistoricoView(this.partida, this.jogadores);
            }

            if (!this.historico.Visible && this.Visible)
            {
                this.historico.Show();

                this.Location = new Point(this.Location.X - 250, this.Location.Y);
                this.historico.Location = new Point(this.Width + this.Location.X, this.Location.Y);
            }
        }

        private void tmrViewJogadores_Tick(object sender, EventArgs e)
        {
           preencherDataGridJogadoresView();
        }

        private void tmrVez_Tick(object sender, EventArgs e)
        {
            Jogador jVez = new Jogador();
            jVez = this.game.verificaVez(this.jogadores, this.partida.Id);

            if(jVez != null)
            {
                this.partida.Iniciou = true;
                btnIniciarPartida.Visible = false;
               
                if (this.tabuleiro.Count == 0)
                {
                    exibirTabuleiro();
                }

                exibirHistorico();
                exibirPiratas();

                if (this.tabuleiro[37].Piratas.Count >= 6)
                {
                    int qtdPiratas = 0;

                    for (int i = 0; i < this.jogadores.Count; i++)
                    {
                        foreach (Pirata pirata in this.tabuleiro[37].Piratas)
                        {
                            if (pirata.Jogador.Id == this.jogadores[i].Id)
                            {
                                qtdPiratas++;
                            }
                        }

                        if (qtdPiratas == 6)
                        {
                            enviaMsg("Partida Finalizada. Vencedor(a): " + this.jogadores[i].Nome, "check");
                            tmrVez.Enabled = false;
                        }

                        qtdPiratas = 0;
                    }

                }

                if (panelCartas.Visible == false || jVez.Equals(this.meuJogador))
                {
                    exibirCartas();
                }

                foreach (Jogador jogador in this.jogadores)
                {
                    if (jogador.Equals(jVez))
                    {
                        jogador.Jogada = jVez.Jogada;
                        jogador.Status = jVez.Status;
                    }
                    else
                    {
                        jogador.Status = "Aguardando Vez";
                        jogador.Jogada = 0;
                    }
                }

                preencherDataGridJogadoresView();
            }
            
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void preencherDataGridJogadoresView()
        {
            if (!this.partida.Iniciou)
            {
                this.jogadores = this.game.exibirJogadores(this.partida.Id);
                this.jogadores = atualizarImgPiratas(this.jogadores);
            }

            dtgJogadores.DataSource = this.jogadores;
            dtgJogadores.ClearSelection();

            dtgJogadores.Columns["Id"].Width = 63;
            dtgJogadores.Columns["Nome"].Width = 91;
            dtgJogadores.Columns["Cor"].Width = 110;
            dtgJogadores.Columns["Status"].Width = 140;
            dtgJogadores.Columns["Jogada"].Width = 77;

            dtgJogadores.Columns["ImgPirata"].Visible = false;
            dtgJogadores.Columns["ColorPirata"].Visible = false;
            dtgJogadores.Columns["Senha"].Visible = false;

            foreach (DataGridViewRow row in dtgJogadores.Rows)
            {
                foreach (Jogador j in this.jogadores)
                {
                    if (Convert.ToInt32(row.Cells["Id"].Value) == j.Id)
                    {
                        row.DefaultCellStyle.ForeColor = j.ColorPirata;
                        row.DefaultCellStyle.SelectionForeColor = j.ColorPirata;
                    }
                }
            }

            dtgJogadores.Refresh();
        }

        private List<Jogador> atualizarImgPiratas(List<Jogador> j)
        {
            foreach (Jogador jo in j)
            {
                if (jo.Cor.Equals("Vermelho"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.vermelho;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(152, 28, 12);
                }

                if (jo.Cor.Equals("Azul"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.azul;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(12, 135, 152);
                }

                if (jo.Cor.Equals("Amarelo"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.amarelo;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(255, 194, 0);
                }

                if (jo.Cor.Equals("Verde"))
                {
                    jo.ImgPirata = Cartagena.Properties.Resources.verde;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(12, 148, 25);
                }

                if (jo.Cor.Equals("Marrom"))
                {
                    jo.ImgPirata = Properties.Resources.marrom;
                    jo.ColorPirata = System.Drawing.Color.FromArgb(76, 4, 4);
                }
            }

            return j;
        }
        
        private List<Elemento> atualizarImgPosicoes(List<Elemento> l)
        {
            foreach (Elemento t in l)
            {
                t.W = 53;
                t.H = 53;

                if (t.Posicao == 0)
                {
                    t.W = 259;
                    t.H = 88;
                    t.Img = Cartagena.Properties.Resources.areia;
                }

                if (t.Posicao == 37)
                {
                    t.W = 255;
                    t.H = 95;
                    t.Img = Cartagena.Properties.Resources.barco;
                }

                if (t.Simbolo == "P")
                {
                    t.Img = Cartagena.Properties.Resources.pistola;
                }

                if (t.Simbolo == "E")
                {
                    t.Img = Cartagena.Properties.Resources.esqueleto;
                }

                if (t.Simbolo == "C")
                {
                    t.Img = Cartagena.Properties.Resources.chave;
                }

                if (t.Simbolo == "F")
                {
                    t.Img = Cartagena.Properties.Resources.faca;
                }

                if (t.Simbolo == "G")
                {
                    t.Img = Cartagena.Properties.Resources.garrafa;
                }

                if (t.Simbolo == "T")
                {
                    t.Img = Cartagena.Properties.Resources.tricornio;
                }
            }

            return l;
        }

        private List<Carta> atualizarImgCartas(List<Carta> c)
        {
            foreach (Carta ca in c)
            {
                if (ca.Simbolo == "P")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_pistola;
                }

                if (ca.Simbolo == "E")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_esqueleto;
                }

                if (ca.Simbolo == "C")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_chave;
                }

                if (ca.Simbolo == "F")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_faca;
                }

                if (ca.Simbolo == "G")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_garrafa;
                }

                if (ca.Simbolo == "T")
                {
                    ca.Img = Cartagena.Properties.Resources.carta_tricornio;
                }
            }

            return c;
        }

        private void btnMoverAtras_Click(object sender, EventArgs e)
        {
            try
            {
                this.game.voltarPirata(this.meuJogador, int.Parse(txtPosicao.Text));
                exibirPiratas();
                exibirCartas();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }

        }

        private void btnMoverFrente_Click(object sender, EventArgs e)
        {
            try
            {
                this.game.moverPirata(this.meuJogador, int.Parse(txtPosicao.Text), txtCarta.Text);
                exibirPiratas();
                exibirCartas();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void btnPularVez_Click(object sender, EventArgs e)
        {
            try
            {
                this.game.pularVez(this.meuJogador);
                exibirPiratas();
                exibirCartas();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel = true;
            base.OnClosing(e);
        }

    }
}
