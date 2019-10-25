using System;

namespace Verbo_no_Infinitivo {
    class Program {
        static void Main (string[] args) {
            int meses;
            string func;

            do {
                Console.Clear ();
                System.Console.WriteLine ("Escolha um mês");
                System.Console.WriteLine ("|(1)|(2)|(3)|(4)|(5)|(6)|(7)|(8)|(9)|(10)|(11)|(12)|");
                meses = int.Parse (Console.ReadLine ());

                switch (meses) {
                    case 1:
                        System.Console.WriteLine ("Janeiro");
                        break;

                    case 2:
                        System.Console.WriteLine ("Fevereiro");
                        break;

                    case 3:
                        System.Console.WriteLine ("Março");
                        break;

                    case 4:
                        System.Console.WriteLine ("Abril");
                        break;

                    case 5:
                        System.Console.WriteLine ("Maio");
                        break;

                    case 6:
                        System.Console.WriteLine ("Junho");
                        break;

                    case 7:
                        System.Console.WriteLine ("Julho");
                        break;

                    case 8:
                        System.Console.WriteLine ("Agosto");
                        break;

                    case 9:
                        System.Console.WriteLine ("Setembro");
                        break;

                    case 10:
                        System.Console.WriteLine ("Outubro");
                        break;

                    case 11:
                        System.Console.WriteLine ("Novembro");
                        break;

                    case 12:
                        System.Console.WriteLine ("Dezembro");
                        break;
                }

                System.Console.WriteLine ("|(1) Ir Novamente|(0) Sair|");
                func = Console.ReadLine ();

            } while (func == "1");

        }
    }
}