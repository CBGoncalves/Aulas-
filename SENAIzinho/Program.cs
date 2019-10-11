using System;

namespace SENAIzinho {
    class Program {

        Aluno aluno = new Aluno ();
        Sala sala = new Sala ();

        static void Main (string[] args) {

            bool inicio = false;

            do {
                System.Console.WriteLine ("===============================");
                System.Console.WriteLine ("       Cadastro de Alunos");
                System.Console.WriteLine ("===============================");

                System.Console.WriteLine ("Escolha uma opção");

                System.Console.WriteLine ("|(1) - Cadastrar Aluno|");
                System.Console.WriteLine ("|(2) - Cadastrar Sala|");
                System.Console.WriteLine ("|(3) - Alocar Aluno|");
                System.Console.WriteLine ("|(4) - Remover Aluno|");
                System.Console.WriteLine ("|(5) - Verificar Salas|");
                System.Console.WriteLine ("|(6) - Verificar Alunos|");
                System.Console.WriteLine ("|(0) – Sair|");
                string opcao = Console.ReadLine ();
                Console.Clear ();

                switch (opcao) {
                    case "1":
                        CadastrarAluno ();

                        break;

                    case "2":
                        CadastrarSala ();

                        break;

                    case "3":
                        AlocarAluno ();

                        break;
                }
            } while (!inicio);
        }
        public void CadastrarAluno () {

            if (sala.capacidadeAtual <= 100) {
                System.Console.WriteLine ("Nome: ");
                aluno.Nome = Console.ReadLine ();

                System.Console.WriteLine ("Data de Nascimento: ");
                aluno.DataNascimento = DateTime.Parse (Console.ReadLine ());
            } else {
                System.Console.WriteLine ("A escola não comporta mais alunos");
            }
            System.Console.WriteLine ();
            System.Console.WriteLine ($"Precione ENTER para voltar ao menu");
            Console.ReadLine ();
            Console.Clear ();

        }

        public void CadastrarSala () {
            bool capacidade = false;

            do {
                System.Console.WriteLine ("Capacidade Total: ");
                sala.capacidadeTotal = int.Parse (Console.ReadLine ());
                if (sala.sala <= 10) {
                    System.Console.WriteLine ("Numero Valido");
                } else {
                    System.Console.WriteLine ("A capacidade total não pode passar de 10 alunos");
                }
            } while (!capacidade);

            System.Console.WriteLine ("Numero da Sala: ");
            sala.numeroSala = int.Parse (Console.ReadLine ());

            System.Console.WriteLine ("Alunos: ");
            sala.alunos = Console.ReadLine ();

        }

        public void AlocarAluno () {

            System.Console.WriteLine ($"Nome: {aluno.Nome} ");

            bool alocar = false;

            do {
                System.Console.WriteLine ("Digite o numero da sala:");
                sala.numeroSala = int.Parse (Console.ReadLine ());

                if (sala.capacidadeAtual < 10) {
                    System.Console.WriteLine ("Aluno alocado");
                } else {
                    System.Console.WriteLine ("Esta sala esta lotada");
                }
            } while (!alocar);
        }

        public void VarificarSalas () {

        }

    }
}