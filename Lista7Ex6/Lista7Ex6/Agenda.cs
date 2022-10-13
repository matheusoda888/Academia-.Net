using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista7Ex6
{/*Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz 
  * de realizar as seguintes operações:
            void armazenaPessoa(String nome, int idade, float altura);
            void removePessoa(String nome);
            Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda*/
    internal class Agenda
    {

        public List<Pessoa> pessoas = new List<Pessoa>();
        public Pessoa pessoa;
        int idade;
        float altura;
        string nome;


        public void armazenaPessoa(string nome, int idade, float altura)
        {
            
            pessoa = new Pessoa(nome, idade, altura);
            pessoas.Add(pessoa);
        }
        public void removePessoa(string nome)
        {
            
            foreach(var item in pessoas)
            {
                
                if(nome== item.nome) {
                    pessoas.Remove(item);
                }
            }
        }
        public void buscaPessoa(string nome)
        {
            foreach (var item in pessoas)
            {
                if (nome == item.nome)
                {
                    Console.WriteLine(item.nome);
                    Console.WriteLine(item.idade);
                    Console.WriteLine(item.altura);

                }
            }
        }
        public void imprimeLista()
        {
            int index=1;
            foreach (var item in pessoas)
            {
                Console.WriteLine("ITEM " + index);
                Console.WriteLine(item.nome);
                Console.WriteLine(item.idade);
                Console.WriteLine(item.altura);

                
            }
        }
    }
}
