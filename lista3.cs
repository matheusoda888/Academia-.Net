namespace Lista2
{
    internal class lista3
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Qual exercicio da lista?");
            num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    exercicio1();
                    break;
                case 2:
                    exercicio2();
                    break;
                case 3:
                    exercicio3();
                    break;
                case 4:
                    exercicio4();
                    break;
                case 5:
                    exercicio5();
                    break;
                case 6:
                    exercicio6();
                    break;
                case 7:
                    exercicio7();
                    break;
                case 8:
                    exercicio8();
                    break;
                case 9:
                    exercicio9();
                    break;
                case 10:
                    exercicio10();
                    break;
                case 11:
                    exercicio11();
                    break;
                case 12:
                    exercicio12();
                    break;
                case 13:
                    exercicio13();
                    break;
                case 14:
                    exercicio14();
                    break;
                case 15:
                    exercicio15();
                    break;
                case 16:
                    exercicio16();
                    break;
                case 17:
                    exercicio17();
                    break;
                case 18:
                    exercicio18();
                    break;
                case 19:
                    exercicio19();
                    break;
                case 20:
                    exercicio20();
                    break;
                default:
                    Console.WriteLine("Questão invalida");
                    break;




            }
        }
        static void exercicio1()
        {
            float x;

            x = float.Parse(Console.ReadLine());

            if (x >= 0 && x == (int)x)
            {
                int i;
                for (i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
        static void exercicio2()
        {
            float x;
            int i;
            x = float.Parse(Console.ReadLine());

            if (x >= 0 && x == (int)x)
            {

                for (i = 1; i < x; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Deseja informar outro número(s / n) ?");
                string r;
                r = Console.ReadLine();
                if (r == "s")
                {
                    exercicio2();
                }


            }


        }
        static void exercicio3()
        {
            int i, x, aux = 0;
            for (; ; )
            {
                x = int.Parse(Console.ReadLine());
                if (x == 0)
                {
                    break;
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("par");
                    }
                    for (int y = 1; y <= x; y++)
                    {
                        if (x % y == 0)
                            aux++;
                    }
                    if (aux == 2) Console.WriteLine("É um numero primo!");
                    else Console.WriteLine("Não é um numero primo");
                    aux = 0;


                }
            }
        }
        static void exercicio4()
        {
            string voto = " ";
            int zeca = 0;
            int joao = 0;
            int branco = 0;
            Console.WriteLine("Inicio das votações");
            for (; voto != "fim";)
            {
                voto = Console.ReadLine();
                if (voto == "zeca")
                {
                    zeca++;
                    voto = "";
                }
                else if (voto == "joao")
                {
                    joao++;
                    voto = "";
                }
                else if (voto == "branco")
                {
                    branco++;
                    voto = "";
                }
            }
            Console.WriteLine("Joao teve " + joao + " votos");
            Console.WriteLine("Zeca teve " + zeca + " votos");
            Console.WriteLine(branco + " votos em branco");
        }
        static void exercicio5()
        {
            string voto = " ";
            int zeca = 0;
            int joao = 0;
            int branco = 0;
            int nulo = 0;
            Console.WriteLine("Inicio das votações");
            for (; voto != "fim";)
            {
                voto = Console.ReadLine();
                if (voto == "zeca")
                {
                    zeca++;
                    voto = "";
                }
                else if (voto == "joao")
                {
                    joao++;
                    voto = "";
                }
                else if (voto == "branco")
                {
                    branco++;
                    voto = "";
                }
                else
                {
                    if (voto != "fim")
                    {
                        nulo++;
                        voto = "";
                    }

                }
            }
            Console.WriteLine("Joao teve " + joao + " votos");
            Console.WriteLine("Zeca teve " + zeca + " votos");
            Console.WriteLine(branco + " votos em branco");
            Console.WriteLine(nulo + " votos nulos");
        }
        static void exercicio6()
        {
            int x = -1, i;
            while (x < 0)
            {

                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("dados invalidos");
                }

            }

            Console.WriteLine(x + " anos");

        }
        static void exercicio7()
        {
            string nome = "";
            int idade = -1;
            int salario = -1;
            Console.WriteLine("digite o nome");
            while (nome == "" || nome == " " || nome.Any(char.IsDigit))
            {

                nome = (Console.ReadLine());
                if (nome == "" || nome == " " || nome.Any(char.IsDigit))
                {
                    Console.WriteLine("dados invalidos");
                }


            }

            Console.WriteLine("digite a idade");
            while (idade < 0)
            {

                idade = int.Parse(Console.ReadLine());
                if (idade < 0)
                {
                    Console.WriteLine("dados invalidos");
                }

            }

            Console.WriteLine("digite o salario");

            while (salario < 0)
            {

                salario = int.Parse(Console.ReadLine());
                if (salario < 0)
                {
                    Console.WriteLine("dados invalidos");
                }

            }
            Console.WriteLine(nome);
            Console.WriteLine(idade + " de idade");
            Console.WriteLine(salario + " de salario");
        }
        static void exercicio8()
        {
            int x = -1;
            Console.WriteLine("digite um numero inteiro");
            while (x < 0)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                {
                    Console.WriteLine("dados invalidos");
                }
                else
                {
                    if (x % 2 == 0)
                    {
                        Console.WriteLine("par");
                    }
                    else
                    {
                        Console.WriteLine("impar");
                    }
                }

            }
            Console.WriteLine("Deseja continuar?(s/n)");
            string r = "";
            while (r != "n")
            {
                r = Console.ReadLine();
                if (r == "s")
                {
                    exercicio8();
                    break;
                }
                else if (r != "s" && r != "n")
                {
                    Console.WriteLine("dados invalidos");
                }
            }



        }
        static void exercicio9()
        {
            int[] filhos = new int[30];
            int i;
            int f0 = 0, f1 = 0, f4 = 0, f8 = 0;



            for (i = 0; i < 3; i++)
            {
                filhos[i] = int.Parse(Console.ReadLine());
                if (filhos[i] == 0)
                {
                    f0++;
                }
                else if (filhos[i] >= 1 && filhos[i] < 4)
                {
                    f1++;
                }
                else if (filhos[i] >= 4 && filhos[i] < 8)
                {
                    f4++;
                }
                else if (filhos[i] >= 8)
                {
                    f8++;
                }
            }
            Console.WriteLine("0 filhos: " + f0);
            Console.WriteLine("1 a 3 filhos: " + f1);
            Console.WriteLine("4 a 7 filhos: " + f4);
            Console.WriteLine("Mais de 8 filhos: " + f8);
        }
        static void exercicio10()
        {
            int[] idades = new int[5];
            string[] nomes = new string[5];
            string[] sexo = new string[5];
            int i;
            int masc=0;
            int fem=0;
            int me30=0;
            int ma60=0;
            int mFem=0;
            for(i=0;i<5; i++)
            {
                do
                {
                Console.WriteLine("Digite o nome");
                nomes[i]=Console.ReadLine();
                } while (nomes[i].Any(char.IsDigit));
                Console.WriteLine("Digite a idade");
                idades[i] = int.Parse(Console.ReadLine());

                sexo[i] = " ";
                Console.WriteLine("Digite o sexo");
                while (sexo[i] != "m" && sexo[i] != "f")
                {
                    sexo[i] = Console.ReadLine();
                    if (sexo[i] != "m" && sexo[i] != "f")
                    {
                        Console.WriteLine("Digite novamente");
                    }
                }

            }
            for (i = 0; i < 5; i++)
            {
                if (idades[i] < 30)
                {
                    me30++;
                }
                else if (idades[i] > 60)
                {
                    ma60++;
                }
                if (sexo[i] == "f")
                {
                    fem++;
                    mFem += idades[i];
                }
                else if (sexo[i] == "m")
                {
                    masc++;
                }

            }
            mFem = mFem / fem;
            Console.WriteLine(masc);
            Console.WriteLine(fem);
            Console.WriteLine(me30);
            Console.WriteLine(ma60);
            Console.WriteLine(mFem);
        }

        //duvida na 11: é necessario sempre dizer o tamanho do array ao cria-lo?
        static void exercicio11()
        {
            int qtdAlunos,i;
            int maior = 0;
            int menor = 999;
            int menorPos = 0;
            int maiorPos=0;
            float media=0;
            qtdAlunos=int.Parse(Console.ReadLine());
            int[] notas = new int[qtdAlunos];
            for (i = 0; i < qtdAlunos; i++){
                notas[i] = int.Parse(Console.ReadLine());
                if (notas[i] > maior)
                {
                    maior=notas[i];
                    maiorPos = i;
                }
                if (notas[i] < menor)
                {
                    menor = notas[i];
                    menorPos = i;
                }
                media += notas[i];
            }
            media = media / qtdAlunos;
            for(i = 0; i < qtdAlunos; i++)
            {
                Console.WriteLine(notas[i]);
                
            }
            Console.WriteLine("maior nota foi: " + maior + " do aluno: " + maiorPos);
            Console.WriteLine("menor nota foi: " + menor + " do aluno: " + menorPos);
            Console.WriteLine("Numero de alunos: " + qtdAlunos);
            Console.WriteLine("Media das notas: "+media);
        }

        static void exercicio12()
        {
            int inicio,i;
            
            int soma = 0;
            inicio = int.Parse(Console.ReadLine());
            for (i = inicio; i < inicio + 100; i++)
            {

                soma += i;
                Console.WriteLine(soma);
            }
            Console.WriteLine(soma);
        }

        static void exercicio13()
        {

            int i, soma=0;
            for (i = 1; i < 501; i++)
            {
                if (i % 2 == 0)
                {
                    soma = soma + i;
                    Console.WriteLine(soma);
                }
            }
            Console.WriteLine("Soma final: "+soma);

        }

        static void exercicio14()
        {
            double[] pot = new double[11];

            for(int i = 0; i < pot.Length; i++)
            {
                pot[i] = Math.Pow(2, i);
                Console.WriteLine(pot[i]);
            }
        }

        static void exercicio15()
        {
            float[] notas = new float[4];
            int i;
            float soma = 0, media;
            for (i = 0; i < notas.Length; i++)
            {
                notas[i] = 11;
                while (notas[i] < 0 || notas[i] > 10)
                {
                    notas[i] = float.Parse(Console.ReadLine());
                    if(notas[i] < 0 || notas[i] > 10)
                    {
                        Console.WriteLine("nota invalida");
                    }
                }




            }
            notas[0] = notas[0] * 2;
            notas[1] = notas[1] * 1;
            notas[2] = notas[2] * 2;
            notas[3] = notas[3] * 4;
            for(i=0; i<notas.Length; i++)
                {
                    soma = soma + notas[i];
                }
            media = soma / 9;
            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }
        }

        static void exercicio16()
        {
            int n=49;
            int mult=0;
            while (n < 50 || n > 250)
            {
                n = int.Parse(Console.ReadLine());
                if(n < 50 || n > 250)
                {
                    Console.WriteLine("dados invalidos");
                }
            }
            while (n*3 < 250)
            {
                n = n * 3;
                Console.WriteLine(n);
            }

            

        }
        static void exercicio17()
        {
            int aux = 15,pot;
            while (aux < 201)
            {
                pot = aux * aux;
                Console.WriteLine(pot);
                aux++;
            }
        }

        static void exercicio18()
        {

        }

        static void exercicio19()
        {
            int i;
            int nHab;
            int mediaS=0;
            int mediaF = 0;
            int maiorS = 0;
            float mCem = 0;
            nHab = int.Parse(Console.ReadLine());
            int[] salario = new int[nHab];
            int[] filhos = new int[nHab];
            for(i=0;i<nHab; i++)
            {
                salario[i]=int.Parse(Console.ReadLine());
                filhos[i]=int.Parse(Console.ReadLine());

            }
            for(i = 0; i < salario.Length; i++)
            {
                Console.WriteLine(i+1);
                Console.WriteLine("salario: "+salario[i]);
                Console.WriteLine("filhos: "+filhos[i]);
                if (salario[i] > maiorS)
                {
                    maiorS = salario[i];
                }
                if (salario[i] <= 100)
                {
                    mCem++;
                }
                mediaS = mediaS + salario[i];
                mediaF = mediaF + filhos[i];
            }
            mediaS = mediaS / salario.Length;
            mediaF = mediaF/filhos.Length;
            mCem=(mCem/salario.Length)*100;
            Console.WriteLine("media salarial: "+mediaS);
            Console.WriteLine("media de filhos : " + mediaF);
            Console.WriteLine("maior salario" + maiorS);
            Console.WriteLine("percentual de salario até 100: " + mCem);
            
        }

        static void exercicio20()
        {
            int tamanho;
            tamanho = int.Parse(Console.ReadLine());
            string[] sexo = new string[tamanho];
            string[] olhos = new string[tamanho];
            string[] cabelo = new string[tamanho];
            int[] idade = new int[tamanho];
            int i;
            int maiorI = 0;
            int f1835=0;
            for (i = 0; i < tamanho; i++)
            {
                sexo[i] = Console.ReadLine();
                olhos[i] = Console.ReadLine();
                cabelo[i] = Console.ReadLine();
                idade[i] = int.Parse(Console.ReadLine());
            }
            for(i=0;i<tamanho; i++)
            {
                if (idade[i] > maiorI)
                {
                    maiorI = idade[i];
                }
                if (sexo[i] == "f" && idade[i] < 35 && idade[i] >= 18 && cabelo[i] == "l" && olhos[i]=="v")
                {
                    f1835++;
                }
            }
            Console.WriteLine("maior idade é: " + maiorI);
            Console.WriteLine("mulheres com 18 a 35, loiras olhos verdes: " + f1835);

;           


        }
    }
    

        
}
