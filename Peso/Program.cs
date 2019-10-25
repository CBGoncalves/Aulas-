using System;

namespace Peso
{
    class Program
    {
        static void Main(string[] args)
        {
            string menuBar ="================================";
            string func;
            int oper;
            double Pplaneta = 0;
            double Pterra = 0; 

            do{
                Console.Clear();
                System.Console.WriteLine(menuBar);
                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("      PESO ESPACIAL      ");
                System.Console.WriteLine("                         ");
                System.Console.WriteLine("    Escolha um Planeta   ");
                Console.ResetColor();
                System.Console.WriteLine(menuBar);

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.ForegroundColor = ConsoleColor.Black;
                System.Console.WriteLine("|(1)Mercúrio|(2)Vênus|(3)Marte|(4)Júpiter|(5)Saturno|(6)Urano|");
                Console.ResetColor();
                oper = int.Parse(Console.ReadLine());
                

                switch(oper){

                    case 1:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Mercúrio");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = Pterra * 0.37;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;

                    case 2:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Vênus");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = (Pterra/10) * 0.88;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;

                    case 3:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Marte");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = (Pterra/10) * 0.38;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;

                    case 4:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Júpiter");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = (Pterra/10) * 2.64;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;

                    case 5:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Saturno");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = (Pterra/10) * 1.15;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;

                    case 6:

                    Console.Clear();
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.ForegroundColor = ConsoleColor.Black;
                    System.Console.WriteLine("Urano");
                    Console.ResetColor();

                    System.Console.WriteLine("Digte o seu peso");
                    Pterra = double.Parse(Console.ReadLine());
                    Pplaneta = (Pterra/10) * 1.17;
                    System.Console.WriteLine("Seu peso em Mercúrio é de: {0}",Pplaneta);

                    break;
                }

                System.Console.WriteLine("(1) Ir Novamente|(0) Sair");
                func = Console.ReadLine();
                

            }while(func == "1");
        }
    }
}
