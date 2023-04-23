using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena.view
{
    public partial class HistoricoView : Form
    {
        int idPartida;
        List<Jogador> jogadores;
        Game game;

        public HistoricoView(int id, List<Jogador> jogadores)
        {
            InitializeComponent();

            this.game = new Game();
            this.jogadores = new List<Jogador>();

            this.jogadores = jogadores;
            this.idPartida = id;
            
            exibirHistorico();
        }

        private void exibirHistorico()
        { 
            lbHistorico.Items.Clear();

            List<string> historico = new List<string>();
            historico = this.game.exibirHistorico(this.idPartida, this.jogadores);

            foreach(string l in historico)
            {
                lbHistorico.Items.Add(l);
            }
        }

        private void tmrHistorico_Tick(object sender, EventArgs e)
        {
            exibirHistorico();
        }
    }
}
