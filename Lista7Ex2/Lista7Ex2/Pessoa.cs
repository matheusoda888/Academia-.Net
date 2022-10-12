using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex2
{
    internal class Pessoa
    {
        public string nome;
        public int idade;
        public string sexo;
        public Pessoa(string nome, int idade, string sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }
        public string getNome() { 
            return nome;
        }
        public int getIdade()
        {
            return idade;
        }
        public string getSexo()
        {
            return sexo;
        }

    }
}
