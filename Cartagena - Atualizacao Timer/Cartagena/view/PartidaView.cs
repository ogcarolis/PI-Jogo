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
        int idPartida;
        Jogador meuJogador;
        Game game;
        public PartidaView(int id, Jogador j)
        {
            try
            {
                InitializeComponent();

                this.idPartida = id;
                meuJogador = j;

                game = new Game();
                tmrViewJogadores.Enabled = true;
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
                exibirCartas();

                btnIniciarPartida.Visible = false;
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
        }

        private void preencherDataGridJogadoresView()
        {
            List<Jogador> jogadores = new List<Jogador>();
            jogadores = this.game.exibirJogadores(this.idPartida);

            dtgJogadores.Columns.Clear();
            dtgJogadores.DataSource = jogadores;

            dtgJogadores.Columns["Id"].Width = 63;
            dtgJogadores.Columns["Nome"].Width = 110;
            dtgJogadores.Columns["Cor"].Width = 110;

            dtgJogadores.Columns["Senha"].Visible = false;

            dtgJogadores.Refresh();
        }

        private void exibirTabuleiro()
        {
            try
            {
                int w = 287, h = 586;

                List<Tabuleiro> pTabuleiro = new List<Tabuleiro>();
                pTabuleiro = this.game.exibirTabuleiro(this.idPartida);

                pTabuleiro = atualizarImgPosicoes(pTabuleiro);

                for (int i = 1; i < pTabuleiro.Count; i++)
                {
                    PictureBox p = new PictureBox();
                    panelTabuleiro.Controls.Add(p);

                    p.Location = new System.Drawing.Point(w, h);
                    p.Width = 53;
                    p.Height = 53;

                    p.BackgroundImage = pTabuleiro[i].Img;
                    p.BackgroundImageLayout = ImageLayout.Stretch;

                    if (i < 3)
                    {
                        w += 89;
                    }

                    if (i > 3 && i < 9)
                    {
                        w -= 89;
                    }

                    if (i > 9 && i < 15)
                    {
                        w += 89;
                    }

                    if (i > 15 && i < 21)
                    {
                        w -= 89;
                    }

                    if (i > 21 && i < 27)
                    {
                        w += 89;
                    }

                    if (i > 27 && i < 33)
                    {
                        w -= 89;
                    }

                    if (i > 33)
                    {
                        w += 89;
                    }

                    if (i == 3 || i == 9 || i == 15 || i == 21 || i == 27 || i == 33)
                    {
                        h -= 93;
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
                panelCartas.Visible = true;
                int w = 4, h = 39;

                List<Carta> cartas = new List<Carta>();
                cartas = this.game.consultarMao(this.meuJogador);
                cartas = atualizarImgCartas(cartas);

                for (int i = 0; i < cartas.Count; i++)
                {
                    PictureBox p = new PictureBox();
                    panelCartas.Controls.Add(p);

                    p.Location = new System.Drawing.Point(w, h);
                    p.Width = 79;
                    p.Height = 121;

                    p.BackgroundImage = cartas[i].Img;
                    p.BackgroundImageLayout = ImageLayout.Stretch;

                    w += 40;
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            } 
        }

        private List<Tabuleiro> atualizarImgPosicoes(List<Tabuleiro> l)
        {
            foreach (Tabuleiro t in l)
            {
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

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void tmrViewJogadores_Tick(object sender, EventArgs e)
        {
            preencherDataGridJogadoresView();
        }
    }
}
