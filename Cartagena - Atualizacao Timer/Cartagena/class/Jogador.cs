using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Jogador {
        int id;
        string nome;
        string senha;
        string cor;
        bool minhaVez;
        int qtdJogadas;

        List<Pirata> piratas;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

        public string Cor
        {
            get { return cor; }
            set { cor = value; }
        }

        public bool MinhaVez
        {
            get { return minhaVez; }
            set { minhaVez = value; }
        }

        public int QtdJogadas
        {
            get { return qtdJogadas; }
            set { qtdJogadas = value; }
        }

        public List<Pirata> Piratas
        {
            get { return piratas; }
            set { piratas = value; }
        }
    }
}
