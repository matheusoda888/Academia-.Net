using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex1
{
    internal class Personagem
    {
        public string nome;
        public int poder;
        public Personagem(string nome, int poder)
        {
            this.nome = nome;
            this.poder = poder;
        }
        public Personagem()
        {

        }
        public void exibirDados(Personagem personagem)
        {
            Console.WriteLine(personagem.nome);
            Console.WriteLine(personagem.poder);
        }
    }
}
