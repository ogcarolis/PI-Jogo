using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        int idPartida;
        string senhaJogador;

        private void btnVerPartidas_Click(object sender, EventArgs e)
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

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            string nome = txtNomeJogador.Text;
            string senha = txtSenhaPE.Text;            

            string partida = lstListaPartidas.SelectedItem.ToString();
            string[] itens = partida.Split(',');           

            idPartida = Convert.ToInt32(itens[0]);
            string nomePartida = itens[1];
            string dataPartida = itens[2];
            string status = itens[3];             

            string retorno = Jogo.EntrarPartida(idPartida, nome, senha);

            lblInformacao.Text = "Partida: " + nomePartida + "\nId: " + idPartida.ToString() + "\nInformações: " + retorno;
                 
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.CriarPartida(txtNomePartida.Text, txtSenhaPartida.Text);

            lblPartidaInformacao.Text = "Partida criada!\nId da partida: " + retorno;
        }

        private void btnExibirMao_Click(object sender, EventArgs e)
        {
           
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
            string jogadorSelecionado = lstJogadores.SelectedItem.ToString();
            string[] itens = jogadorSelecionado.Split(',');

            idJogador = Convert.ToInt32(itens[0]);
            senhaJogador = txtSenhaJogador.Text;

            string retorno = Jogo.IniciarPartida(idJogador, senhaJogador);

            lblInicio.Text = "Jogador que inicia: \n " + retorno;                      

            lblCartasTexto.Text = Jogo.ConsultarMao(idJogador, senhaJogador).ToString();

            panelCartas.Visible = true;           
        }
    }
}
