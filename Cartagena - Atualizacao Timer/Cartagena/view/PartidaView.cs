using Cartagena.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena
{
    public partial class PartidaView : Form
    {
        List<Jogador> jogadores;
        List<Carta> cartas;
        List<Elemento> tabuleiro;

        List<PictureBox> picTabuleiro;
        List<PictureBox> picCartas;
        List<PictureBox> picPiratas;

        Game game;
        Partida partida;
        Jogador meuJogador;

        public PartidaView(Partida p, Jogador j)
        {
            try
            {
                InitializeComponent();

                this.partida = p;
                this.jogadores = new List<Jogador>();
                
                this.meuJogador = j;
                this.cartas = new List<Carta>();

                this.game = new Game();
                this.picCartas = new List<PictureBox>();

                this.tabuleiro = new List<Elemento>();
                this.picTabuleiro = new List<PictureBox>();
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
                string retorno = this.game.iniciarPartida(this.meuJogador);
                enviaMsg("Partida Iniciada! Jogador: " + this.meuJogador.Nome, "check");

                exibirTabuleiro();
                exibirPiratas();
                exibirCartas();

                panelJogar.Visible = true;
                btnIniciarPartida.Visible = false;
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void preencherDataGridJogadoresView()
        {
            this.jogadores = this.game.exibirJogadores(this.partida.Id);

            dtgJogadores.Columns.Clear();
            dtgJogadores.DataSource = jogadores;

            dtgJogadores.Columns["Id"].Width = 63;
            dtgJogadores.Columns["Nome"].Width = 110;
            dtgJogadores.Columns["Cor"].Width = 110;
            dtgJogadores.Columns["Status"].Width = 88;
            dtgJogadores.Columns["Jogadas"].Width = 88;

            dtgJogadores.Columns["ImgPirata"].Visible = false;
            dtgJogadores.Columns["Senha"].Visible = false;

            dtgJogadores.Refresh();
        }

        private void exibirTabuleiro()
        {
            try
            {
                int x = 287, y = 586;

                this.tabuleiro = this.game.exibirTabuleiro(this.partida.Id);
                this.tabuleiro = atualizarImgPosicoes(this.tabuleiro);

                for (int i = 0; i < this.picTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Remove(this.picTabuleiro[i]);
                }

                this.picTabuleiro.Clear();
                for (int i = 1; i < this.tabuleiro.Count; i++)
                {
                    this.tabuleiro[i].X = x;
                    this.tabuleiro[i].Y = y;

                    PictureBox p = new PictureBox();

                    p.Location = new System.Drawing.Point(x, y);
                    p.Width = this.tabuleiro[i].W;
                    p.Height = this.tabuleiro[i].H;
                    p.BackgroundImage = this.tabuleiro[i].Img;
                    p.BackgroundImageLayout = ImageLayout.Stretch;

                    this.picTabuleiro.Add(p);

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

                    if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                    {
                        y -= 93;
                    }

                }

                for (int i = 0; i < this.picTabuleiro.Count; i++)
                {
                    panelTabuleiro.Controls.Add(this.picTabuleiro[i]);
                }

                panelTabuleiro.Refresh();
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

                for (int i = 0; i < this.picPiratas.Count; i++)
                {
                    panelTabuleiro.Controls.Remove(this.picPiratas[i]);
                }

                this.picPiratas.Clear();

                for(int i = 0; i < this.tabuleiro.Count; i++)
                {
                    int x, y;
                    int x0 = 5, y0 = 570;

                    for (int l = 0; l < this.tabuleiro[i].Piratas.Count; l++)
                    {
                        PictureBox p = new PictureBox();
                        p.Width = 20;
                        p.Height = 20;
                        p.BackgroundImageLayout = ImageLayout.Stretch;
                        p.BackgroundImage = this.tabuleiro[i].Piratas[l].Jogador.ImgPirata;
                      
                        if (i == 0)
                        {
                            p.Location = new System.Drawing.Point(x0, y0);
                            x0 += 22;
                        }
                        else
                        {
                            x = this.tabuleiro[i].X;
                            y = this.tabuleiro[i].Y + 5;

                            p.Location = new System.Drawing.Point(x, y);
                            x += 22;
                        }

                        this.picPiratas.Add(p);
                   }
                    
                }

                for (int i = 0; i < this.picPiratas.Count; i++)
                {
                    panelTabuleiro.Controls.Add(this.picPiratas[i]);
                }

                panelTabuleiro.Refresh();
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
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            } 
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void tmrViewJogadores_Tick(object sender, EventArgs e)
        {
            preencherDataGridJogadoresView();
        }

        private void tmrVez_Tick(object sender, EventArgs e)
        {
            if(btnIniciarPartida.Visible == false)
            {
                Jogador jVez = new Jogador();
                jVez = this.game.verificaVez(this.jogadores, this.partida.Id);

                if (jVez.Equals(this.meuJogador))
                {
                    this.meuJogador.Jogadas = jVez.Jogadas;
                }
                preencherDataGridJogadoresView();
            }
        }

        private void btnMoverAtras_Click(object sender, EventArgs e)
        {
            try
            {
                this.game.voltarPirata(this.meuJogador, int.Parse(txtPosicao.Text));
                exibirCartas();
                exibirPiratas();
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

        private List<Jogador> atualizarImgPiratas(List<Jogador> j)
        {
            foreach (Jogador jo in j)
            {
                if (jo.Cor.Equals("Vermelho"))
                {
                    jo.ImgPirata = Properties.Resources.vermelho;
                }

                if (jo.Cor.Equals("Azul"))
                {
                    jo.ImgPirata = Properties.Resources.azul;
                }

                if (jo.Cor.Equals("Laranja"))
                {
                    jo.ImgPirata = Properties.Resources.laranja;
                }

                if (jo.Cor.Equals("Verde"))
                {
                    jo.ImgPirata = Properties.Resources.verde;
                }

                if (jo.Cor.Equals("Marrom"))
                {
                    jo.ImgPirata = Properties.Resources.marrom;
                }
            }

            return j;
        }
        

        private List<Elemento> atualizarImgPosicoes(List<Elemento> l)
        {
            foreach (Elemento t in l)
            {
                if (t.Simbolo == "P")
                {
                    t.Img = Cartagena.Properties.Resources.pistola;
                    t.W = 46;
                    t.H = 46;
                }

                if (t.Simbolo == "E")
                {
                    t.Img = Cartagena.Properties.Resources.esqueleto;
                    t.W = 56;
                    t.H = 46;
                }

                if (t.Simbolo == "C")
                {
                    t.Img = Cartagena.Properties.Resources.chave;
                    t.W = 46;
                    t.H = 46;
                }

                if (t.Simbolo == "F")
                {
                    t.Img = Cartagena.Properties.Resources.faca;
                    t.W = 46;
                    t.H = 46;
                }

                if (t.Simbolo == "G")
                {
                    t.Img = Cartagena.Properties.Resources.garrafa;
                    t.W = 42;
                    t.H = 46;
                }

                if (t.Simbolo == "T")
                {
                    t.Img = Cartagena.Properties.Resources.tricornio;
                    t.W = 56;
                    t.H = 46;
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
    }
}
