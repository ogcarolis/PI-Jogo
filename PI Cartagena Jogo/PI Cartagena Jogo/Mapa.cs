using CartagenaServer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Cartagena_Jogo
{
    public partial class Mapa : Form
    {
        public Mapa()
        {
            InitializeComponent();
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void picAzul4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cartasTabuleiro(object sender, EventArgs e)
        {
            private void btnExibirMao_Click_1(object sender, EventArgs e)
            {
                string jogadorSelecionado = lstJogadores.SelectedItem.ToString();
                string[] itens = jogadorSelecionado.Split(',');

                idJogador = Convert.ToInt32(itens[0]);
                senhaJogador = txtSenhaJogador.Text;

                consultarMao();
            }

            public void consultarMao()
            {
                List<string> cartas = new List<string>();

                string retorno = Jogo.ConsultarMao(idJogador, senhaJogador);
                retorno = retorno.Replace("\r", "");
                string[] qtdCartas = retorno.Split('\n');

                for (int i = 0; i < qtdCartas.Length - 1; i++)
                {
                    string[] itens = qtdCartas[i].Split(',');
                    for (int l = 0; l < Convert.ToInt32(itens[1]); l++)
                    {
                        cartas.Add(itens[0]);
                    }
                }

                List<PictureBox> pics = new List<PictureBox>();
                pics.Add(this.picCarta1);
                pics.Add(this.picCarta2);
                pics.Add(this.picCarta3);
                pics.Add(this.picCarta4);
                pics.Add(this.picCarta5);
                pics.Add(this.picCarta6);

                for (int i = 0; i < pics.Count; i++)
                {
                    if (cartas[i] == "P")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaArma;
                    }

                    if (cartas[i] == "E")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaBandeira;
                    }

                    if (cartas[i] == "C")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaChave;
                    }

                    if (cartas[i] == "F")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaEspada;
                    }

                    if (cartas[i] == "G")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaGarrafa;
                    }

                    if (cartas[i] == "T")
                    {
                        pics[i].BackgroundImage = PI_Cartagena_Jogo.Properties.Resources.cartaTricornio;
                    }
                }

                panelCartas.Visible = true;
            }
        }
    }
}
