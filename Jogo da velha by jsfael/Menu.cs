using System;

namespace Jogo_da_velha_by_jsfael
{
    internal class Menu
    {
        public static void Show()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            DrawnScreen();
            WriteOptions();

            var option = short.Parse(Console.ReadLine());
            HandleMenuOption(option);

            Console.ReadLine();


        }

        public static void maisEmenos()
        {
            Console.Write("+");
            for (int i = 0; i <= 30; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");
        }
        public static void DrawnScreen()
        {

            maisEmenos();

            for (int lines = 0; lines < 13; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 30; i++)
                {
                    Console.Write(' ');
                }
                Console.Write("|");
                Console.Write('\n');

            }
            maisEmenos();



        }
        public static void Loading(string ocorrido) {
            
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

        public static void WriteOptions()
        {
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("Jogo da Velha");
            Console.SetCursorPosition(10, 3);
            Console.WriteLine("=============");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("Selecione uma opção abaixo:");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("1 - Iniciar Jogo");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("0 - Sair");
            Console.Write("| Opção :");
        }
        public static void HandleMenuOption(short option)
        {
            switch (option)
            {
                case 1:
                    {
                        Loading("Iniciando Jogo");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Console.ForegroundColor = ConsoleColor.White;

                        new JogoDaVelha().Iniciar(); break;
                    }
                case 0:
                    {
                        Loading("Fechando Menu");

                        Environment.Exit(0);
                        break;
                    }
                default: Show(); break;

            }

        }
    }
}
