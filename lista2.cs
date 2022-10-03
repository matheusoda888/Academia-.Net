using System.Text.RegularExpressions;

namespace listas
{
    internal class lista2
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
            
            int baseT, alturaT;
            Console.WriteLine("digite a base do triangulo");
            baseT = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura do triangulo");
            alturaT = int.Parse(Console.ReadLine());

            if (baseT != 0 && alturaT != 0)
            {
                Console.WriteLine("Area do triangulo e: " + (baseT * alturaT) / 2);
            }
            else
            {
                Console.WriteLine("Valores invalidos.");
            }
            
        }
        static void exercicio2()
        {
            int num;
            Console.WriteLine("digite o numero");
            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Par");
            }
            else
            {
                Console.WriteLine("Impar");
            }


            
        }
        static void exercicio3()
        {
            int[] x=new int[4] ;
            int media,i;
            Console.WriteLine("digite o primeiro numero");
            x[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o segundo numero");
            x[1] = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o terceiro numero");
            x[2] = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o quarto numero");
            x[3]= int.Parse(Console.ReadLine());
            media = (x[0] +x[1] +x[2] +x[3] ) / 4;
            Console.WriteLine("media: "+media);

            for (i = 0; i < 4; i++)
            {
                if (x[i] < media)
                {
                    Console.WriteLine("abaixo da media:"+x[i]);
                }
            }

        }
        static void exercicio4()
        {
            int horas1, horas2, valor1, valor2, x1, x2;
            Console.WriteLine("digite o numero de horas lecionadas pelo primeiro professor");
            horas1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor recebido por hora de trabalho");
            valor1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o numero de horas lecionadas pelo segundo professor");
            horas2 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor recebido por hora de trabalho");
            valor2 = int.Parse(Console.ReadLine());

            x1 = horas1 * valor1;
            x2 = horas2 * valor2;

            Console.WriteLine("professor 1 recebe: " + x1);
            Console.WriteLine("professor 2 recebe: " + x2);
            if (x1 > x2)
            {
                Console.WriteLine("professor 1 recebe mais");

            }
            else if(x1 < x2)
            {
                Console.WriteLine("professor 2 recebe mais");
            }
            else
            {
                Console.WriteLine("recebem o mesmo");
            }
        }
        static void exercicio5()
        {
            int nota1, nota2, media;
            Console.WriteLine("digite a nota 1");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a nota 2");
            nota2 = int.Parse(Console.ReadLine());
            media = (nota1 + nota2) / 2;

            if (media >= 7) {
                Console.WriteLine("Nota: " +media+ "Aprovado");
            }
            else
            {
                
                Console.WriteLine("Nota: " + media+ "Reprovado");
                int exame, mediaF;
                Console.WriteLine("digite a nota do exame");
                exame = int.Parse(Console.ReadLine());
                mediaF = (media + exame) / 2;
                Console.WriteLine("Media Final: " + mediaF);
                if (mediaF >= 5)
                {
                    Console.WriteLine("Aprovado");
                }
                else
                {
                    Console.WriteLine("Reprovado");
                }
            }
            
        }
        static void exercicio6()
        {
            string nome;
            float peso, altura,x;
            Console.WriteLine("digite o nome");
            nome = Console.ReadLine();
            Console.WriteLine("digite o peso");
            peso = float.Parse(Console.ReadLine());
            Console.WriteLine("digite a altura");
            altura = float.Parse(Console.ReadLine());

            x = peso/(altura * altura);
            Console.WriteLine(x);
            if (x < 18)
            {
                Console.WriteLine(nome + "baixo peso");
            }
            else if (x > 18 && x < 25)
            {
                Console.WriteLine(nome + "peso normal");
            }
            else if (x > 25 && x < 30)
            {
                Console.WriteLine(nome + "sobrepeso");
            }
            else if (x > 30 && x < 35)
            {
                Console.WriteLine(nome + "obesidade");
            }
            else if(x>35)
            {
                Console.WriteLine(nome + "obesidade grau serio  ");
            }
        }
        static void exercicio7()
        {
            string frase, palavra;
            frase = Console.ReadLine();
            palavra= Console.ReadLine();

            if (frase == palavra)
            {
                Console.WriteLine("A palavra se encontra na frase");
            }

            else if (frase.EndsWith(" " + palavra) || frase.StartsWith(palavra + " "))
            {
                Console.WriteLine("A palavra se encontra na frase");
            }

            else if (frase.Contains(" " + palavra + " "))
            {
                Console.WriteLine("A palavra se encontra na frase");
            }
            else
            {
                Console.WriteLine("A palavra não se encontra na frase!");
            }

            }
        static void exercicio8()
        {
            //nome, salário base e o total de vendas de um funcionário.
            string nome;
            int salario, vendas, total;
            nome = Console.ReadLine();
            salario = int.Parse(Console.ReadLine());
            vendas = int.Parse(Console.ReadLine());
            if (vendas >= 500&&vendas<1000)
            {
                total = salario + (vendas / 100) * 5;
                Console.WriteLine("nome: " + nome);
                Console.WriteLine("salario: " + salario);
                Console.WriteLine("vendas: " + vendas);
                Console.WriteLine("total: " + total);
            }
            else if (vendas >= 1000&&vendas<5000)
            {
                total = salario + (vendas / 100) * 7;
                Console.WriteLine("nome: " + nome);
                Console.WriteLine("salario: " + salario);
                Console.WriteLine("vendas: " + vendas);
                Console.WriteLine("total: " + total);
            }
            else if (vendas >= 5000)
            {
                total = salario + (vendas / 100) * 10;
                Console.WriteLine("nome: "+nome);
                Console.WriteLine("salario: "+salario);
                Console.WriteLine("vendas: "+vendas);
                Console.WriteLine("total: "+total);

            }
            
        }
        static void exercicio9()
        {
            int x1, x2, x3, media;
            x1 = int.Parse(Console.ReadLine());
            if (x1 < 65)
            {
                Console.WriteLine("corre risco de hipoglicemia");
            }
            else if (x1 > 250)
            {
                Console.WriteLine("corre risco de hiperglicemia");
            }
            x2 = int.Parse(Console.ReadLine());
            if (x2 < 65)
            {
                Console.WriteLine("corre risco de hipoglicemia");
            }
            else if (x2 > 250)
            {
                Console.WriteLine("corre risco de hiperglicemia");
            }
            x3 = int.Parse(Console.ReadLine());
            if (x3 < 65)
            {
                Console.WriteLine("corre risco de hipoglicemia");
            }
            else if (x3 > 250)
            {
                Console.WriteLine("corre risco de hiperglicemia");
            }
            media = (x1 + x2 + x3) / 3;
            Console.WriteLine("media glicemica: " + media);
            if (media < 80)
            {
                Console.WriteLine("É necessário diminuir 2 unidades de insulina");
            }
            else if (media > 150){
                Console.WriteLine("É necessario adicionar 2 unidades de insulina");
            }


        }
        static void exercicio10()
        {
            string nome1, nome2;
            int idade1, idade2;
            float altura1;
            float altura2;
            nome1 = Console.ReadLine();
            nome2 = Console.ReadLine();
            idade1=int.Parse(Console.ReadLine());
            idade2 = int.Parse(Console.ReadLine());
            altura1 = float.Parse(Console.ReadLine());
            altura2 = float.Parse(Console.ReadLine());

            if (idade1 > idade2)
            {
                Console.WriteLine(nome1 + " é mais novo");
            }
            else if(idade1<idade2)
            {
                {
                Console.WriteLine(nome2 + " é mais novo");
                
                }
            }
            else
            {
                Console.WriteLine("mesma idade");
            }
            if (altura1 > altura2)
            {
                Console.WriteLine(nome1 + " é mais alto");
            }
            else if (altura1 < altura2)
            {
                Console.WriteLine(nome1 + " é mais alto");
            }
            else
            {
                Console.WriteLine("mesma altura");
            }
        }
        static void exercicio11()
        {
            int hr, min;
            hr = int.Parse(Console.ReadLine());
            min = int.Parse(Console.ReadLine());
            if (hr < 24 && hr > -1 && min > -1 && min < 60)
            {
                Console.WriteLine("horas: " + hr);
                Console.WriteLine("minutos: " + min);
            }
            else
            {
                Console.WriteLine("Valores inválidos");
            }
        }
        static void exercicio12()
        {
            int codigo, numHoras, salario,extra, salarioTotal;
            codigo = int.Parse(Console.ReadLine());
            numHoras = int.Parse(Console.ReadLine());
            
            salario = numHoras * 10;

            if(numHoras > 50)
            {
                extra = (numHoras - 50) * 10;
            }
            else
            {
                extra = 0;
            }
            salarioTotal = salario + extra;
            Console.WriteLine("salario total: " + salarioTotal);
            Console.WriteLine("salario " + salario);
            Console.WriteLine("extra: " +extra);

        }
        static void exercicio13()
        {
            double h, m, f;
            h = double.Parse(Console.ReadLine());
            m = (72.7 * h) - 58;
            f = (62.1 * h) - 44.7;
            Console.WriteLine("peso ideal para homem: " + m);
            Console.WriteLine("peso ideal para mulher: " + f);
            
        }
        static void exercicio14()
        {
            float tamanho, velocidade, tempo;
            tamanho = float.Parse(Console.ReadLine());
            velocidade = float.Parse(Console.ReadLine());

            tempo = (tamanho / velocidade) / 60;
            Console.WriteLine("Tempo estimado: " + tempo + " minutos");

        }
        static void exercicio15()
        {
            int metrosQ, preco, cobertura,latasNecessarias;
            
            metrosQ = int.Parse(Console.ReadLine());
            cobertura =  metrosQ / 3;
            latasNecessarias = cobertura / 18;
            if (latasNecessarias % 18 != 0)
            {
                latasNecessarias++;
            }
            else if (metrosQ > 0 && latasNecessarias == 0)
            {
                latasNecessarias = 1;
            }
            preco = latasNecessarias * 80;
            Console.WriteLine("latas a serem compradas: " + latasNecessarias);
            Console.WriteLine("preço total: " + preco);
            

            
            

        }
        static void exercicio16()
        {
            int p1, p2;
            p1 = int.Parse(Console.ReadLine());
            p2 = int.Parse(Console.ReadLine());
            if (p2 >= p1 + 2)
            {
                Console.WriteLine("O time de fora já se classificou");

            }
            else
            {
                Console.WriteLine("Os times se enfrentarão em um segundo jogo");
                int p11, p22;
                p11 = int.Parse(Console.ReadLine());
                p22 = int.Parse(Console.ReadLine());
                if (p22 > p11)
                {
                    Console.WriteLine("time de fora vencedor");

                }
                else if(p11>p22){
                    Console.WriteLine("time da casa vencedor");
                }
            }

        }
        
        static void exercicio17()
        {
            float a, b, c;
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());
            if (a <= b + c && b <= a + c && c <= a + b)
            {
                Console.WriteLine("É um triangulo");
                if (a == b && b == c)
                {
                    Console.WriteLine("Equilatero");
                }
                else if ((a == b && b != c)||(c==b&&b!=a)||(a==c&&c!=b))
                {
                    Console.WriteLine("Isoseles");
                }
                else if (a != b && b != c)
                {
                    Console.WriteLine("escaleno");
                }
            }
            else
            {
                Console.WriteLine("não forma um triangulo");
            }
        }
        static void exercicio18()
        {
            int a, b, c;
            
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b && b > c)
            {
                Console.WriteLine(a + " é o maior");
            }
            else if (b>a&&a>c)
            {
                Console.WriteLine(b + " é o maior");//b m
            }
            else if (c > b && b > a)
            {
                Console.WriteLine(c + " é o maior");//c m
            }

        }
        static void exercicio19()
        {
            int a, b, c;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            if (a > b && a > c)
            {
                Console.WriteLine(a + " é o maior");
                if (b > c)
                {
                    Console.WriteLine(b + "é o segundo maior");
                }
                else if (c > b)
                {
                    Console.WriteLine(c + "é o segundo maior");
                }
            }
            else if (b > a && b > c)
            {
                Console.WriteLine(b + " é o maior");//b m
                if (a > c)
                {
                    Console.WriteLine(a + "é o segundo maior");
                }
                else if (c > a)
                {
                    Console.WriteLine(c + "é o segundo maior");
                }
            }
            else if (c > b && c > a)
            {
                Console.WriteLine(a + " é o maior");//c m
                if (a > b)
                {
                    Console.WriteLine(a + "é o segundo maior");
                }
                else if (b > a)
                {
                    Console.WriteLine(b + "é o segundo maior");
                }
            }
        }
        static void exercicio20()
        {
            int num;
            int tentativa;
            int contador=0;
            Random rd = new Random();
            num = rd.Next(0, 10);
            Console.WriteLine(num);
            


            while (contador < 3) {
                tentativa = int.Parse(Console.ReadLine());
                if (tentativa == num)
                {
                    Console.WriteLine("Ganhou!");
                    return;
                }
                else
                {
                    contador++;
                    Console.WriteLine("ente novamente" + contador + " tentativas");
                }
            }
            if (contador >= 3) { Console.WriteLine("perdeu");
            }
           
            
            
                




        }
    }
        
        
    }
