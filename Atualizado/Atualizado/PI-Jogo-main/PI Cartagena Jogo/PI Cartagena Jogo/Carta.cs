using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cartagena_Jogo
{
    public class Carta
    {
        public string sigla;
        public Image img;

        public Carta(string sigla, Image img)
        { 
            this.sigla = sigla;
            this.img = img; 
        }
    }
}
