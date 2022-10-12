using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7
{
    internal class Livro
    {
        public string nome;
        public string genero;
        public int paginas;

        public Livro(string nome, string genero, int paginas)
        {
            this.nome = nome;
            this.genero = genero;
            this.paginas = paginas;
        }


    }
}
