using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Pirata {
        int posicao;
        Image img;

        public int Posicao
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
