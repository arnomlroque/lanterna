using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lanterna
{
    class Bateria
    {
        public int Porcentagem { get; private set; }

        public Bateria()
        {
            Porcentagem = 100;
        }

        public void Descarregar()
        {
            if (Porcentagem > 0)
            {
                Porcentagem--;
            }
        }

        public void Trocar()
        {
            Porcentagem = 100;
        }
    }
}
