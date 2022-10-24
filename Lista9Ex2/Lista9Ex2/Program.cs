namespace Lista9Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> listaDePessoas = new List<Pessoa>();

            //conecta com a base de dados
            Console.WriteLine("Pessoas já cadastradas!");
            Util.popularArquivoNaListaPessoa(listaDePessoas, "pessoas.csv");

            //mostrar o conteúdo da lista
            Util.mostrarListaPessoa(listaDePessoas);
            string opcao;
            string nome;
            string email;
            Pessoa pessoa;
            do
            {
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                pessoa = new Pessoa(nome, email);

                if (Util.jaNaListaPessoa(pessoa, listaDePessoas))
                {
                    Console.WriteLine("Pessoa já cadastrada com este email!");
                }
                else
                {
                    listaDePessoas.Add(pessoa);

                    //persistir o dado no arquivo
                    Util.gravarPessoaArquivo(pessoa, "pessoas.csv");
                }

                Console.Write("1 - Continua; Outra tecla finaliza!");
                opcao = Console.ReadLine();
            } while (opcao == "1");
        }
    }
}