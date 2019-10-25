using System;
using System.Collections.Generic;

namespace Ordem_Numérica
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;

            System.Console.WriteLine("Digite um número:");
            n1 = double.Parse(Console.ReadLine());
            
            System.Console.WriteLine("Digite outro número:");
            n2 = double.Parse(Console.ReadLine());

            Console.Clear();
            System.Console.WriteLine("os números em ordem crescente são:");
            
            List<double> Lista = new List<double> ();

            Lista.Add (n1);
            Lista.Add (n2);

            Lista.Sort();

            System.Collections.IList list = Lista;
            for (int i = 0; i < list.Count; i ++)
            {
                double item = (double)list[i];
                System.Console.WriteLine(item);
            }
        }
    }
}
