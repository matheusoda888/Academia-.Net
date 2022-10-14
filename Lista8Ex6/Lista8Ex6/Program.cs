namespace Lista8Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string depart;
            double salario;
            DateTime date;
            string rg;
            bool ativo;
            int gerent = 0;
            IDictionary<int, Funcionario> funcionarios = new Dictionary<int, Funcionario>();
            Funcionario funcionario;
            int continuar = 1;
            Gerente gerente;
            Operador operador;

            int op = 0;
            for (; ; )
            {
                Console.WriteLine("Digite 1 para adicionar funcionarios, 2 para demitir, 3 para exibir funcionarios cadastrados e 4 para dar um aumento salarial.");
                op = int.Parse(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        while (continuar != 0)
                        {
                            Console.WriteLine("digite o nome: ");
                            nome = Console.ReadLine();
                            Console.WriteLine("digite o departamento: ");
                            depart = Console.ReadLine();
                            Console.WriteLine("digite o salario: ");
                            salario = int.Parse(Console.ReadLine());
                            Console.WriteLine("digite o rg: ");
                            rg = Console.ReadLine();
                            Console.WriteLine("Digite 1 para definir como gerente e Qualquer outro numero para definir como funcionario");
                            gerent = int.Parse(Console.ReadLine());

                            if (gerent == 1)
                            {
                                gerente = new Gerente(nome, depart, salario, rg, true);
                                funcionarios.Add(funcionarios.Count, gerente);
                                
                            }
                            else
                            {
                                //iniciar operador
                                operador = new Operador(nome,depart, salario, rg, true);
                                funcionarios.Add(funcionarios.Count, operador);
                            }
                            
                            
                            
                            Console.WriteLine("digite zero para parar os cadastros. ");
                            continuar = int.Parse(Console.ReadLine());
                        }
                        break;
                    case 2:
                        Console.WriteLine("digite o numero do funcionario");
                        int func = 0;
                        func = int.Parse(Console.ReadLine());
                        foreach (KeyValuePair<int, Funcionario> item in funcionarios)
                        {
                            if (func == item.Key)
                            {
                                item.Value.demite();
                            }
                        }
                        break;
                    case 3:
                        foreach (KeyValuePair<int, Funcionario> item in funcionarios)
                        {
                            Console.WriteLine("key: " + item.Key);
                            item.Value.exibir();
                            item.Value.executaTrabalho();
                        }
                        break;
                    case 4:
                        Console.WriteLine("digite o numero do funcionario");
                        int funci = 0, valor = 0 ;
                        funci = int.Parse(Console.ReadLine());
                        Console.WriteLine("quanto de aumento?");
                        valor = int.Parse(Console.ReadLine());
                        foreach (KeyValuePair<int, Funcionario> item in funcionarios)
                        {
                            if (funci == item.Key)
                            {
                                item.Value.aumentaSalario(valor);
                            }
                        }
                        break;

                }

            }

            
        }
    }
}