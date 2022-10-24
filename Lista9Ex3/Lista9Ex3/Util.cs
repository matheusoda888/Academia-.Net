using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista9Ex3
{
    internal class Util
    {
        Figurinha figurinha;
        public static void escrever(Figurinha figurinha, string nomeArquivo)
        {
            StreamWriter writer = new StreamWriter(nomeArquivo,append:true);
            writer.WriteLine(figurinha.codigo_figurinha+";"+figurinha.nome_jogador+";"+figurinha.selecao);
            writer.Close();
        }
        public static void popular(List<Figurinha> figurinhas, string nomeArquivo)
        {
            try
            {
                string linha;
                string[] dadosLinha;
                Figurinha figurinha;
                StreamReader reader = new StreamReader(nomeArquivo);
                do
                {
                    linha = reader.ReadLine();
                    dadosLinha = linha.Split(";");
                    figurinha = new Figurinha(dadosLinha[0], dadosLinha[2], dadosLinha[1]);
                    figurinhas.Add(figurinha);
                } while (!reader.EndOfStream);
                reader.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void mostrarListaFigurinhas(List<Figurinha> lista)
        {
            foreach (var i in lista)
            {
                Console.WriteLine("Codigo: "+ i.codigo_figurinha+ "Nome: " + i.nome_jogador + ". selecao: " + i.selecao);
            }
        }

    }
}
