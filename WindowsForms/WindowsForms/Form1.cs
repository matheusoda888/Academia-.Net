using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (File.Exists("jogador.dat"))
            {
                StreamReader leitor = new StreamReader("jogador.dat");

                string linha;
                string[] vetorDados;
                do
                {
                    linha = leitor.ReadLine();
                    vetorDados = linha.Split(';');
                    listaJogadores.Add(new Jogador(vetorDados[0], vetorDados[1]));
                    textBox_listaJogadores.AppendText(vetorDados[0] + " - " + vetorDados[1] + Environment.NewLine);

                } while (!leitor.EndOfStream);
                
                leitor.Close();
            }
        }

        private void buttonGravar_MouseClick(object sender, MouseEventArgs e)
        {

            if (textBox_nomeJogador.Text == "")
            {
                return; 
            }
            textBox_nomeJogador.Text = textBox_nomeJogador.Text.ToUpper();
            string email;

            if (Jogador.jaCadastrado(textBox_nomeJogador.Text, listaJogadores))
            {
                return;
            }
            else
            {
                string[] vetorNomes = textBox_nomeJogador.Text.ToLower().Split(' ');

                if (vetorNomes.Length > 1)
                {
                    email = vetorNomes[vetorNomes.Length - 1] + "." + vetorNomes[0] + "@ufn.edu.br" ;
                }
                else
                {
                    email =vetorNomes[0] + "@ufn.edu.br";
                }
                listaJogadores.Add(new Jogador(textBox_nomeJogador.Text, email));
                textBox_listaJogadores.AppendText(textBox_nomeJogador.Text+" - "+ email + Environment.NewLine);
                
                StreamWriter escritor = new StreamWriter("jogador.dat", true);
                escritor.WriteLine(textBox_nomeJogador.Text + ";" + email);
                escritor.Close();

            }
            textBox_nomeJogador.Text = "";
            
        }

        private void buttonLimpar_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_nomeJogador.Text = "";
            textBox_listaJogadores.Text = "";
            listaJogadores.Clear();
            StreamReader leitor = new StreamReader("jogador.dat");
            
            string linha;
            string[] vetorDados;
            do
            {
                linha = leitor.ReadLine();
                vetorDados = linha.Split(';');
                
                

            } while (!leitor.EndOfStream);


            leitor.Close();
            StreamWriter escritor = new StreamWriter("jogador.dat", append: false);
            escritor.WriteLine("");
            escritor.Close();
        }
        List<Jogador> listaJogadores = new List<Jogador>();
    }
}
