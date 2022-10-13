using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex8
{
    internal class Controle
    {
        Televisao televisao;

        public void aumentarVolume(Televisao televisao)
        {
            if (televisao.volume < 100)
            {
                televisao.volume++;
            }
        }
        public void diminuirVolume(Televisao televisao)
        {
            if (televisao.volume > 0)
            {
                televisao.volume--;
            }
        }
        public void aumentarCanal(Televisao televisao)
        {
            televisao.canal++;
        }
        public void diminuirCanal(Televisao televisao)
        {
            televisao.canal--;
        }
        public void imprimir(Televisao televisao)
        {
            Console.WriteLine("canal atual: " + televisao.canal);
            Console.WriteLine("volume atual: " + televisao.volume);

        }
    }
}
