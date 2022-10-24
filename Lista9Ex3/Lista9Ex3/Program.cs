namespace Lista9Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string codigo="";
            string nome="";
            string selecao="";
            Figurinha figurinha;
            List<Figurinha> figurinhasNovas = new List<Figurinha>();
            List<Figurinha> figurinhasRepetidas = new List<Figurinha>();


            Util.popular(figurinhasRepetidas, "FigurinhasRepetidas.csv");
            Util.popular(figurinhasNovas, "FigurinhasNovas.csv");
            int op = 0;
            while (true)
            {
                Console.WriteLine("1 - Cadastrar figurinha repetida, 2 - Cadastrar figurinha faltante, 3 - Listar figurinhas repetidas, 4 - Listar figurinhas faltantes ");
                op=int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        Console.WriteLine("digite o codigo da figurinha");
                        codigo = Console.ReadLine();
                        Console.WriteLine("digite o nome do jogador");
                        nome = Console.ReadLine();
                        Console.WriteLine("digite a seleçao do jogador");
                        selecao = Console.ReadLine();
                        figurinha = new Figurinha(codigo, selecao, nome);
                        figurinhasRepetidas.Add(figurinha);
                        Util.escrever(figurinha, "FigurinhasRepetidas.csv");
                        break;
                    case 2:
                        Console.WriteLine("digite o codigo da figurinha");
                        codigo = Console.ReadLine();
                        Console.WriteLine("digite o nome do jogador");
                        nome = Console.ReadLine();
                        Console.WriteLine("digite a seleçao do jogador");
                        selecao = Console.ReadLine();
                        figurinha = new Figurinha(codigo, selecao, nome);
                        figurinhasNovas.Add(figurinha);
                        Util.escrever(figurinha, "FigurinhasNovas.csv");
                        break;
                    case 3:
                        Util.mostrarListaFigurinhas(figurinhasRepetidas);
                        break;
                    case 4:
                        Util.mostrarListaFigurinhas(figurinhasNovas);
                        break;

                }
            }
        }
    }
}