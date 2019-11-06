using System;
using System.Collections.Generic;

namespace Ordem_Alfabética
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1;
            string nome2;

            System.Console.WriteLine("Digite um nome:");
            nome1 = Console.ReadLine();
            
            System.Console.WriteLine("Digite outro nome:");
            nome2 = Console.ReadLine();

            Console.Clear();
            System.Console.WriteLine("os nomes em ordem alfabética são:");
            
            List<string> Lista = new List<string> ();

            Lista.Add (nome1);
            Lista.Add (nome2);

            Lista.Sort();

            foreach (string item in Lista)
            System.Console.WriteLine(item);


        }
    }
}
