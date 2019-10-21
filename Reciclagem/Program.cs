using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interfaces;

namespace Reciclagem
{
    enum TipoEnum : uint
    {
        GARRAFA,
        GARRAFAPET,
        GUARDA_CHUVA,
        LATINHA,
        PAPELÃO,
        POTE_MANTEIGA

    }
    class Program
    {
        static void Main(string[] args)
        {
            bool querSair = false;
            string[] itensMenuPrincipal = Enum.GetNames(typeof(TipoEnum));

            var opcoesLixeira = new List<string>() {
                "    - 0                         ",
                "    - 1                         ",
                "    - 2                         ",
                "    - 3                         ",
                "    - 4                         ",
                "    - 5                         ",
            };

            int opcaoLixeiraSelecionada = 0;

            string menuBar = "=======================================";
        do{
            bool lixeiraEscolhida = false;

            do{

            Console.Clear();
            System.Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("               RECICLAGEM              ");
            System.Console.WriteLine("        Escolha um tipo de lixo        ");
            Console.ResetColor();
            System.Console.WriteLine(menuBar);

            #region Troca a cor do item do menu.
                    for (int i = 0; i < opcoesLixeira.Count; i++)
                    {
                        string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

                        if (opcaoLixeiraSelecionada == i)
                        {
                            DestacarOpcao(opcoesLixeira[opcaoLixeiraSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
                        }
                        else
                        {
                            System.Console.WriteLine(opcoesLixeira[i].Replace(i.ToString(), titulo));
                        }
                    }
            #endregion
            
            #region Lê a tecla pressionada pelo usuário e verifica a opção selecionada.
                    var key = Console.ReadKey(true).Key;

                    switch (key)
                    {
                        case ConsoleKey.UpArrow:
                            opcaoLixeiraSelecionada = opcaoLixeiraSelecionada == 0 ? opcaoLixeiraSelecionada : --opcaoLixeiraSelecionada;
                            break;

                        case ConsoleKey.DownArrow:
                            opcaoLixeiraSelecionada = opcaoLixeiraSelecionada == opcoesLixeira.Count - 1 ? opcaoLixeiraSelecionada : ++opcaoLixeiraSelecionada;
                            break;

                        case ConsoleKey.Enter:
                            lixeiraEscolhida = true;
                            break;
                    }
                    #endregion

                } while (!lixeiraEscolhida);

            }while(!querSair);
            
        }

        public static void DestacarOpcao(string opcao)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            System.Console.WriteLine(opcao);
            Console.ResetColor();
        }

        public static string TratarTituloMenu(string titulo)
        {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace("_", " ").ToLower());
        }
    }
}
