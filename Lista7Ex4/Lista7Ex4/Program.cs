namespace Lista7Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa pessoa;
            //List<Pessoa> pessoas = new List<Pessoa>();
            //int continuar = 1;
            //string nome;
            //string parent;
            //int idade;
            //while (continuar != 0)
            //{
            //    Console.WriteLine("Digite o nome ");
            //    nome = Console.ReadLine();
            //    Console.WriteLine("Digite a idade");
            //    idade = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Digite o de parentesco");
            //    parent = Console.ReadLine();
            //    pessoa = new Pessoa(nome, idade, parent);
            //    pessoas.Add(pessoa);
            //    Console.WriteLine("Digite zero para parar");
            //    continuar = int.Parse(Console.ReadLine());

            //}
            //int i = 0;
            //foreach(var item in pessoas)
            //{
            //    i++;
            //    Console.WriteLine("parente: "+i);
            //    Console.WriteLine(item.getNome());
            //    Console.WriteLine(item.getParente());
            //    Console.WriteLine(item.getIdade());
            //}

            Pessoa pessoaFilho = new Pessoa();
            pessoaFilho.idade = 24;
            pessoaFilho.nome = "Matheus";
            Pessoa pessoaMae = new Pessoa();
            pessoaMae.nome = "Clarissa";
            pessoaMae.idade = 40;
            Pessoa pessoaPai = new Pessoa();
            pessoaPai.nome = "Cristiano";
            pessoaPai.idade = 45;
            Pessoa pAvoMae = new Pessoa();
            pAvoMae.nome = "Nestor";
            pAvoMae.idade = 75;
            Pessoa pAvohMae = new Pessoa();
            pAvohMae.nome = "Joana";
            pAvohMae.idade = 70;
            pessoaMae.mae = pAvohMae;
            pessoaMae.pai = pAvoMae;
            pessoaFilho.mae = pessoaMae;
            pessoaFilho.pai = pessoaPai;

            
        }
    }
}