namespace Lista8Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string tipo="", id="";
            IDictionary<int,Animal> animais = new Dictionary<int,Animal>();
            Animal animal;
            for(int i = 0; i < 5; i++)
            {
                while(tipo!="gato".ToLower()&& tipo != "cachorro".ToLower()&& tipo != "peixe".ToLower())
                {
                    Console.WriteLine("digite o tipo do animal");
                    tipo = Console.ReadLine();

                }
                Console.WriteLine("digite a identificação");
                id = Console.ReadLine();
                animal = new Animal(tipo, id);
                animais.Add(i + 1, animal);
                tipo = "";
            }
            foreach(KeyValuePair<int,Animal> item in animais)
            {
                Console.WriteLine("indice: "+item.Key);
                Console.WriteLine("identificação: "+item.Value.getId());
                Console.WriteLine("Tipo: "+item.Value.getTipo());
            }
        }
    }
}