using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Tabuleiro {
        string simbolo;
        string posicao;
        Image img;

        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

        public string Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
