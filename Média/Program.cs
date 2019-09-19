using System;

namespace Média
{
    class Program
    {
        static void Main(string[] args)
        {
         double nota1, nota2, nota3, nota4, media;
         int Nota = 0;

         Console.Write("Entre a primeira nota: ");
         nota1 = double.Parse(Console.ReadLine());
         Console.Write("Entre a segunda nota: ");
         nota2 = double.Parse(Console.ReadLine());
         Console.Write("Entre a terceira nota: ");
         nota3 = double.Parse(Console.ReadLine());
         Console.Write("Entre a quarta nota: ");
         nota4 = double.Parse(Console.ReadLine());

         media = (nota1 + nota2 + nota3 + nota4) / 4;
         Console.Write("A média é: " + media);

         if (Nota < 7.0){
            Console.WriteLine("Reprovado");
         } else{ 
            Console.WriteLine("Aprovado");
        }    

        }

        


    }
}
