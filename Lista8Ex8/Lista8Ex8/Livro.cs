using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex8
{
    internal class Livro
    {
        string nome;
        int paginas;
        public Livro(string nome, int paginas)
        {
            this.nome = nome;
            this.paginas = paginas;
        }
        public string getNome()
        {
            return nome;
        }
        public int getPaginas()
        {
            return paginas;
        }
        public void exibirLivro()
        {
            Console.WriteLine("Nome: "+nome);
            Console.WriteLine("Paginas: "+paginas);
        }
        
    }
}
