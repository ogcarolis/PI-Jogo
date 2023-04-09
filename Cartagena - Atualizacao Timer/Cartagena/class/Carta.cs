using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cartagena {
    public class Carta {
        string simbolo;
        Image img;

        public string Simbolo
        {
            get { return simbolo; }
            set { simbolo = value; }
        }

        public Image Img
        {
            get { return img; }
            set { img = value; }
        }
    }
}
