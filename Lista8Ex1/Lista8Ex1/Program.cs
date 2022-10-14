namespace Lista8Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, maior =0, maiorI=0;

            IDictionary<int,Personagem> persos = new Dictionary<int,Personagem>();
            Personagem[] personagem = new Personagem[3]; ;
            personagem[0]= new Personagem();
            persos.Add(1, personagem[0]);
            personagem[1] = new Personagem();
            persos.Add(2, personagem[1]);
            personagem[2] = new Personagem();
            persos.Add(3, personagem[2]);

            for (i = 0; i < persos.Count; i++)
            {
                Console.WriteLine("digite o nome do personagem");
                personagem[i].nome = Console.ReadLine();
                Console.WriteLine("digite o poder do personagem");
                personagem[i].poder = int.Parse(Console.ReadLine());

            }
            foreach(KeyValuePair<int,Personagem> item in persos)
            {
                if (item.Value.poder > maior)
                {
                    maior = item.Value.poder;
                    maiorI = item.Key;
                }
            }
            Console.WriteLine("maior poder: " + maior);
            Console.WriteLine("posicao: " + maiorI);



        }
    }
}