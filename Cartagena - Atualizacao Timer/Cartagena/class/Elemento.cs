using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Elemento {
        string simbolo;
        int posicao;
        int x, y;
        int w, h; 

        List<Pirata> piratas;
        Image img;

        public Elemento()
        {
            this.piratas = new List<Pirata>();
        }

        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

        public int Posicao
        {
            get { return posicao; }
            set { posicao = value; }
        }

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int W
        {
            get { return w; }
            set { w = value; }
        }

        public int H
        {
            get { return h; }
            set { h = value; }
        }

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }

        public List<Pirata> Piratas
        {
            get { return piratas; }
            set { piratas = value; }
        }
    }
}
