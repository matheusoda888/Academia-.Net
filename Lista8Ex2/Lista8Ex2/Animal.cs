using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex2
{
    internal class Animal
    {
        string tipo;
        string id;
        public Animal(string tipo, string id)
        {
            this.tipo = tipo;
            this.id = id;
        }
        public string getTipo()
        {
            return tipo;
        }
        public string getId()
        {
            return id;
        }
        public void setId(string valor)
        {
            this.id=valor;
        }
        public void setTipo(string valor)
        {
            this.tipo = valor;
        }
    }
}
