using System;

namespace Área_Retangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            double total;
            string func;
            int oper;
            string menuBar ="================================";

            do{
                    
            Console.Clear();
            System.Console.WriteLine(menuBar);
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            System.Console.WriteLine("            RETANGULO           ");
            System.Console.WriteLine("        Escolha uma opção       ");
            Console.ResetColor();
            System.Console.WriteLine(menuBar);

            System.Console.WriteLine("|(1) Área|(2) Perímetro|(3)Diagonal|");
            oper = int.Parse(Console.ReadLine());
            
            switch (oper){

            case 1:
            System.Console.WriteLine("Digite o valor da base");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura");
            num2 = int.Parse(Console.ReadLine());
            total = num1 * num2;
            System.Console.WriteLine("A area do retangulo é de: {0}",total);

            break;

            case 2:
            System.Console.WriteLine("Digite o valor da base");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura");
            num2 = int.Parse(Console.ReadLine());
            total = 2 * num1 + num2;
            System.Console.WriteLine("O Perímetro do retangulo é de: {0}",total);
            break;

            case 3:
            System.Console.WriteLine("Digite o valor da base");
            num1 = int.Parse(Console.ReadLine());
            System.Console.WriteLine("Digite o valor da altura");
            num2 = int.Parse(Console.ReadLine());
            total = num1 * 2 + num2 * 2 % 2;
            System.Console.WriteLine("A Diagonal do retangulo é de: {0}",total);
            break;
            }

            System.Console.WriteLine("(1) Para ir novamente| (0) Para sair");
            func = Console.ReadLine();

            }while(func == "1");
        

        }
    }
}
