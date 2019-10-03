using System;
using ByteBank.Models;

namespace ByteBank {
    class Program {
        private static bool senhaOk;

        static void Main (string[] args) {
            System.Console.WriteLine ("----------------------------");
            System.Console.WriteLine ("         ByteBank");
            System.Console.WriteLine ("----------------------------");

            System.Console.WriteLine ($"CPF:");
            string Cpf = Console.ReadLine ();

            System.Console.WriteLine ($"Nome:");
            string Nome = Console.ReadLine ();

            System.Console.WriteLine ($"Email:");
            string Email = Console.ReadLine ();

            Login login1 = new Login (Nome, Cpf, Email);

            do {
                System.Console.WriteLine ("Digite a Senha");
                string senha = Console.ReadLine ();
                senhaOk = login1.TrocaSenha (senha);
                if (!senhaOk) {
                    System.Console.WriteLine ("Senha não atende aos requsitos");
                } else {
                    System.Console.WriteLine ("Senha Trocada com sucesso");
                }
            } while (!senhaOk);

            System.Console.WriteLine ("Conta Corrente");

            System.Console.WriteLine ($"Titular:");
            string Titular = Console.ReadLine ();

            System.Console.WriteLine ($"Agencia:");
            string Agencia = Console.ReadLine ();

            System.Console.WriteLine ($"Numero:");
            string Numero = Console.ReadLine ();

            bool saldoValido = false;

            do {
                System.Console.WriteLine ("Digite a Senha");
                double saldo = double.Parse (Console.ReadLine ());
                if (saldo >= 0) {
                    saldoValido = true;
                } else {
                    System.Console.WriteLine ("O saldo não pode ser negativo");
                }
            } while (!saldoValido);
            

        }
    }
}