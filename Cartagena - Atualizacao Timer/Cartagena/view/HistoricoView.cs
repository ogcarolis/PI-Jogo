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
        List<Jogador> jogadores;
        Partida partida;
        Game game;

        public HistoricoView(Partida p, List<Jogador> jogadores)
        {
            InitializeComponent();

            this.partida = new Partida();
            this.partida = p;

            this.game = new Game();

            this.jogadores = new List<Jogador>();
            this.jogadores = jogadores;
            
            tmrHistorico.Enabled = true;
            exibirHistorico();
        }

        private void exibirHistorico()
        {
            List<string> historico = new List<string>();
            historico = this.game.exibirHistorico(this.partida.Id, this.jogadores);

            if(historico != null)
            {
                int x = 3, y = 2;
                int w = 287, h;
                panelHistorico.Controls.Clear();

                panelHistorico.AutoScroll = false;
                panelHistorico.HorizontalScroll.Enabled = false;
                panelHistorico.HorizontalScroll.Visible = false;
                panelHistorico.HorizontalScroll.Maximum = 0;
                panelHistorico.AutoScroll = true;

                for (int i = 0; i < historico.Count; i++)
                {
                    Label l = new Label();
                    l.Location = new Point(x, y);

                    if (historico[i].Contains("pulou a vez") || historico[i].Contains("iniciou a partida"))
                    {
                        h = 19;
                    }
                    else
                    {
                        h = 32;
                    }

                    l.Size = new System.Drawing.Size(w, h);
                    l.BackColor = System.Drawing.Color.Transparent;
                    l.FlatStyle = System.Windows.Forms.FlatStyle.Flat;

                    l.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
                    l.TextAlign = System.Drawing.ContentAlignment.TopCenter;
                    l.Text = historico[i];

                    foreach (Jogador j in this.jogadores)
                    {
                        if (historico[i].StartsWith(j.Nome))
                        {
                            l.ForeColor = j.ColorPirata;
                        }
                    }

                    panelHistorico.Controls.Add(l);
                    y += h;
                }
            }
        }

        private void tmrHistorico_Tick(object sender, EventArgs e)
        {
            exibirHistorico();
        }
    }
}
