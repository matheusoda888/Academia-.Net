using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex6
{
    internal class Operador : Funcionario
    {
        public string nome;
        public string depart;
        public double salario;
        DateTime date = new DateTime();
        public string rg;
        public bool ativo;
        public Operador(string nome, string depart, double salario, string rg, bool ativo)
        {
            this.nome = nome;
            this.depart = depart;
            this.salario = salario;
            this.date = DateTime.Now;
            this.rg = rg;
            this.ativo = ativo;
        }

        public override void executaTrabalho()
        {
            Console.WriteLine("É operador");

        }
        public override void aumentaSalario(double valor)
        {
            salario = salario + valor;
        }
        public override void demite()
        {
            ativo = false;
        }
        public override void exibir()
        {
            Console.WriteLine(nome);
            Console.WriteLine(depart);
            Console.WriteLine(salario);
            Console.WriteLine(date);
            Console.WriteLine(rg);
            Console.WriteLine(ativo);

        }
    }
}
