using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex5
{
    internal class Produto
    {
        private string nome;
        private string id;
        private float valor;
        private int quantidade;
        public Produto(string nome, string id, float valor, int quantidade)
        {
            this.nome = nome;
            this.id = id;
            this.valor = valor;
            this.quantidade = quantidade;
        }
        public string getId()
        {
            return id;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public float getValor()
        {
            return valor;
        }
        public string getNome()
        {
            return nome;
        }
        public void setNome(string nome)
        {
            this.nome = nome;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public void setValor(float valor)
        {
            this.valor = valor;
        }

    }
}
