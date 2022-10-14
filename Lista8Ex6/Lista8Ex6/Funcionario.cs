using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex6
{
     abstract class Funcionario
     {
        //public string nome;
        //public string depart;
        //public double salario;
        //DateTime date = new DateTime();
        //public string rg;
        //public bool ativo;
        //public Funcionario(string nome, string depart, double salario, string rg, bool ativo)
        //{
        //    this.nome = nome;
        //    this.depart = depart;
        //    this.salario = salario;
        //    this.date = DateTime.Now;
        //    this.rg = rg;
        //    this.ativo = ativo;
        //}
        public abstract void aumentaSalario(double valor);
        
        public abstract void demite();
        
        public abstract void exibir();
        
        public abstract void executaTrabalho();



    }
}
