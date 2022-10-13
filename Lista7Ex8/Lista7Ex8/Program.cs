namespace Lista7Ex8
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Televisao televisao = new Televisao();
            Controle controle = new Controle();
            int op = 0;
            int continuar = 1;
            while (continuar != 0)
            {
                Console.WriteLine("digite 1 para aumentar o volume, 2 para diminuri, 3 aumentar canal, 4 diminuir, 5 para imprimir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        controle.aumentarVolume(televisao);
                        break;
                    case 2:
                        controle.diminuirVolume(televisao);
                        break;
                    case 3:
                        controle.aumentarCanal(televisao);
                        break;
                    case 4:
                        controle.diminuirCanal(televisao);
                        break;
                    case 5:
                        controle.imprimir(televisao);
                        break;
                }
            }
        }
    }
}