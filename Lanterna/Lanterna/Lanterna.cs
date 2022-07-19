using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna
{
    class Lanterna
    {
        public bool Ligada { get; private set; }
        public Bateria Bateria { get; private set; }

        public Lanterna()
        {
            Ligada = false;
            Bateria = new Bateria();
        }

        public void Ligar()
        {
            Ligada = true;
        }

        public void Desligar()
        {
            Ligada = false;
        }
    }
}
