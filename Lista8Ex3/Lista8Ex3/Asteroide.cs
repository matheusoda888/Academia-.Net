using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista8Ex3
{
    internal class Asteroide
    {
        int posicaoX;
        int posicaoY;
        int tamanho;
        int velocidade;
        int energia;
        public Asteroide(int posicaoX, int posicaoY, int tamanho, int velocidade, int energia)
        {
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            this.tamanho = tamanho;
            this.velocidade = velocidade;
            this.energia = energia;
        }
        public Asteroide()
        {

        }
        public Asteroide(int posicaoX, int posicaoY)
        {
            Random rand = new Random();
            this.posicaoX = posicaoX;
            this.posicaoY = posicaoY;
            this.velocidade = rand.Next(1, 5);
            this.tamanho = rand.Next(1, 10);
            this.energia = rand.Next(1, 5);
        }
        public int getPosicaoX()
        {
            return posicaoX;
        }
        public void setPosicaoX(int valor)
        {
            this.posicaoX = valor;
        }
        public int getPosicaoY()
        {
            return posicaoY;
        }
        public void setPosicaoY(int valor)
        {
            this.posicaoY = valor;
        }
        public int getTamanho()
        {
            return tamanho;
        }
        public void setTamanho(int valor)
        {
            this.tamanho = valor;
        }
        public int getVelocidade()
        {
            return velocidade;
        }
        public void setVelocidade(int valor)
        {
            this.velocidade = valor;
        }
        public int getEnergia()
        {
            return energia;
        }
        public void setEnergia(int valor)
        {
            this.energia = valor;
        }


    }
}
