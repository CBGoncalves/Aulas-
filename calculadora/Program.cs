using System;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;
            string oper;

            Console.WriteLine("Digite o 1° Número");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2° Número");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o operador desejado");
            oper = Console.ReadLine();

            switch (oper) {
                case 1:
                    Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
                    break;

                case 2:
                    Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
                    break;

                case 3: 
                Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
                    break;

                case 4:
                Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
                    break;

                default:
                    Console.WriteLine("Operador não encontrado");
                    break;



            }
            
            
            
            
            
            


        }
    }
}
