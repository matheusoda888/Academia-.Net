using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9Ex3
{
    internal class Figurinha
    {
        public string codigo_figurinha { get; set; }
        public string selecao { get; set; }
        public string nome_jogador { get; set; }

        public Figurinha(string codigo_figurinha, string selecao, string nome_jogador)
        {
            this.codigo_figurinha = codigo_figurinha;
            this.selecao = selecao;
            this.nome_jogador = nome_jogador;
        }

    }
}
