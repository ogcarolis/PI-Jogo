using CartagenaServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Cartagena
{
    public class Estrategia
    {
        Game game;

        List<KeyValuePair<string, int>> figDisponiveis;
        List<KeyValuePair<string, int>> cartasDisponiveis;

        public Estrategia()
        {
            this.game = new Game();

            this.figDisponiveis = new List<KeyValuePair<string, int>>();
            this.cartasDisponiveis = new List<KeyValuePair<string, int>>();
        }

        public void iniciarJogada(Jogador j, List<Pirata> piratas, List<Carta> cartas, List<Elemento> tabuleiro)
        {
            try
            {
                bool boaJogada = false;
                bool boaJogada2 = false;
                bool jogou = false;

                Carta cartaJogavel = new Carta();
                cartaJogavel.Simbolo = "";

                analiseCartas(cartas);

                if (cartas.Count < analisePosicoes(piratas, 30, 37))
                {
                    if (cartas.Count <= 2)
                    {
                        jogou = analiseReceberCartas(j, piratas, tabuleiro, 2);

                        if (!jogou)
                        {
                            jogou = analiseReceberCartas(j, piratas, tabuleiro, 1);
                        }
                    }
                }

                if (!jogou)
                {
                    foreach (Pirata pirata in piratas)
                    {
                        analiseFigTabuleiro(pirata.Posicao, tabuleiro);

                        if (!boaJogada && !boaJogada2)
                        {
                            foreach (var carta in this.cartasDisponiveis)
                            {
                                if (carta.Value > 0 && !boaJogada && !boaJogada2)
                                {
                                    foreach (var figura in this.figDisponiveis)
                                    {
                                        if (figura.Key == carta.Key)
                                        {
                                            if (figura.Value == 0)
                                            {
                                                cartaJogavel.Simbolo = carta.Key;
                                                boaJogada = true;
                                                break;
                                            }
                                            else if (carta.Value >= figura.Value || carta.Value > 1)
                                            {
                                                cartaJogavel.Simbolo = carta.Key;
                                                boaJogada2 = true;
                                            }
                                            else if (carta.Value < figura.Value && !boaJogada2)
                                            {
                                                int melhorPos = pirata.Posicao + 1;
                                                cartaJogavel.Simbolo = carta.Key;

                                                for (int i = pirata.Posicao + 1; i <= pirata.Posicao + 6; i++)
                                                {
                                                    if (melhorPos >= tabuleiro[melhorPos + 1].Posicao)
                                                    {
                                                        cartaJogavel.Simbolo = carta.Key;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }

                        }

                        if (pirata.Posicao >= 0 && cartaJogavel.Simbolo != "")
                        {
                            this.game.moverPirata(j, pirata.Posicao, cartaJogavel.Simbolo);
                            jogou = true;
                            break;
                        }
                    }

                    if (!jogou)
                    {
                        if (cartas.Count <= 6)
                        {
                            jogou = analiseReceberCartas(j, piratas, tabuleiro, 2);
                        }
                        else 
                        {
                            this.game.pularVez(j);
                        }

                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private int analisePosicoes(List<Pirata> piratas, int posI, int posF)
        {
            int qtdPiratas = 0;

            foreach(Pirata pirata in piratas)
            {
                if(pirata.Posicao > posI && pirata.Posicao < posF)
                {
                    qtdPiratas++;
                }
            }

            return qtdPiratas;
        }

        private bool analiseReceberCartas(Jogador j, List<Pirata> piratas, List<Elemento> tabuleiro, int qtdCartas)
        {
            if(qtdCartas == 1)
            {
                piratas.Reverse();
            }

            foreach (Pirata pirata in piratas)
            {
                for (int i = pirata.Posicao - 1; i >= 1; i--)
                {
                    if (tabuleiro[i].Piratas.Count == qtdCartas)
                    {
                        this.game.voltarPirata(j, pirata.Posicao);
                        return true;
                    }
                }
            }
         
            return false;
        }

        private void analiseCartas(List<Carta> cartas)
        {
            Dictionary<string, int> dicCartas = criaDicFiguras();

            foreach(Carta c in cartas) 
            {
                dicCartas[c.Simbolo]++;
            }

            this.cartasDisponiveis = dicCartas.OrderByDescending(x => x.Value).ToList();
        }

        private int analiseFigTabuleiro(int posicao, List<Elemento> tabuleiro)
        {
            int qtdPosicoes = 0;
            Dictionary<string, int> dicFiguras = criaDicFiguras();

            for (int i = posicao + 1; i < tabuleiro.Count - 1; i++)
            {
                if (tabuleiro[i].Piratas.Count == 0)
                {
                    dicFiguras[tabuleiro[i].Simbolo]++;
                    qtdPosicoes++;
                }
            }

            this.figDisponiveis = dicFiguras.OrderBy(x => x.Value).ToList();
            return qtdPosicoes;
        }

        private Dictionary<string, int> criaDicFiguras()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("C", 0);
            dic.Add("E", 0);
            dic.Add("F", 0);
            dic.Add("T", 0);
            dic.Add("P", 0);
            dic.Add("G", 0);

            return dic;
        }

    }
}
