using System;
using MateODragão.Models;

namespace MateODragão {
    class Program {
        static void Main (string[] args) {
            bool jogadorNaoDesistiu = true;
            do {

                System.Console.WriteLine ("=====================================");
                System.Console.WriteLine ("           Mate o Dragão");
                System.Console.WriteLine ("=====================================");

                System.Console.WriteLine (" 1 - Iniciar Jogo");
                System.Console.WriteLine (" 0 - Sair do Jogo");

                string opcaoJogador = Console.ReadLine ();

                switch (opcaoJogador) {
                    case "1":
                        Console.Clear ();
                        Guerreiro guerreiro = new Guerreiro ();
                        guerreiro.Nome = "Jailson";
                        guerreiro.Sobrenome = "A Besta";
                        guerreiro.CidadeNatal = "Bahia";
                        guerreiro.DataNascimento = DateTime.Parse ("29/03/1300");
                        guerreiro.FerramentaAtaque = "Espada";
                        guerreiro.FerramentaProtecao = "Escudo Braçal";
                        guerreiro.Forca = 3;
                        guerreiro.Destreza = 2;
                        guerreiro.Inteligencia = 4;
                        guerreiro.Vida = 20;

                        Dragao dragao = new Dragao ();
                        dragao.Nome = "Dragonildo";
                        dragao.Forca = 5;
                        dragao.Destreza = 1;
                        dragao.Inteligencia = 3;
                        dragao.Vida = 300;

                        /* INICIO - Primeiro Dialogo */
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}:{dragao.Nome}, Ola meu caro confrade, gostaria de travar uma batalha com o senhor ");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Ola meu caro senhor, estou disposto\n");

                        System.Console.WriteLine ();
                        System.Console.WriteLine ("Aperte ENTER para prosseguir");
                        Console.ReadLine ();
                        /* FIM - Primeiro Dialogo */

                        /* INICIO - Segundo Dialogo */
                        Console.Clear ();
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Eu sou {guerreiro.Nome} {guerreiro.Sobrenome}; seu arrombado!");
                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Diretamente da {guerreiro.CidadeNatal} eu vim te passar o acarajé meu rei");

                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Vai dormir baiano fliha da puta");
                        Console.ReadLine ();
                        /* FIM - Segundo Dialogo */
                        Console.Clear ();

                        bool jogadorAtacaPrimeiro = guerreiro.Destreza > dragao.Destreza ? true : false;

                        bool jogadorNaoCorreu = true;

                        int poderAtaqueGuerreiro = guerreiro.Forca > guerreiro.Inteligencia ? guerreiro.Forca + guerreiro.Destreza : guerreiro.Inteligencia + guerreiro.Destreza;

                        /*INICIO - da TRETA*/
                        if (jogadorAtacaPrimeiro) {
                            Console.Clear ();

                            System.Console.WriteLine ("***Turno do Jogador***");
                            System.Console.WriteLine ("Escolha sua ação:");
                            System.Console.WriteLine ("1 - Atacar");
                            System.Console.WriteLine ("2 - Fugir");

                            string opcaoBatalhaJogador = Console.ReadLine ();

                            switch (opcaoBatalhaJogador) {
                                case "1":
                                    Random geradorNumeroAleatorio = new Random ();
                                    int NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                    int NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                    int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                    int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioJogador;

                                    if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Ficou a noite inteira secando o dragão? FIQUEI PIRANHA E O DRAGÃO TOMOU NO CU, SE FUDEU");
                                        dragao.Vida -= poderAtaqueGuerreiro + 5;
                                        System.Console.WriteLine ("--------------");
                                        System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                        System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                    } else {
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou ai otario");
                                    }

                                    break;
                                case "2":
                                    jogadorNaoCorreu = false;
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: SAI NEGÃO");
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Eu vo comer seu cu");
                                    break;
                            }

                            System.Console.WriteLine ("Aperte ENTER para prosseguir");
                            Console.ReadLine ();

                            while (dragao.Vida > 0 && guerreiro.Vida > 0 && jogadorNaoCorreu) {
                                Console.Clear ();
                                System.Console.WriteLine ("*** Turno do Dragão ***");
                                Random geradorNumeroAleatorio = new Random ();
                                int NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                int NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                int guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                int dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioJogador;

                                if (dragaoDestrezaTotal > guerreiroDestrezaTotal) {
                                    System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Dale na narguilera");
                                    guerreiro.Vida -= dragao.Forca;
                                    System.Console.WriteLine ("--------------");
                                    System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                    System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                } else {
                                    System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Isso ai é esse tal de narguines que você andou fumando");
                                }
                                System.Console.WriteLine ();
                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                /*INICIO - Turno Jogador */
                                Console.Clear ();
                                System.Console.WriteLine ("***Turno do Jogador***");
                                System.Console.WriteLine ("Escolha sua ação:");
                                System.Console.WriteLine ("1 - Atacar");
                                System.Console.WriteLine ("2 - Fugir");

                                opcaoBatalhaJogador = Console.ReadLine ();

                                switch (opcaoBatalhaJogador) {
                                    case "1":
                                        geradorNumeroAleatorio = new Random ();
                                        NumeroAleatorioJogador = geradorNumeroAleatorio.Next (0, 5);
                                        NumeroAleatorioDragao = geradorNumeroAleatorio.Next (0, 5);

                                        guerreiroDestrezaTotal = guerreiro.Destreza + NumeroAleatorioJogador;
                                        dragaoDestrezaTotal = dragao.Destreza + NumeroAleatorioJogador;

                                        if (guerreiroDestrezaTotal > dragaoDestrezaTotal) {
                                            System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: Ficou a noite inteira secando o dragão? FIQUEI PIRANHA E O DRAGÃO TOMOU NO CU, SE FUDEU");
                                            dragao.Vida -= poderAtaqueGuerreiro + 5;
                                            System.Console.WriteLine ("--------------");
                                            System.Console.WriteLine ($"HP Dragão: {dragao.Vida}");
                                            System.Console.WriteLine ($"HP Guerreiro: {guerreiro.Vida}");
                                        } else {
                                            System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Errou ai otario");
                                        }

                                        break;
                                    case "2":
                                        jogadorNaoCorreu = false;
                                        System.Console.WriteLine ($"{guerreiro.Nome.ToUpper()}: SAI NEGÃO");
                                        System.Console.WriteLine ($"{dragao.Nome.ToUpper()}: Eu vo comer seu cu");
                                        break;
                                }

                                System.Console.WriteLine ("Aperte ENTER para prosseguir");
                                Console.ReadLine ();
                                /*FIM - Turno Jogador */
                            }

                        }
                        /*FIM - da TRETA*/

                        break;
                    case "0":
                        jogadorNaoDesistiu = false;
                        break;
                    default:
                        System.Console.WriteLine ("Comando desconhecido");
                        break;
                }
            } while (jogadorNaoDesistiu);

        }
    }
}