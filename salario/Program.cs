using System;

namespace salario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario;
            double aumento;

            Console.Write("Qual o seu salario ");
            salario = double.Parse(Console.ReadLine());

            if (salario < 500) {
                aumento = salario * 0.3;

                salario += aumento; 

                Console.WriteLine("Voce ganhou um aumento");
                Console.WriteLine("Seu novo salario é " + salario);
            } else {
                Console.WriteLine("Desculpe, sem aumento salarial para você!");
            }

        }
    }
}
