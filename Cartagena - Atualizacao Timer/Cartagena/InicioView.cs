using Cartagena.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cartagena
{
    public partial class InicioView : Form
    {
        Game game;
        Jogador meuJogador;
        Partida partidaSelecionada;
        public InicioView()
        {
            InitializeComponent();

            try
            {
                this.game = new Game();
                this.meuJogador = new Jogador();
                this.partidaSelecionada = new Partida();

                tmrJogador.Enabled = true;
                tmrPartida.Enabled = true;

                preencherDataGridView();
            }
            catch (Exception e)
            {
                enviaMsg(e.Message, "erro");
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                CadastrarPartidaView c = new CadastrarPartidaView();
                c.ShowDialog();
                preencherDataGridView();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
            
        }

        private void dtgPartidas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow row = this.dtgPartidas.Rows[e.RowIndex];

                    this.partidaSelecionada.Id = int.Parse(row.Cells["Id"].Value.ToString());
                    this.partidaSelecionada.Nome = row.Cells["Nome"].Value.ToString();
                    this.partidaSelecionada.Status = row.Cells["Status"].Value.ToString();
                    this.partidaSelecionada.DtCriacao = row.Cells["DtCriacao"].Value.ToString();
                    this.partidaSelecionada.Iniciou = false;

                    lblNomePartida.Text = "Partida Selecionada: " + this.partidaSelecionada.Nome;

                    preencherDataGridJogadoresView();
                    panelEntrar.Visible = true;             
                }
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                this.meuJogador = this.game.entrarPartida(this.partidaSelecionada.Id, txtNome.Text, txtSenha.Text);
                enviaMsg(this.meuJogador.Nome + " entrou na partida!", "check");
                limparDados(); 

                PartidaView p = new PartidaView(this.partidaSelecionada, this.meuJogador);
                p.ShowDialog();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }
           
        }

        private void limparDados()
        {
            panelEntrar.Visible = false;
            dtgJogadores.Visible = false;

            lblNomePartida.Text = "Partida Selecionada: ";
            txtNome.Text = "";
            txtSenha.Text = "";
        }

        private void preencherDataGridView()
        {
            List<Partida> partidas = new List<Partida>();
            partidas = this.game.exibirPartidas("A");

            dtgPartidas.Columns.Clear();
            dtgPartidas.DataSource = partidas;

            dtgPartidas.Columns["Id"].Width = 85;
            dtgPartidas.Columns["Nome"].Width = 185;

            dtgPartidas.Columns["Status"].Visible = false;
            dtgPartidas.Columns["Iniciou"].Visible = false;
            dtgPartidas.Columns["DtCriacao"].Visible = false;

            dtgPartidas.Refresh();
        }

        private void preencherDataGridJogadoresView()
        {
            List<Jogador> jogadores = new List<Jogador>();
            jogadores = this.game.exibirJogadores(this.partidaSelecionada.Id);

            dtgJogadores.Visible = true;
            dtgJogadores.Columns.Clear();
            dtgJogadores.DataSource = jogadores;

            dtgJogadores.Columns["Id"].Width = 63;
            dtgJogadores.Columns["Nome"].Width = 110;
            dtgJogadores.Columns["Cor"].Width = 110;

            dtgJogadores.Columns["Senha"].Visible = false;
            dtgJogadores.Columns["Status"].Visible = false;
            dtgJogadores.Columns["Jogadas"].Visible = false;
            dtgJogadores.Columns["ImgPirata"].Visible = false;

            dtgJogadores.Refresh();

        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }

        private void tmrPartida_Tick(object sender, EventArgs e)
        {
            preencherDataGridView();
        }

        private void tmrJogador_Tick(object sender, EventArgs e)
        {
            if(this.partidaSelecionada != null && dtgJogadores.Visible == true) {
                preencherDataGridJogadoresView();
            }
        }
    }
}
