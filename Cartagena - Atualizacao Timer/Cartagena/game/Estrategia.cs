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
                bool voltou = false;

                Carta cartaJogavel = new Carta();
                analiseCartas(cartas);
  
                if(cartas.Count <= 2 && analiseFigTabuleiro(piratas[0].Posicao, tabuleiro) > cartas.Count)
                {
                    voltou = analiseReceberCartas(j, piratas, tabuleiro, 1);
                }

                if (!voltou)
                {
                    foreach (Pirata pirata in piratas)
                    {
                        analiseFigTabuleiro(pirata.Posicao, tabuleiro);

                        foreach (var carta in this.cartasDisponiveis)
                        {
                            if (carta.Value > 0 && !boaJogada)
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
                                        else if (carta.Value >= figura.Value)
                                        {
                                            cartaJogavel.Simbolo = carta.Key;
                                            boaJogada = true;
                                            break;
                                        }
                                        else if (carta.Value < figura.Value)
                                        {
                                            cartaJogavel.Simbolo = carta.Key;
                                        }
                                    }
                                }
                            }
                        }

                        if (!boaJogada && analiseFigTabuleiro(piratas[0].Posicao, tabuleiro) > cartas.Count && cartas.Count < 4)
                        {
                            voltou = analiseReceberCartas(j, piratas, tabuleiro, 2);

                            if (voltou)
                            {
                                break;
                            }
                        }

                        if (pirata.Posicao >= 0 && cartaJogavel.Simbolo != "")
                        {
                            this.game.moverPirata(j, pirata.Posicao, cartaJogavel.Simbolo);
                            voltou = true;
                            break;
                        }
                        else
                        {
                            this.game.pularVez(j);
                            break;
                        }

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool analiseReceberCartas(Jogador j, List<Pirata> piratas, List<Elemento> tabuleiro, int qtdCartas)
        {
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
