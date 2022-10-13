using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex7
{
    internal class Elevador
    {
        public int andar=0;
        public int andarMax;
        public int pessoas=0;
        public int pessoasMax;
        public Elevador( int andarMax, int pessoasMax)
        {
            
            this.andarMax = andarMax;
            
            this.pessoasMax = pessoasMax;
        }
        public void entra()
        {
            if (pessoas < pessoasMax) { 
            this.pessoas++;
            }
        }
        public void sai()
        {
            if (pessoas > 0)
            {
                this.pessoas--;
            }
        }
        public void sobe()
        {
            if (andar < andarMax)
            {
                andar++;
            }
        }
        public void desce()
        {
            if (andar > 0)
            {
                andar--;
            }

        }
        public void imprimirInfo()
        {
            Console.WriteLine(andarMax + " andares");
            Console.WriteLine(andar + " andar atualmente");
            Console.WriteLine(pessoas + " pessoas atualmente");
            Console.WriteLine(pessoasMax + " de capacidade máxima");
        }
    }
}
