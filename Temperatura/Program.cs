using System;

namespace Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
        double grauC = 0;
        double total;
        string func;
        string menuBar = "============";

        do{
        System.Console.WriteLine(menuBar);
        Console.BackgroundColor = ConsoleColor.DarkYellow;
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine("CONVERÇÃO °F");
        Console.ResetColor();
        System.Console.WriteLine(menuBar);

        System.Console.WriteLine("Digite a temperatura em graus Celsius");
        grauC = double.Parse(Console.ReadLine());
        total = grauC * 1.8 + 32;
        System.Console.WriteLine("A temperatura em Fahrenheit é de: {0}",total);

        System.Console.WriteLine("|(1) Para ir Novamente|(0) Para sair");
        func = Console.ReadLine();
        
        }while(func == "1");

        }
    }
}
