namespace Lista7Ex7
{
    internal class Program
    {
        
        static void Main(string[] args)
        {   Elevador elevador;
            int andarMax;
            int pessoasMax;
            Console.WriteLine("Quantos andares tem o prédio?");
            andarMax = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual a capacidade maxima do elevador?");
            pessoasMax = int.Parse(Console.ReadLine());
            elevador = new Elevador(andarMax,pessoasMax);

            int continuar = 1;
            int op = 0;
            while (continuar != 0)
            {
                Console.WriteLine("digite 1 para subir, 2 para descer, 3 para adicionar, 4 para retirar, 5 para imprimir");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        elevador.sobe();
                        break;
                    case 2:
                        elevador.desce();
                        break;
                    case 3:
                        elevador.entra();
                        break;
                    case 4:
                        elevador.sai();
                        break;
                    case 5:
                        elevador.imprimirInfo();
                        break;
                }
            }

        } 
    }
}