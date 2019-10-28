using System;

namespace IMC
{
    class Program
    {
        static void Main(string[] args)
        {
        double altura = 0; 
        double peso = 0;
        double total;   
        string func;
        string menuBar = "==============================";

        do{
        Console.Clear();    
        System.Console.WriteLine(menuBar);
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.WriteLine("             IMC              ");
        System.Console.WriteLine("   Índice de Massa Corporal   ");
        Console.ResetColor();
        System.Console.WriteLine(menuBar);

        System.Console.WriteLine("Digite seu peso (kg): ");
        peso = double.Parse(Console.ReadLine());

        System.Console.WriteLine("Digite sua altura (Metros): ");
        altura = double.Parse(Console.ReadLine());

        total = peso / Math.Pow(altura, 2);
        

        if (total <= 20){
            System.Console.WriteLine("Seu IMC é de {0}",total);
            System.Console.WriteLine("Você esta abaixo do peso");
            
        } else if((total > 20) && (total < 25)){
            System.Console.WriteLine("Seu IMC é de {0}",total);
            System.Console.WriteLine("Sei IMC está normal");

        }else if((total > 25) && (total < 30 )){
            System.Console.WriteLine("Seu IMC é de {0}",total);
            System.Console.WriteLine("Você está com excesso de peso");

        }else if((total > 30) && (total < 35)){
            System.Console.WriteLine("Seu IMC é de {0}",total);
            System.Console.WriteLine("Se ta obeso");

        }else if(total > 35){
            System.Console.WriteLine("Seu IMC é de {0}",total);
            System.Console.WriteLine("Obesidade Mórbida");

        }

        System.Console.WriteLine("|(1) Para ir Novamente|(0) Para sair");
        func = Console.ReadLine();
        }while (func == "1");

        }
    }
}
