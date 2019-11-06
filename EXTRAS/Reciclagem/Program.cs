using System;
using System.Collections.Generic;
using Reciclagem.Models;
using Reciclagem.Interfaces;
using System.Linq;

namespace Reciclagem
{
    enum TipoEnum : uint
    {
        GARRAFA,
        GARRAFA_PET,
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

        public static void Reciclar(Lixo lixo)
        {

            Type tipoLixo = lixo.GetType().GetInterfaces().FirstOrDefault();

            if (tipoLixo.Equals(typeof(IPapel)))
            {
                IPapel lixoConvertido = (IPapel)lixo;
                Console.BackgroundColor = ConsoleColor.Blue;
                System.Console.WriteLine($"{lixoConvertido.LixoPapel()} deve ir para a lixeira Azul");
                Console.ResetColor();

            }
            else if (tipoLixo.Equals(typeof(IMetais)))
            {
                IMetais lixoConvertido = (IMetais)lixo;
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.LixoMetal()} deve ir para a lixeira Amarela");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IPlastico)))
            {
                IPlastico lixoConvertido = (IPlastico)lixo;
                Console.BackgroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"{lixoConvertido.LixoPlastico()} deve ir para a lixeira Vermelha");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IVidro)))
            {
                IVidro lixoConvertido = (IVidro)lixo;
                Console.BackgroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"{lixoConvertido.LixoVidro()} deve ir para a lixeira Verde");
                Console.ResetColor();
            }
            else if (tipoLixo.Equals(typeof(IOrganico)))
            {
                IOrganico lixoConvertido = (IOrganico)lixo;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                System.Console.WriteLine($"{lixoConvertido.LixoOrganico()} deve ir para a Composteira");
                Console.ResetColor();
            }
            
            System.Console.WriteLine("Aperte ENTER para voltar ao menu principal");
            Console.ReadLine();
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


