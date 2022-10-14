namespace Lista8Ex4
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            
            string con;
            IDictionary<int,Item> itens = new Dictionary<int,Item>();
            Item item = new Item("Item test",8.88f);
            itens.Add(itens.Count, item);

            string descricao;
            float altura;
            for(; ; )
            {
                int continuar = 1;
                Console.WriteLine("digite a descrição do item");
                descricao=Console.ReadLine();
                Console.WriteLine("digite a altura do item");
                altura=float.Parse(Console.ReadLine());
                item=new Item(descricao,altura);
                itens.Add(itens.Count, item);
                Console.WriteLine("digite zero para continuar");
                continuar = int.Parse(Console.ReadLine());
                if (continuar == 0)
                {
                    break;
                }
            }





            foreach(KeyValuePair<int,Item> i in itens)
            {
                Console.WriteLine("indice: " +i.Key);
                Console.WriteLine("descricao: "+i.Value.getDescricao());
                Console.WriteLine("altura: "+i.Value.getAltura());
                Console.WriteLine("data: "+i.Value.getData());
            }

            Console.WriteLine("Digite algum caracter para continuar");
            con= Console.ReadLine();
            DateTime data = DateTime.Now;
            double diferenca;

            foreach (KeyValuePair<int, Item> i in itens)
            {
                Console.WriteLine(data);
                diferenca = (data - i.Value.getData()).TotalSeconds;
                Console.WriteLine("indice: " + i.Key);
                Console.WriteLine("diferença de tempo entre a criação em relação a este momento: " + diferenca);
            }
        }

        
    }
}