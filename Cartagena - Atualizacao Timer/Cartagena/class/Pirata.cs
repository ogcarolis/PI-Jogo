using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Pirata {
        Jogador jogador;
        int posicao;

        public Jogador Jogador
        {
            get { return jogador; }
            set { jogador = value; }
        }

        public int Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

    }
}
