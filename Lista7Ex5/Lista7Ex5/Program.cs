namespace Lista7Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();
            List<Pedido> pedidos = new List<Pedido>();  
            Produto produto;
            Pedido pedido;
            bool continua=false;
            string id;
            int quantidade;
            float preco;
            string pagamento;
            produto = new Produto("vaso", "1", 30, 100);
            produtos.Add(produto);
            produto = new Produto("pc", "2", 3000, 10);
            produtos.Add(produto);
            produto = new Produto("ps5", "3", 30000, 1);
            produtos.Add(produto);
            produto = new Produto("cadeira", "4", 9999, 10);
            produtos.Add(produto);
            Console.WriteLine("qual o id do item que deseja pedir?");
            id=Console.ReadLine();
            foreach(var item in produtos)
            {
                if (item.getId() == id)
                {
                    
                    Console.WriteLine("Digite a quantidade");
                    quantidade = int.Parse(Console.ReadLine());
                    if (quantidade <= item.getQuantidade())
                    {

                        preco = quantidade * item.getValor();
                        Console.WriteLine("preço: "+preco);

                        Console.WriteLine("qual o metodo de pagamento?");
                        pagamento = Console.ReadLine();
                        pedido = new Pedido(item, quantidade, pagamento);
                        Console.WriteLine("produto: " + pedido.getProduto().getNome());
                        Console.WriteLine("quantidade: " + pedido.getQuantidade());
                        Console.WriteLine("metodo de pagamento: " + pedido.getPagamento());
                        //pedidos.Add(pedido);
                    }
                }
            }
            
            
            
            
        }
    }
}