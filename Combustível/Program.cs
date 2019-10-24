using System;

namespace Combustível
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            int t = 0;
            double total1;
            double total2;
            string func;
            string menuBar ="================================";


            do{   

            Console.Clear();
            System.Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("           COMBUSTÍVEL           ");
            System.Console.WriteLine("    Pensando em uma descrição    ");
            Console.ResetColor();
            System.Console.WriteLine(menuBar);

            System.Console.WriteLine("Digite o Tempo de viagem");
            t = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite a Velocidade média");
            v = int.Parse(Console.ReadLine());

            total1 = t * v;
            total2 = total1 / 12;

            System.Console.WriteLine("Sua distancia é de: {0}",total1);
            System.Console.WriteLine("Você usou litros: {0}",total2);

            System.Console.WriteLine("|(1) Para ir Novamente|(0) Para Sair");
            func = Console.ReadLine();
            
            }while(func == "1");
        }
    }
}
