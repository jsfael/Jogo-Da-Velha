
using System.ComponentModel.Design;
using System.Drawing;
using System.Linq.Expressions;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Jogo_da_velha_by_jsfael
{
    class JogoDaVelha
    {
        private bool fimDeJogo;
        private char[] posicoes;
        private char vez;
        private int quantidadePreenchida;

        public JogoDaVelha()
        {   
            fimDeJogo = false;
            posicoes = new[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            vez = 'X';
            quantidadePreenchida = 0;
        }

        public void Iniciar()
        {
            while (!fimDeJogo)
            {
                
                RenderizarTabela();
                LerEscolhaDoUsuario();
                RenderizarTabela();
                VerficarFimDeJogo();
                MudarVez();
                Reiniciar();

                
            }
        }
        public static void Loading(string ocorrido)
        {

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.Write(ocorrido);
            Console.BackgroundColor = ConsoleColor.Red;
            Thread.Sleep(550);
            Console.Write(".");
            Console.BackgroundColor = ConsoleColor.Yellow;
            Thread.Sleep(550); ;
            Console.Write(".");
            Console.BackgroundColor = ConsoleColor.Green;
            Thread.Sleep(550);
            Console.Write(".");
            Thread.Sleep(750);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void Reiniciar()
        {
            if (fimDeJogo == true)
            {
                Console.WriteLine(" Você quer jogar denovo? \n    =============\n   y = sim n = não");
                var resposta = Console.ReadLine();

                if (char.Parse(resposta) == 'y')
                {
                    Loading("Reiniciando Jogo");
                    new JogoDaVelha().Iniciar();
                }
                else if (char.Parse(resposta) == 'n')
                {
                    Loading("Fechando Jogo");
                    System.Environment.Exit(0);
                }
                else
                {
                    Console.Clear();
                    Reiniciar();
                }
            }
        }
        private void MudarVez()
        {
            vez = vez == 'X' ? 'O' : 'X';
        }

        private void VerficarFimDeJogo()
        {
            if (quantidadePreenchida < 5)
                return;

            if (ExisteVitoriaHorizontal() || ExisteVitoriaVertical() || ExisteVitoriaDiagonal())
            {
                fimDeJogo = true;
                Console.WriteLine($"Fim de jogo!!! Vitória de {vez}\n");
                return;
               

            }

            if (quantidadePreenchida is 9)
            {
                fimDeJogo = true;
                Console.WriteLine("Fim de jogo!!! EMPATE\n");
               // Console.ReadLine();
                
            }
           
        }

        private bool ExisteVitoriaHorizontal()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[1] && posicoes[0] == posicoes[2];
            bool vitoriaLinha2 = posicoes[3] == posicoes[4] && posicoes[3] == posicoes[5];
            bool vitoriaLinha3 = posicoes[6] == posicoes[7] && posicoes[6] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        private bool ExisteVitoriaVertical()
        {
            bool vitoriaLinha1 = posicoes[0] == posicoes[3] && posicoes[0] == posicoes[6];
            bool vitoriaLinha2 = posicoes[1] == posicoes[4] && posicoes[1] == posicoes[7];
            bool vitoriaLinha3 = posicoes[2] == posicoes[5] && posicoes[2] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2 || vitoriaLinha3;
        }

        private bool ExisteVitoriaDiagonal()
        {
            bool vitoriaLinha1 = posicoes[2] == posicoes[4] && posicoes[2] == posicoes[6];
            bool vitoriaLinha2 = posicoes[0] == posicoes[4] && posicoes[0] == posicoes[8];

            return vitoriaLinha1 || vitoriaLinha2;
        }

        private void LerEscolhaDoUsuario()
        {

            try
            {
                Console.WriteLine($"Agora é a vez de {vez}, entre uma posição de 1 a 9 que esteja disponível na tabela");

                bool conversao = int.TryParse(Console.ReadLine(), out int posicaoEscolhida);

                while (!conversao || !ValidarEscolhaUsuario(posicaoEscolhida))
                {
                    Console.WriteLine("O campo escolhido é inválido, por favor digite um número entre 1 e 9 que esteja disponível na tabela.");
                    conversao = int.TryParse(Console.ReadLine(), out posicaoEscolhida);

                }
                PreencherEscolha(posicaoEscolhida);
            }
            catch (IndexOutOfRangeException)
            {
                Console.Clear();
                RenderizarTabela();
                LerEscolhaDoUsuario();
            }
            
        }

        private void PreencherEscolha(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;
            
            posicoes[indice] = vez;
            quantidadePreenchida++;
        }

        private bool ValidarEscolhaUsuario(int posicaoEscolhida)
        {
            int indice = posicaoEscolhida - 1;

            
            return posicoes[indice] != 'O' && posicoes[indice] != 'X';
             
           
        }

        private void RenderizarTabela()
        {
            Console.Clear();
            Console.WriteLine(ObterTabela());
        }

        private string ObterTabela()
        {
            return $"__{posicoes[0]}__|__{posicoes[1]}__|__{posicoes[2]}__\n" +
                   $"__{posicoes[3]}__|__{posicoes[4]}__|__{posicoes[5]}__\n" +
                   $"  {posicoes[6]}  |  {posicoes[7]}  |  {posicoes[8]}  \n\n";
        }
    }
}