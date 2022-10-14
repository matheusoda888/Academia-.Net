namespace Lista8Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, Asteroide> asteroids = new Dictionary<int, Asteroide>();
            Asteroide asteroide = new Asteroide();
            int posicaoX=5;
            int posicaoY=5;
            
            asteroide=new Asteroide(posicaoX, posicaoY,5,3,2);
            asteroids.Add(0, asteroide);
            for(int ind = 1;  ; )
            {
                
                Console.WriteLine("digite o x do asteroide");
                posicaoX = int.Parse(Console.ReadLine());
                Console.WriteLine("digite o y do asteroide");
                posicaoY = int.Parse(Console.ReadLine());
                asteroide = new Asteroide(posicaoX, posicaoY);
                asteroids.Add(ind, asteroide);
                ind++;
                Console.WriteLine("digite ZERO para sair");
                int continuar = 1;
                continuar = int.Parse(Console.ReadLine());
                if(continuar == 0)
                {
                    break;
                }
            }
            foreach(KeyValuePair<int,Asteroide> item in asteroids)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine("X: "+item.Value.getPosicaoX());
                Console.WriteLine("Y: " + item.Value.getPosicaoY());
                Console.WriteLine("energia: " + item.Value.getEnergia());
                Console.WriteLine("Tamanho: " + item.Value.getTamanho());
                Console.WriteLine("Velocidade: " + item.Value.getVelocidade());
            }
            
        }
    }
}