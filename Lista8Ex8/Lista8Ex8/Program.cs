namespace Lista8Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Livro livro;
            string nome;
            int paginas;
            IDictionary<int,Livro> livros = new Dictionary<int,Livro>();
            for (; ; )
            {
                int op = 0;
                Console.WriteLine("Digite 1 para adicionar livros, 2 para buscar um livro e 3 para mostrar todos os livros");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        for (int i = 1; i != 0;)
                        {
                            Console.WriteLine("digite o nome do livro " + (livros.Count + 1));
                            nome = Console.ReadLine();
                            Console.WriteLine("digite o numero de paginas do livro " + (livros.Count + 1));
                            paginas = int.Parse(Console.ReadLine());
                            livro = new Livro(nome, paginas);
                            livros.Add(livros.Count, livro);
                            Console.WriteLine("digite zero para parar os cadastros ");
                            i = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        int j = 0;
                        string nomeBusca;
                        Console.WriteLine("digite o nome do livro");
                        nomeBusca = Console.ReadLine().ToLower();
                        foreach (KeyValuePair<int, Livro> item in livros)
                        {

                            if (nomeBusca == item.Value.getNome().ToLower())
                            {
                                Console.WriteLine((item.Key + 1) + " é a posicao do livro buscado");
                                j = 1;

                            }
                        }
                        if (j == 0)
                        {
                            Console.WriteLine("Nenhum livro encontrado");
                        }
                        break;
                    case 3:
                        foreach(KeyValuePair<int,Livro> item in livros)
                        {
                            Console.WriteLine(item.Key);
                            item.Value.exibirLivro();
                            
                        }
                        break;



                }
                



                

            }



        }
    }
}