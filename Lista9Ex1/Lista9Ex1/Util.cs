using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9Ex1
{
    internal class Util
    {
        public static void gravar(string frase, string nomeArquivo)
        {
            StreamWriter escritor = new StreamWriter(nomeArquivo, append: true);
            escritor.WriteLine(frase.ToUpper());
            escritor.Flush();
            escritor.Close();
        }
        public static void popularArquivo(List<string> lista, string nomeArquivo)
        {
            try
            {
                StreamReader leitor = new StreamReader(nomeArquivo);
                do
                {
                    lista.Add(leitor.ReadLine().ToUpper());
                } while (!leitor.EndOfStream);

                leitor.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
