using System;

namespace triangulo {
    class Program {
        static void Main (string[] args) {
            int altu;
            int taman;
            int compr;
            string func;

            do {
                Console.Clear();
                Console.WriteLine ("Digite o Tamanho: ");
                altu = int.Parse (Console.ReadLine ());
                
                for (compr = 1; compr <= altu; compr++) {
                    for (taman = 1; taman <= compr; taman++)
                        Console.Write ("*");
                    Console.Write ("\n");
                }

                System.Console.WriteLine("|(1) Ir Novamente|(0) Sair|");
                func = Console.ReadLine();

            }while(func == "1");
        }
    }
}