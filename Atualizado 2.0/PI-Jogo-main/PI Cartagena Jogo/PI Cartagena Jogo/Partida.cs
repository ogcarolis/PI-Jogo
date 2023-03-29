using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cartagena_Jogo
{
    public class Partida
    {
        public int id;
        public string nomePartida;
        public string dataCriacao;
        public string status;

        public Partida(int id, string nomePartida, string dataCriacao, string status)
        {
            this.id = id;
            this.nomePartida = nomePartida;
            this.dataCriacao= dataCriacao;
            this.status = status;
        }

        public string toString()
        {
            return "Id:" + this.id + " Nome: " + this.nomePartida + " Status: " + this.status;
        }
    }
}
