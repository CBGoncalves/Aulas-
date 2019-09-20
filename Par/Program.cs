using System;

namespace Par
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            string func;

            
            do{

            Console.WriteLine("Digite um numero");
            x = int.Parse (Console.ReadLine());

            if (x % 2 == 0){
                Console.WriteLine("Par");

            }else{
                Console.WriteLine("Impar");
                }

            Console.WriteLine("(1) para ir novamente ou (f) para sair");
            func = Console.ReadLine();}

            while(func == "1"); 
        }
    }
}
