using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex5
{
    internal class Objeto
    {
        int x, y;
        string descricao;
        public Objeto()
        {
            
        }
        public Objeto(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.descricao = "sem descricao";
        }
        public void setX(int valor)
        {
            x = valor;
        }
        public void setY(int valor)
        {
            y = valor;
        }
        public int getX() { return x; }
        public int getY() { return y; }

        public void exibirObjeto()
        {
            
            Console.WriteLine("("+x + "," + y+")");
        }
    }
}
