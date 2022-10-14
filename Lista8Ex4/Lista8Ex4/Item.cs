using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex4
{
    internal class Item
    {
        string descricao;
        float altura;
        DateTime date = new DateTime();
        public Item(string descricao, float altura)
        {
            this.descricao = descricao;
            this.altura = altura;
            this.date = DateTime.Now;
        }
        public void imprimirItem()
        {
            Console.WriteLine(this.descricao);
            Console.WriteLine(this.altura);
            Console.WriteLine(this.date);
        }
        public float getAltura()
        {
            return altura;
        }
        public DateTime getData()
        {
            return date;
        }
        public string getDescricao()
        {
            return descricao;
        }
        public void setDescricao(string valor)
        {
            this.descricao = valor;
        }
        public void setAltura(float valor)
        {
            this.altura = valor;
        }
        
        public void oi()
        {
            date = DateTime.Now;
            Console.WriteLine(date);
            

        }







    }
}
