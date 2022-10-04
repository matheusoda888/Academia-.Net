namespace lista5
{
    internal class lista5
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Qual exercicio da lista 5?");
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

                default:
                    Console.WriteLine("Questão invalida");
                    break;
            }
            static void exercicio1()
            {
                int[,] matrix = new int[5, 3];
                int i, j;
                for (i = 0; i < 5; i++)
                {

                    matrix[i, 0] = int.Parse(Console.ReadLine());
                    for (j = 0; j < 3; j++)
                    {

                        matrix[i, 1] = matrix[i, 0] + 10;
                        matrix[i, 2] = matrix[i, 1] * 2;


                    }


                }
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 3; j++)
                    {

                        Console.WriteLine(matrix[i, j]);
                    }
                }

            }
            static void exercicio2()
            {
                int i, j;
                int[,] matrix = new int[3, 3];
                int[] somaL = new int[3];
                int[] somaC = new int[3];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (i = 0; i < 3; i++)
                {
                    somaL[0] += matrix[0, i];
                    somaL[1] += matrix[1, i];
                    somaL[2] += matrix[2, i];
                    somaC[0] += matrix[i, 0];
                    somaC[1] += matrix[i, 1];
                    somaC[2] += matrix[i, 2];
                }
                for (i = 0; i < 3; i++)
                {

                    Console.WriteLine("Linha " + i + ":" + somaL[i]);



                }
                for (i = 0; i < 3; i++)
                {

                    Console.WriteLine("Coluna " + i + ":" + somaC[i]);



                }

            }

            static void exercicio3()
            {
                int i, j;
                int[,] matrix = new int[4, 4];
                for (i = 0; i < 4; i++)
                {

                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }


                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (i == j)
                        {
                            Console.WriteLine("posicao" + i + " " + j + ":" + matrix[i, j]);
                        }
                    }
                }
            }

            static void exercicio4()
            {
                int i, j;
                int[,] matrix = new int[5, 5];
                for (i = 0; i < 5; i++)
                {

                    for (j = 0; j < 5; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }


                }
                for (i = 0; i < 5; i++)
                {

                    for (j = 0; j < 5; j++)
                    {
                        if (matrix[i, j] % 2 == 0)
                        {
                            Console.WriteLine("linha " + i + " e coluna " + j + " : " + matrix[i, j] + " é par ");
                        }
                        else
                        {
                            Console.WriteLine("linha " + i + " e coluna " + j + " : " + matrix[i, j] + " é impar ");
                        }
                        if (matrix[i, j] > 0)
                        {
                            Console.WriteLine("linha " + i + " e coluna " + j + " : " + matrix[i, j] + " é positivo ");
                        }
                        else if (matrix[i, j] < 0)
                        {
                            Console.WriteLine("linha " + i + " e coluna " + j + " : " + matrix[i, j] + " é negativo ");
                        }
                        else
                        {
                            Console.WriteLine("linha " + i + " e coluna " + j + " : " + matrix[i, j] + " é zero ");
                        }
                    }


                }

            }

            static void exercicio5()
            {
                int i, j;
                double[,] matrix = new double[2, 3];
                double[,] matrix2 = new double[2, 3];
                double[,] soma = new double[2, 3];
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("matriz 1-- linha: " + i + " coluna: " + j);
                        matrix[i, j] = double.Parse(Console.ReadLine());

                    }
                }
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 3; j++)
                    {

                        Console.WriteLine("matriz 2 -- linha: " + i + " coluna: " + j);
                        matrix2[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 2; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        soma[i, j] = matrix[i, j] + matrix2[i, j];
                        Console.WriteLine(soma[i, j]);
                    }
                }


            }

            static void exercicio6()
            {
                int i, j;
                Random rd = new Random();
                int maior = 0;
                int maiorX = 0;
                int maiorY = 0;
                int[,] matrix = new int[4, 4];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine(i + "" + j);

                        matrix[i, j] = rd.Next(0, 10);
                        Console.WriteLine(matrix[i, j]);
                        if (matrix[i, j] > maior)
                        {


                            maior = matrix[i, j];
                            maiorX = i;
                            maiorY = j;

                        }
                    }
                }
                Console.WriteLine("maior numero: " + maior + " na posição: (" + maiorX + "," + maiorY + ")");
            }

            static void exercicio7()
            {
                int i, j;
                int[,] matrix = new int[3, 3];
                int[,] matrix2 = new int[3, 3];
                int[,] matrix3 = new int[3, 3];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("matrix 1 ---linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("matrix 2 ---linha: " + i + " coluna: " + j);
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        matrix3[i, j] = matrix[i, j] - matrix2[i, j];

                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("matrix 3 ---linha: " + i + " coluna: " + j);
                        Console.WriteLine(matrix3[i, j]);
                    }
                }
            }

            static void exercicio8()
            {
                int i, j;
                int[,] matrix = new int[4, 4];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("ordem normal");
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine(matrix[i, j]);

                    }
                }
                Console.WriteLine("ordem inversa:");
                for (i = 3; i > -1; i--)
                {
                    for (j = 3; j > -1; j--)
                    {
                        Console.WriteLine(matrix[i, j]);
                    }
                }
            }

            static void exercicio9()
            {
                int i, j;
                int[,] matrix = new int[3, 3];
                int n;
                bool exist = false;
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.WriteLine("digite um numero");
                n = int.Parse(Console.ReadLine());
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if (matrix[i, j] == n)
                        {
                            exist = true;
                        }
                    }
                }
                if (exist)
                {
                    Console.WriteLine("numero existente");
                }
                else
                {
                    Console.WriteLine("numero inexistente");
                }
            }

            static void exercicio10()
            {
                int i, j;
                int[,] matrix = new int[4, 4];
                int[,] matrix2 = new int[4, 4];
                int[] media = new int[4];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 1 ---linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 2 ---linha: " + i + " coluna: " + j);
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        media[i] = (matrix2[i, j] + matrix[i, j]) / 2;
                        Console.WriteLine(media[i]);
                    }
                }
                for (i = 0; i < 4; i++)
                {

                    if (media[i] >= 7)
                    {
                        Console.WriteLine(media[i] + " esta acima da media");
                    }

                }


            }

            static void exercicio11()
            {
                int i, j;
                double[,] matrix = new double[3, 3];
                double[,] matrixS = new double[3, 3];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        matrixS[i, j] = matrix[i, j]/ (i + j);

                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        Console.WriteLine(matrixS[i, j]);

                    }
                }
            }

            static void exercicio12()
            {
                int i, j;
                double[,] matrix = new double[4, 3];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        if ((i + j) % 2 == 0)
                        {
                            Console.WriteLine(matrix[i, j]);
                        }
                    }
                }
            }

            static void exercicio13()
            {
                int i, j;
                double[,] matrix = new double[5, 5];
                double[] principal = new double[5];
                double[] secundaria = new double[5];
                double somaP=0, somaS=0;
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                
                for (i = 0; i < 5; i++)
                {

                    principal[i] = matrix[i, i];
                    Console.WriteLine(matrix[i,i]);
                    somaP += principal[i];

                    
                }
                for(i = 0; i < 5; i++)
                {
                    secundaria[i] = matrix[i, 5 - 1 - i];
                    Console.WriteLine(matrix[i, 5 - 1 - i]);
                    somaS += secundaria[i];
                }
                if (somaS == somaP)
                {
                    Console.WriteLine("as somas são iguais");
                }
                else
                {
                    Console.WriteLine("as somas não são iguais");
                }

            }

            static void exercicio14()
            {
                int i, j;
                double[,] matrix = new double[5, 5];
                double[] principal = new double[5];
                double[] secundaria = new double[5];
                bool igual = true;
                
                for (i = 0; i < 5; i++)
                {
                    for (j = 0; j < 5; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                for (i = 0; i < 5; i++)
                {

                    principal[i] = matrix[i, i];
                    Console.WriteLine(matrix[i, i]);
                    


                }
                for (i = 0; i < 5; i++)
                {
                    secundaria[i] = matrix[i, 5 - 1 - i];
                    Console.WriteLine(matrix[i, 5 - 1 - i]);
                    
                }
                for(i=0; i < 5; i++)
                {
                    if (principal[i] != secundaria[i])
                    {
                        igual = false;
                    }
                }
                if (igual)
                {
                    Console.WriteLine("diagonais iguais");
                }
                else
                {
                    Console.WriteLine("diagonais diferentes");
                }
                

            }

            static void exercicio15()
            {
                int i, j;
                double[,] matrix = new double[4, 4];
                double[,] matrix2 = new double[4, 4];
                double[,] matrix3 = new double[4, 4];
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 1 ----linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 2 ----linha: " + i + " coluna: " + j);
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 1 ----linha: " + i + " coluna: " + j);
                        matrix3[i, j] = matrix2[i, j]+ matrix[i, j];
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("linha: " + i + " coluna: " + j);
                        Console.WriteLine(matrix3[i, j]);
                        
                    }
                }

            }

            static void exercicio16()
            {
                int i, j;
                double[,] matrix = new double[3, 4];
                double[,] matrix2 = new double[4, 3];
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 1 ----linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 3; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        matrix2[j,i]=matrix[i,j];
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 3; j++)
                    {
                        Console.WriteLine("matrix 2 ----linha: " + i + " coluna: " + j);
                        Console.WriteLine(matrix2[i,j]);
                        
                    }
                }

            }
            
            static void exercicio17()
            {
                int i, j;
                double[,] matrix = new double[4, 4];
                double[,] matrix2 = new double[4, 4];
                double menor = 0;
                int xMenor=0;
                int yMenor=0;
                double maior = 0;
                double xMaior=0;
                double yMaior=0;
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        Console.WriteLine("matrix 1 ----linha: " + i + " coluna: " + j);
                        matrix[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                for (i = 0; i < 4; i++)
                {
                    for (j = 0; j < 4; j++)
                    {
                        if (matrix[i, j] < menor)
                        {
                            menor=matrix[i, j];
                            xMenor = i;
                            yMenor = j;
                        }
                    }
                }
                for (j = 0; j < 4; j++)
                {
                   if( matrix[xMenor,j]>maior)
                    {
                        maior = matrix[xMenor, j];
                    }
                }
                Console.WriteLine("minmax: " + maior);
                


            }
        }
    }
}
