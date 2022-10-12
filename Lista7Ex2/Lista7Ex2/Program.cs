namespace Lista7Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            string nome;
            string sexo;
            int idade;
            Pessoa pessoa;
            List<Pessoa> pessoas = new List<Pessoa>();
            while (continuar != 0)
            {
                Console.WriteLine("nome: ");
                nome = Console.ReadLine();
                Console.WriteLine("sexo: ");
                sexo = Console.ReadLine();
                Console.WriteLine("idade: ");
                idade = int.Parse(Console.ReadLine());
                pessoa = new Pessoa(nome,idade,sexo);
                pessoas.Add(pessoa);
                Console.WriteLine("digite zero para sair");
                continuar = int.Parse(Console.ReadLine());


            }
            foreach (var item in pessoas)
            {
                Console.WriteLine(item.getNome());
                Console.WriteLine(item.getIdade());
                Console.WriteLine(item.getSexo());
            }
        }
    }
}