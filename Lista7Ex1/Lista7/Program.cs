namespace Lista7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            string nome;
            string genero;
            int paginas;
            Livro livro;
            List<Livro> livros = new List<Livro>();
            while (continuar!=0)
            {
                Console.WriteLine("nome do livro: ");
                nome = Console.ReadLine();
                Console.WriteLine("genero do livro: ");
                genero = Console.ReadLine();
                Console.WriteLine("numero de pginas: ");
                paginas = int.Parse(Console.ReadLine());
                livro = new Livro(nome, genero, paginas);
                livros.Add(livro);
                Console.WriteLine("digite zero para sair");
                continuar=int.Parse(Console.ReadLine());
                

            }
            foreach (var item in livros)
            {
                Console.WriteLine(item.nome);
                Console.WriteLine(item.genero);
                Console.WriteLine(item.paginas);
            }


        }
    }
}