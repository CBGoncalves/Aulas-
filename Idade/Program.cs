using System;

namespace Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 0;

            Console.WriteLine("Digite sua Idade ");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 2){
                Console.WriteLine("Recém nascido.");
            }

            else if (idade >= 3 && idade <= 11){
                Console.WriteLine("Criança. ");
                }

            else if (idade >= 12 && idade <= 19){
                Console.WriteLine("Adolecente. ");
                }

            else if (idade >= 20 && idade <= 65){
                Console.WriteLine("Adulto. ");
                }
            
            else if (idade > 65){
                Console.WriteLine("Idoso. ");
            }



            


        }
    }
}
