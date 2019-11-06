using System.Collections.Generic;
using System;

namespace ZooLogico
{
    enum AnimaisEnum : uint
    {
        ARARA,
        TUBARÃO_MARTELO,
        TUCANO,
        LEÃO,
        ORANGOTANGO,
        CHIMPANZÉ,
        PINGUIM,
        TARTARUGA,
        GOLFINHO


    }
    class Program
    {
        static void Main(string[] args)
        {
                string menuBar = "========================";

                System.Console.WriteLine(menuBar);
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("       ZOOLÓGICO        ");
                System.Console.WriteLine("     Seja bem vindo     ");
                Console.ResetColor();
                System.Console.WriteLine(menuBar);

                ExibirMenuDeAnimais();

                #region Lê a tecla pressionada pelo usuário e verifica a opção selecionada.
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoAnimalSelecionado = opcaoAnimalSelecionado == 0 ? opcaoAnimalSelecionado : --opcaoAnimalSelecionado;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoAnimalSelecionado = opcaoAnimalSelecionado == opcoesAnimal.Count - 1 ? opcaoAnimalSelecionado : ++opcaoAnimalSelecionado;
                            break;

                        case ConsoleKey.Enter:
                            animalEscolhido = true;
                            break;
                    }
                    #endregion

    
        }

        public static void ExibirMenuDeAnimais()
        {
            var animais = Enum.GetNames(typeof(AnimaisEnum));
            int codigo = 1;
            string menuAnimaisBorda = "#########################";

            System.Console.WriteLine(menuAnimaisBorda);
            System.Console.WriteLine("#                       #");
            System.Console.WriteLine("#        ANIMAIS        #");
            System.Console.WriteLine("#                       #");
            System.Console.WriteLine(menuAnimaisBorda);

            foreach (var animal in animais)
            {
                System.Console.WriteLine($"  {codigo++}.{TratarTituloMenu(animal)}");
            }

            System.Console.WriteLine(menuAnimaisBorda);

            var opcoesAnimal = new List<string>() {
                "    - 0                         ",
                "    - 1                         ",
                "    - 2                         ",
                "    - 3                         ",
                "    - 4                         ",
                "    - 5                         ",
                "    - 6                         ",
                "    - 7                         ",
                "    - 8                         ", 
            };

        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }

    }
}
