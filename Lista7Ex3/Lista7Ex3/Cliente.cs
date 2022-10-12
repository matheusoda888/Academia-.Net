using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex3
{
    internal class Cliente
    {
        public string nome;
        public string id;
        public Cliente(string nome, string id)
        {
            this.nome = nome;
            this.id = id;
        }
        public string getNome()
        {
            return nome;
        }
        public string getId()
        {
            return id;
        }
    }
}
