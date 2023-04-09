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
    public partial class CadastrarPartidaView : Form
    {
        Game game;
        public CadastrarPartidaView()
        {
            InitializeComponent();
            game = new Game();
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            try
            {
                string retorno = this.game.criarPartida(txtNomePartida.Text, txtSenhaPartida.Text);
                enviaMsg("Partida Criada! Id: " + retorno, "check");
                this.Close();
            }
            catch (Exception e1)
            {
                enviaMsg(e1.Message, "erro");
            }   
        }

        private void enviaMsg(String msg, String tipo)
        {
            MensagensView message = new MensagensView(msg, tipo);
            message.ShowDialog();
        }
    }
}
