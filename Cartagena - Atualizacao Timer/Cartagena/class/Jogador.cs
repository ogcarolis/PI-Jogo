using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Jogador {
        int id;
        int jogadas;
        string nome;
        string senha;
        string cor;
        string status;
        Image imgPirata;

        public Image ImgPirata
        {
            get { return imgPirata; }
            set { imgPirata = value; }
        }

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

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public int Jogadas
        {
            get { return jogadas; }
            set { jogadas = value; }
        }


    }
}
