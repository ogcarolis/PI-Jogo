using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cartagena_Jogo
{
    public class Jogador
    {
        public int id;
        public string nome;
        public string senha;
        public string cor;
        List<Carta> cartas;

        public Jogador(int id, string nome, string senha, string cor) { 
            this.cartas = new List<Carta>(); 
            this.id = id;
            this.nome = nome;
            this.senha = senha;
            this.cor = cor;
        }

        public string toString()
        {
            return "Id: " + this.id + " Nome: " + this.nome + " Cor: " + this.cor;
        }


    }
}
