using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace Cartagena{
    public class Game {

        public string criarPartida(string nome, string senha) 
        {
            string retorno = Jogo.CriarPartida(nome, senha);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            return retorno;
        }

        public Jogador entrarPartida(int id, string nome, string senha)
        {
            string retorno = Jogo.EntrarPartida(id, nome, senha);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            string[] infoJogador = retorno.Split(',');

            Jogador j = new Jogador();
            j.Nome = nome;
            j.Id = int.Parse(infoJogador[0]);
            j.Senha = infoJogador[1];
            j.Cor = infoJogador[2];

            return j;
        }

        public string iniciarPartida(Jogador j)
        {
           string retorno = Jogo.IniciarPartida(j.Id, j.Senha);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            return retorno;
        }

        public List<Carta> consultarMao(Jogador j) 
        { 
            List<Carta> cartas = new List<Carta>();
            string retorno = Jogo.ConsultarMao(j.Id, j.Senha);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            retorno = retorno.Replace("\r", "");
            string[] qtdCartas = retorno.Split('\n');

            for (int i = 0; i < qtdCartas.Length - 1; i++) {
                string[] itens = qtdCartas[i].Split(',');

                for (int l = 0; l < int.Parse(itens[1]); l++)
                {
                    Carta c = new Carta();
                    c.Simbolo = itens[0];
                    cartas.Add(c);
                }
            }

            return cartas;
        }

        public Jogador verificaVez(List<Jogador> jogadores, int id)
        {
            Jogador jVez = new Jogador();
            string retorno = Jogo.VerificarVez(id);

            if (retorno.StartsWith("ERRO"))
            {
                return null;
            }

            retorno = retorno.Replace("\r", "");
            string[] info = retorno.Split('\n');

            string[] jogador = info[0].Split(',');

            foreach (Jogador j in jogadores)
            {
                if (j.Id == int.Parse(jogador[1]))
                {
                    j.Jogadas = int.Parse(jogador[2]);
                    j.Status = "Sua Vez";
                    jVez = j;
                }
            }

            return jVez;
        }

        public void moverPirata(Jogador j, int posicao, string simbolo)
        {
            string retorno = Jogo.Jogar(j.Id, j.Senha, posicao, simbolo);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }
        }

        public void voltarPirata(Jogador j, int posicao)
        {
            string retorno = Jogo.Jogar(j.Id, j.Senha, posicao);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }
        }

        public void pularVez(Jogador j)
        {
            string retorno = Jogo.Jogar(j.Id, j.Senha);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }
        }

        public List<Partida> exibirPartidas(string status)
        {
            List<Partida> partidas = new List<Partida>();
            string retorno = Jogo.ListarPartidas(status);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            retorno = retorno.Replace("\r", "");
            string[] partida = retorno.Split('\n');

            for (int i = 0; i < partida.Length - 1; i++)
            {
                string[] infoPartidas = partida[i].Split(',');

                Partida p = new Partida();
                p.Id = int.Parse(infoPartidas[0]);
                p.Nome = infoPartidas[1];
                p.DtCriacao = infoPartidas[2];
                p.Status = infoPartidas[3];
                partidas.Add(p);

            }

            return partidas;
        }

        public List<Jogador> exibirJogadores(int id)
        {
            List<Jogador> jogadores = new List<Jogador>();
            string retorno = Jogo.ListarJogadores(id);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            retorno = retorno.Replace("\r", "");
            string[] jogador = retorno.Split('\n');
           
            for (int i = 0; i < jogador.Length - 1; i++)
            {
                string[] infojogadores = jogador[i].Split(',');

                Jogador j = new Jogador();
                j.Id = int.Parse(infojogadores[0]);
                j.Nome = infojogadores[1];
                j.Cor = infojogadores[2];
                j.Status = "Aguardando Partida";
                jogadores.Add(j);
            }

            return jogadores;
        }

        public List<Elemento> exibirTabuleiro(int id)
        {
            List<Elemento> pTabuleiro = new List<Elemento>();
            string retorno = Jogo.ExibirTabuleiro(id);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            retorno = retorno.Replace("\r", "");
            string[] posicao = retorno.Split('\n');

            for (int i = 0; i < posicao.Length - 1; i++)
            {
                string[] infoPosicao = posicao[i].Split(',');

                Elemento t = new Elemento();
                t.Posicao = int.Parse(infoPosicao[0]);
                t.Simbolo = infoPosicao[1];
                pTabuleiro.Add(t);
            }

            return pTabuleiro;
        }
        
        public List<Elemento> exibirPiratas(int id, List<Elemento> tabuleiro, List<Jogador> jogadores) 
        {
            string retorno = Jogo.VerificarVez(id);

            if (retorno.StartsWith("ERRO"))
            {
                throw new Exception(retorno.Substring(5));
            }

            retorno = retorno.Replace("\r", "");
            string[] info = retorno.Split('\n');
            
            foreach (Elemento e in tabuleiro) {
                e.Piratas.Clear();
            }

            for (int i = 1; i < info.Length - 1; i++)
            {
                string[] infoPirata = info[i].Split(',');

                for(int l = 0; l < int.Parse(infoPirata[2]); l++)
                {
                    Pirata p = new Pirata();
                    p.Posicao = int.Parse(infoPirata[0]);

                    foreach (Jogador j in jogadores)
                    {
                        if (j.Id == int.Parse(infoPirata[1]))
                        {
                            p.Jogador = j;
                        }
                    }

                    tabuleiro[p.Posicao].Piratas.Add(p);
                }
            }

            return tabuleiro;
        }
    }
}
