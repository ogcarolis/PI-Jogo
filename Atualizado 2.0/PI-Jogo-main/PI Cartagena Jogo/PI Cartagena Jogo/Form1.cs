using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CartagenaServer;

namespace PI_Cartagena_Jogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int idJogador;
        string senhaJogador;

        int idPartida;
        string nomePartida;
        string dataPartida;
        string status;

        string cartaEscolhida;
        int posicaoPirata;

        private void btnVerPartidas_Click(object sender, EventArgs e)
        {
            listarPartidas();
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJogador.Text;
            string senha = txtSenhaPE.Text;            
            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);

            lblInformacao.Text = "Partida: " + nomePartida + " Id: " + idPartida.ToString() + "\nInformações: " + retorno;
            MessageBox.Show(retorno);
                 
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
            lblPartidaInformacao.Text = "Partida criada! Id da partida: " + retorno;
            listarPartidas();
        }

        private void btnExibirJogadores_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] jogadores = retorno.Split('\n'); 

            lstJogadores.Items.Clear();

            for (int i = 0; i < jogadores.Length; i++)
            {
                lstJogadores.Items.Add(jogadores[i]);
            }
           
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            senhaJogador = txtSenhaJogador.Text;

            string retorno = Jogo.IniciarPartida(idJogador, senhaJogador);
            lblInicio.Text = "Jogador que inicia: " + retorno;            

            consultarMao();
            atualizarCartasCBO();
            tabuleiroAtualizar();
        }

        private void btnExibirMao_Click_1(object sender, EventArgs e)
        {
            string jogadorSelecionado = lstJogadores.SelectedItem.ToString();
            string[] itens = jogadorSelecionado.Split(',');

            idJogador = Convert.ToInt32(itens[0]);
            senhaJogador = txtSenhaJogador.Text;           

            consultarMao();
            atualizarCartasCBO();
            tabuleiroAtualizar();
        }

        public void consultarMao()
        {
            List<string> cartas = new List<string>();

            string retorno = Jogo.ConsultarMao(idJogador, senhaJogador);
            MessageBox.Show(retorno);
            retorno = retorno.Replace("\r", "");
            string[] qtdCartas = retorno.Split('\n');

            for (int i = 0; i < qtdCartas.Length - 1; i++){
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

            for (int i = 0; i < cartas.Count; i++)
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

        private void lstListaPartidas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstListaPartidas.SelectedItem.ToString();
            string[] itens = partida.Split(',');

            idPartida = Convert.ToInt32(itens[0]);
            nomePartida = itens[1];
            dataPartida = itens[2];
            status = itens[3];
        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {
            string jogadorSelecionado = lstJogadores.SelectedItem.ToString();
            string[] itens = jogadorSelecionado.Split(',');

            idJogador = Convert.ToInt32(itens[0]);
        }

        public void listarPartidas()
        {
            string retorno = Jogo.ListarPartidas("T");

            retorno = retorno.Replace("\r", "");
            string[] partidas = retorno.Split('\n');

            lstListaPartidas.Items.Clear();

            for (int i = 0; i < partidas.Length; i++)
            {
                lstListaPartidas.Items.Add(partidas[i]);
            }
        }

        private void cboCartas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnJogarCarta_Click(object sender, EventArgs e)
        {

            string jogadorSelecionado = lstJogadores.SelectedItem.ToString();
            string[] itens = jogadorSelecionado.Split(',');            

            idJogador = Convert.ToInt32(itens[0]);
            senhaJogador = txtSenhaJogador.Text;
            cartaEscolhida = cboCartas.SelectedItem.ToString();
            posicaoPirata = Convert.ToInt32(txtEscolhaPirata.Text);

            if (cartaEscolhida == "Pular")
            {
                Jogo.Jogar(idJogador, senhaJogador);
                lblJogou.Text = "Jogador: " + itens[0] + "Pulou a vez!";
            }            
            else if(cartaEscolhida == "Voltar Pirata")
            {
                string retorno = Jogo.Jogar(idJogador, senhaJogador, posicaoPirata);
                MessageBox.Show(retorno);
                lblJogou.Text = "Jogador: " + itens[0] + "\nVoltou o pirata da posição: " + posicaoPirata.ToString();
            }
            else
            {
                Jogo.Jogar(idJogador, senhaJogador, posicaoPirata, cartaEscolhida);
                lblJogou.Text = "Jogador: " + itens[0] + "\nMoveu o pirata " + posicaoPirata.ToString() + " para " + cartaEscolhida.ToString();
            }

            tabuleiroAtualizar();
            atualizarCartasCBO();
            consultarMao();
        }

        public void tabuleiroAtualizar()
        {
            lblTabuleiro.Text = Jogo.ExibirTabuleiro(idPartida);
        }

        public void atualizarCartasCBO()
        {                     

            List<string> cartas = new List<string>();

            string retorno = Jogo.ConsultarMao(idJogador, senhaJogador);

            retorno = retorno.Replace("\r", "");
            string[] qtdCartas = retorno.Split('\n');

            cboCartas.Items.Clear();
            cboCartas.Items.Add("Pular");
            cboCartas.Items.Add("Voltar Pirata");

            for (int i = 0; i < qtdCartas.Length - 1; i++)
            {
                string[] itens = qtdCartas[i].Split(',');
                for (int l = 0; l < Convert.ToInt32(itens[1]); l++)
                {
                    cartas.Add(itens[0]);
                }
            }

            for (int i = 0; i < cartas.Count; i++)
            {
                cboCartas.Items.Add(cartas[i]);
            }
        }
    }
}
