using System;

namespace Múltiplo_de_3 {
    class Program {
        static void Main (string[] args) {
            double n = 0;
            string func;

            do {
                Console.Clear ();
                System.Console.WriteLine ("Digite um número");
                n = double.Parse(Console.ReadLine());

                if (n % 3 == 0) {
                    System.Console.WriteLine ("Esse numero é múltiplo de 3");
                } else {
                    System.Console.WriteLine ("Esse numero não é múltiplo de 3");
                }

                System.Console.WriteLine ("|(1) Ir Novamente|(0) Sair|");
                func = Console.ReadLine ();

            } while (func == "1");
        }
    }
}