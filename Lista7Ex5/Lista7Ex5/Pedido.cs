using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex5
{
    internal class Pedido
    {
        Produto produto;
        int quantidade;
        string pagamento;
        public Pedido(Produto produto, int quantidade, string pagamento)
        {
            this.produto = produto;
            this.quantidade = quantidade;
            this.pagamento = pagamento;
        }
        public Produto getProduto() { 
            return produto;
        }
        public int getQuantidade()
        {
            return quantidade;
        }
        public string getPagamento()
        {
            return pagamento;
        }
        public void setQuantidade(int quantidade)
        {
            this.quantidade = quantidade;
        }
        public void setPagamento(string pagamento)
        {
            this.pagamento = pagamento;
        }

    }
}
