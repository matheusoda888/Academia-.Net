namespace Lista9Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> frases = new List<string>();
            string frase = "";

            Util.popularArquivo(frases, "nomeArquivo.txt");
            while (true)
            {
                
                Console.WriteLine("digite uma frase ou sair");
                frase = Console.ReadLine();
                    if(frase.ToUpper() == "SAIR")
                    {
                    
                        break;
                    }


                //adicionar a lista caso não exista ainda na mesma
                if (frases.Contains(frase.ToUpper()))
                {
                    Console.WriteLine("Frase ja cadastrada");
                }
                else if(!frase.StartsWith(" ")&& !frase.EndsWith(" ")&&frase.Contains(" ")){
                    frases.Add(frase.ToUpper());
                    //Gravar frase no arquivo
                    Util.gravar(frase, "nomeArquivo.txt");
                }
                else
                {
                    Console.WriteLine("somente nomes completos");
                    
                }

                
               
            }
            foreach(string item in frases)
            {
                Console.WriteLine(item);
            }
            //Util.gravar(frase,"nomeDoArquivo.txt");
        }
    }
}