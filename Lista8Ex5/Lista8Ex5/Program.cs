namespace Lista8Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            int x = 0,y=0;
            List <Objeto> objetos = new List <Objeto> ();   
            Objeto objeto;
            objeto = new Objeto();
            
            Console.WriteLine("Digite quantos objetos deseja cadastrar: ");
            n=int.Parse (Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                int u = i + 1;
                Console.WriteLine("digite o X do obj "+u);
                x=int.Parse (Console.ReadLine());
                
                Console.WriteLine("digite o Y do obj " + u);
                y = int.Parse(Console.ReadLine());
                objeto = new Objeto(x, y);
                objetos.Add(objeto);
            }
            int c = 1;
            foreach(Objeto item in objetos)
            {
                
                Console.WriteLine("item "+c);
                item.exibirObjeto();
                c++;
            }
        }
    }
}