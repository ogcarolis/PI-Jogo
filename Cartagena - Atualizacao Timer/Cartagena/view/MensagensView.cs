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
    public partial class MensagensView : Form
    {
        string tipo;
        public MensagensView(string msg, string tipo)
        {
            InitializeComponent();

            this.tipo = tipo;
            lbl_msg.Text = msg;

            verificaTipoMsg();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void verificaTipoMsg()
        {
            switch (this.tipo)
            {
                case "erro":
                    pic_info.BackgroundImage = Properties.Resources.icon_erro;
                    break;
                case "aviso":
                    pic_info.BackgroundImage = Properties.Resources.icon_aviso;
                    break;
                case "check":
                    pic_info.BackgroundImage = Properties.Resources.icon_check;
                    break;
                default:
                    break;
            }
        }
    }
}
