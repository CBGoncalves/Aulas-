using System;

namespace helpizinho
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 12;

            int num3 = 0;
            int num4 = 30;

            int num5 = 0;
            int num6 = 24;

            int num7 = 0;
            int num8 = 60;

            
            Console.WriteLine("Qual sua idade");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");

            Console.WriteLine("Quantos meses voce tem");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num3} * {num4} = {num3 * num4}");

            Console.WriteLine("Quantos dias voce tem");
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num5} * {num6} = {num5 * num6}");

            Console.WriteLine("Quantas horas voce tem");
            num5 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num7} * {num8} = {num7 * num8}");

        }
    }
}
