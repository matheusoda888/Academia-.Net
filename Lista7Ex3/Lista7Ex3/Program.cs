namespace Lista7Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int continuar = 1;
            List<Carro> carros = new List<Carro>();
            Carro carro;
            string nome;
            string id;
            Cliente cliente;
            List<Cliente> clientes = new List<Cliente>();
            Aluguel aluguel;
            List<Aluguel> alugueis = new List<Aluguel>();


            while (continuar != 0)
            {
                Console.WriteLine("_____Cadastro de carros____ ");
                Console.WriteLine("modelo do carro: ");
                nome = Console.ReadLine();
                Console.WriteLine("id do carro: ");
                id = Console.ReadLine();
                carro = new Carro(nome, id);
                carros.Add(carro);
                Console.WriteLine("digite zero para sair");
                continuar = int.Parse(Console.ReadLine());

            }
            continuar = 1;
            while (continuar != 0)
            {
                Console.WriteLine("_____Cadastro de clientes____ ");
                Console.WriteLine("nome do cliente: ");
                nome = Console.ReadLine();
                Console.WriteLine("id do cliente: ");
                id = Console.ReadLine();
                
                cliente = new Cliente(nome, id);
                clientes.Add(cliente);
                Console.WriteLine("digite zero para sair");
                continuar = int.Parse(Console.ReadLine());
            }
            continuar = 1;
            while (continuar != 0)
            {
                Console.WriteLine("_____Aluguel____ ");
                Console.WriteLine("digite o id do carro: ");
                id = Console.ReadLine();
                foreach(var item in carros)
                {
                    if (item.id == id)
                    {
                        Console.WriteLine("digite o id do cliente: ");
                        id = Console.ReadLine();
                        foreach (var item2 in clientes)
                        {
                            if (item2.id == id)
                            {
                                aluguel = new Aluguel(item2, item);
                                alugueis.Add(aluguel);
                            }
                        }
                    }
                }
            Console.WriteLine("digite zero para sair");
            continuar = int.Parse(Console.ReadLine());





            }
            foreach(var item in alugueis)
            {
                

                Console.WriteLine("Id do cliente: "+item.getClienteId()+" id do carro: "+item.getCarroId());
            }
        }
    }
}