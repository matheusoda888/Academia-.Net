namespace Lista7Ex6
{
    internal class Program
    {
        
        

        static void Main(string[] args)
        {
            Agenda agenda = new Agenda();
            int idade;
            float altura;
            string nome;
            int continuar = 1;
            int op = 0;


            while (continuar !=0)
            {
                Console.WriteLine("Digite 1 para adiciona, 2 para remover, 3 para buscar e 4 para imprimir");
                op =int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("digite o nome:");
                        nome = Console.ReadLine();
                        Console.WriteLine("digite a idade:");
                        idade = int.Parse(Console.ReadLine());
                        Console.WriteLine("digite a altura:");
                        altura = float.Parse(Console.ReadLine());
                        agenda.armazenaPessoa(nome, idade, altura);
                        //continuar = 0;
                        
                        break;

                    case 2:
                        Console.WriteLine("digite o nome:");
                        nome = Console.ReadLine();
                        agenda.removePessoa(nome);
                        break;
                    case 3:
                        Console.WriteLine("digite o nome:");
                        nome = Console.ReadLine();
                        agenda.buscaPessoa(nome);
                        break;
                    case 4:
                        agenda.imprimeLista();
                        break;
                    default:
                        Console.WriteLine("invalid");
                        break;

                }
                Console.WriteLine("Digite ZERO para sair");
                continuar = int.Parse(Console.ReadLine());
            }
            //armazena  ____________
            

            
            /*Crie uma classe Agenda que pode armazenar 10 pessoas e que seja capaz de realizar as seguintes operações:
            void armazenaPessoa(String nome, int idade, float altura);
            void removePessoa(String nome);
            Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
            void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda*/

        }
    }
}