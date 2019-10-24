using System;

namespace Tabuada_do_5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i <=10; i++){
                for(int j=1; j<=10;j++){
                    Console.Write($"{j,-2} * {i,-2} = {j*i,-3}\t");
                }
                Console.WriteLine();
            }
        }
    }
}