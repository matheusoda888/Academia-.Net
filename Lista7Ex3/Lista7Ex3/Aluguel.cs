using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex3
{
    internal class Aluguel
    {
        public Cliente cliente;
        public Carro carro;
        
        public Aluguel(Cliente cliente, Carro carro)
        {
            this.cliente = cliente;
            this.carro = carro;
            
        }
        public string getClienteId()
        {
            return cliente.id;
        }
        public string getCarroId()
        {
            return carro.id;
        }
        
    }
}
