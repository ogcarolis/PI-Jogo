﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Partida {
        int id;
        string nome;
        string status;
        string dtCriacao;
        bool iniciou;

        public int Id {
            get { return id; }
            set { id = value; }
        }

        public string Nome {
            get { return nome; }
            set { nome = value; }
        }

        public string Status {
            get { return status; }
            set { status = value; }
        }

        public string DtCriacao
        {
            get { return dtCriacao; }
            set { dtCriacao = value; }
        }

        public bool Iniciou
        {
            get { return iniciou; }
            set { iniciou = value; }
        }

    }
}
